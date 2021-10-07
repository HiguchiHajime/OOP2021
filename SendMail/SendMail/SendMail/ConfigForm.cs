using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail {
    public partial class ConfigForm : Form {
        private Settings settings = Settings.getInstance();
        public ConfigForm() {
            InitializeComponent();
        }

        


        private void btDefault_Click(object sender, EventArgs e) {
            tbHost.Text = settings.sHost();
            tbPort.Text = settings.sPort();
            tbUserName.Text = settings.sMailAddr();
            tbPass.Text = settings.sPass();
            cbSsl.Checked = settings.sSsl();
        }

        // 送信データ登録
        private void SettingRegist() {
            
        }

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btApply_Click(object sender, EventArgs e) {
            SettingRegist();
        }
       

        private void btOK_Click(object sender, EventArgs e) {
            if (CheckSet()) {
                SettingRegist();
                this.Close();
            }
        }

        private bool CheckSet() {
            if (tbHost.Text == string.Empty) {
                MessageBox.Show("ホスト名が入力されていません");
                return false;
            }
            if (tbPort.Text == string.Empty) {
                MessageBox.Show("ポート番号が入力されていません");
                return false;
            }
            if (tbUserName.Text == string.Empty) {
                MessageBox.Show("ユーザ情報が入力されていません");
                return false;
            }

            return true;
        }

        private void ConfigForm_Load(object sender, EventArgs e) {
            if(File.Exists("Settings.xml"))
            Settings.ReadConfig();
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = settings.MailAddr;
            tbPass.Text = settings.Pass;
            cbSsl.Checked = settings.Ssl;
        }
    }
}
