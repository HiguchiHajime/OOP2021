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

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            cbCityName.Items.Add("前橋");
            cbCityName.Items.Add("みなかみ");
            cbCityName.Items.Add("宇都宮");
            cbCityName.Items.Add("水戸");
        }

        private void btWeatherReport_Click(object sender, EventArgs e) {
            Weather.Clear();
            int CityNum = 0;
            switch (cbCityName.Text) {
                case "前橋":
                    CityNum = 4210;
                    break;
                case "みなかみ":
                    CityNum = 4220;
                    break;
                case "宇都宮":
                    CityNum = 4110;
                    break;
                case "水戸":
                    CityNum = 4010;
                    break;

            }
            var result = GetWeatherReportFromYahoo(CityNum);

            foreach (var s in result) {
                Weather.Text += s + "\r\n";
            }
        }

        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    string s = Regex.Replace(node.Value, "【|】", "");
                    yield return s;
                }
            }
        }
    }
}
