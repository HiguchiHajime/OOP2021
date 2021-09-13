using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form31063 : Form {
        IEnumerable<item> items;

        public Form31063() {
            InitializeComponent();
        }
        private void Form31063_Load(object sender, EventArgs e) {
            btWebbro.Enabled = false;

        }
        private void btRead_Click(object sender, EventArgs e) {
            SetRssTitle(tbUrl.Text);
            
        }

        private void SetRssTitle(string Url) {
            lbTitles.Items.Clear();
            try {
                using (var wc = new WebClient()) {
                    wc.Headers.Add("Content-type", "charset=UTF-8");
                    var stream = wc.OpenRead(Url);

                    XDocument xdoc = XDocument.Load(stream);
                    items = xdoc.Root.Descendants("item")
                                    .Select(x => new item
                                    {
                                        Title = (string)x.Element("title"),
                                        Url = (string)x.Element("link"),
                                        pubData = (DateTime)x.Element("pubDate"),
                                        Description = (string)x.Element("description")
                                    });
                    foreach (var item in items) {
                        lbTitles.Items.Add(item.Title);
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        // RSSからdescriptionを読み取ってテキストボックスに表示する
        private void lbTitles_MouseDoubleClick(object sender, MouseEventArgs e) {
            tbDes.Clear();
            tbDes.Text = (items.ToArray())[lbTitles.SelectedIndex].pubData.ToString() + "\r\n";
            tbDes.Text += (items.ToArray())[lbTitles.SelectedIndex].Description.ToString();
            btWebbro.Enabled = true;
        }

        // 新しくフォームを作成し、RSSから読み取ったウェブページを開く
        private void btWebbro_Click(object sender, EventArgs e) {
            Form2 WebForm = new Form2(new Uri(((items.ToArray())[lbTitles.SelectedIndex].Url)));
            WebForm.Show();
        }


    }
}