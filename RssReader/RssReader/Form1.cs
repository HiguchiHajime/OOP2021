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
        List<string> Linklist = new List<string>();
        List<string> DesList = new List<string>();

        public Form31063() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            SetRssTitle(tbUrl.Text);
            
        }

        private void SetRssTitle(string Url) {
            lbTitles.Items.Clear();
                using (var wc = new WebClient()) {
                    wc.Headers.Add("Content-type", "charset=UTF-8");
                    var stream = wc.OpenRead(Url);

                    XDocument xdoc = XDocument.Load(stream);
                    var nodes = xdoc.Root.Descendants("item");
                    foreach (var node in nodes) {
                        var xtitle = node.Element("title");
                        var xlink = node.Element("link");
                        var xdes = node.Element("description");
                        lbTitles.Items.Add(xtitle.Value);
                        Linklist.Add(xlink.Value);
                        DesList.Add(xdes.Value);
                    }
                }
        }

        private void lbTitles_MouseDoubleClick(object sender, MouseEventArgs e) {
            tbDes.Clear();
            tbDes.Text += DateTime.Now.ToString();
            tbDes.Text += "\r\n" + DesList[lbTitles.SelectedIndex].ToString();
        }

        //private void lblDescription_MouseClick(object sender, MouseEventArgs e) {
        //    webBrowser1.Navigate(Linklist[lbTitles.SelectedIndex].ToString());
        //}

        private void btWebbro_Click(object sender, EventArgs e) {
            Form Webform = new Form();
            WebBrowser web = new WebBrowser();
            Webform.Size = new Size(1300,700);
            web.Size = Webform.Size;
            web.ScriptErrorsSuppressed = true;
            Webform.Controls.Add(web);
            web.Navigate(Linklist[lbTitles.SelectedIndex]);
            
            Webform.Show();
        }
    }
}