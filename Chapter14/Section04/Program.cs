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
            { "さいたま",4310 },
        };
        List<int> cityCode = new List<int>();

        public Program() {
            Console.WriteLine("yahoo! 週間天気予報" + "\n");
            Console.WriteLine("地域コードを入力してください。\n");
            int count = 1;

            foreach (var s in AreaDic) {
                Console.WriteLine("{0}:{1}", count + 1, s.Key);
                cityCode.Add(s.Value);
            }
            Console.WriteLine("9:その他");
            Console.Write(">");

            var selectArea = Console.ReadLine();
            int pos = int.Parse(selectArea);
            int code;

            if (pos != 9) {
             code = cityCode[pos - 1];
            }
            else {
                Console.WriteLine("都市コードを入力:");
                code = int.Parse(Console.ReadLine());
                
            }

            var results = GetWeatherReportFromYahoo(code);
            
            Console.WriteLine("*****************\n");
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
