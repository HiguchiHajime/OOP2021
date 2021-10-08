using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.Serialization;

namespace SendMail {
    public partial class Form1 : Form {
        private ConfigForm configForm = new ConfigForm();
        Settings settings =null;
        public Form1() {
            InitializeComponent();
            
            settings = Settings.getInstance();
            if (!Settings.Set)
                configForm.ShowDialog();
            Settings.Set = true;
        }
        
        private void btSend_Click(object sender, EventArgs e) {
            try {
                btSend.Enabled = false;
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(settings.MailAddr);
                //宛先（To）
                if (string.IsNullOrWhiteSpace(tbTo.Text) || string.Empty == tbTo.Text) {
                    MessageBox.Show("宛先を入力してください");
                    btSend.Enabled = true;
                    return;
                }
                else
                    mailMessage.To.Add(tbTo.Text);


                if (tbCc.Text != String.Empty)
                mailMessage.CC.Add(tbCc.Text);

                if(tbBcc.Text != String.Empty)
                mailMessage.Bcc.Add(tbBcc.Text);

                //件名（タイトル）
                mailMessage.Subject = tbTitle.Text;
                //本文
                if (string.IsNullOrWhiteSpace(tbMessage.Text) || string.Empty == tbMessage.Text) {
                    MessageBox.Show("本文を入力してください");
                    btSend.Enabled = true;
                    return;
                }
                else
                    mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials
                    = new NetworkCredential(settings.MailAddr, settings.Pass);
                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = true;

                
                smtpClient.SendCompleted += smtpClient_SendCompleted;
                string userState = "SendMail";
                    smtpClient.SendAsync(mailMessage, userState);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void smtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e) {
            btSend.Enabled = true;
            if (e.Error != null) {
                MessageBox.Show(e.Error.Message);
            }
            else {
                btSend.Enabled = true;
                MessageBox.Show("送信完了");
                TextBoxClear();
            }
        }

        private void TextBoxClear() {
            tbTo.Clear();
            tbCc.Clear();
            tbBcc.Clear();
            tbTitle.Clear();
            tbMessage.Clear();
        }

        private void btConfig_Click(object sender, EventArgs e) {
            configForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) {

            if (!Settings.Set) {
                configForm.ShowDialog();
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 新規作成NToolStripMenuItem_Click(object sender, EventArgs e) {
            TextBoxClear();
        }
    }
}
