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
        public Form31063() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            SetRssTitle(tbUrl.Text);
        }


        private void SetRssTitle(string Url) {
            //lbTitles.Items.Clear();
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var stream = wc.OpenRead(Url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    lbTitles.Items.Add(node.Value);
                }
            }
        }

        private void lbTitles_MouseDoubleClick(object sender, MouseEventArgs e) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var stream = wc.OpenRead(tbUrl.Text);

                XDocument xdoc = XDocument.Load(stream);
                var Title = lbTitles.SelectedItem.ToString();
                //var l = lbTitles.SelectedItem.ToString();
                //foreach(var element in elements) {
                //    webBrowser1.Navigate(element.Value);
                //}
            }

            }
        }
    }