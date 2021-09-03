using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04 {
    class Program {
        static void Main(string[] args) {

            new Program();
        }

        Dictionary<string, int> AreaDic = new Dictionary<string, int>()
        {
            {"前橋",4210 },
            {"みなかみ",4220 },
            { "宇都宮" , 4110},
            { "水戸",4010},
        };

        public Program(){
            Console.WriteLine("yahoo! 週間天気予報" + "\n");
            Console.WriteLine("地域コードを入力してください。\n"
                              + "1:前橋\n" + "2:みなかみ\n" + "3:宇都宮\n" + "4:水戸\n" + "9:その他(直接入力)\n");
            Console.Write("<");


            var n = int.Parse(Console.ReadLine());
            int CityCode = 0;
            switch(n) {
                case 1:
                    CityCode = 4210;
                    break;
                case 2:
                    CityCode = 4220;
                    break;
                case 3:
                    CityCode = 4110;
                    break;
                case 4:
                    CityCode = 4010;
                    break;

                default:
                    Console.WriteLine("地域コードを入力してください。\n");
                    CityCode = int.Parse(Console.ReadLine());
                    break;
            }

            
            Console.WriteLine("*****************\n");

            var results = GetWeatherReportFromYahoo(CityCode);
            foreach (var s in results) {
                Console.WriteLine(s);
            }
            Console.WriteLine("*****************");
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
