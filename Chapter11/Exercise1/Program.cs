using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine("-----------");
            Exercise1_2(file);
            Console.WriteLine("-----------");
            Exercise1_3(file);
            Console.WriteLine("-----------");

        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().Select(x => new
            {
                Name = x.Element("name").Value,
                Teammembers = x.Element("teammembers").Value
            });

            foreach(var xsports in xelements) {

                Console.WriteLine("競技名:{0},メンバー数:{1}",xsports.Name,xsports.Teammembers);
            }
 
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xsports = xdoc.Root.Elements().OrderBy(x => (int)(x.Element("firstplayed")));
            foreach(var xsport in xsports) {
                var xname = xsport.Element("name").Attribute("kanji");
                var xyear = xsport.Element("firstplayed");
                Console.WriteLine("競技名:{0},最初にプレーされた年:{1}", xname.Value, xyear.Value);
            }

        }

        private static void Exercise1_3(string file) {
            //var xdoc = XDocument.Load(file);
            //var xsports = xdoc.Root.Elements().Select(s => new
            //{
            //    Name =
            //}) ;

            //foreach(var xsport in xsports) {
            //    Console.WriteLine("最もメンバー数が多い競技は:{0}です。メンバー数:{1}人",xsport.Name,xsport.Teammembers);
            //}

         
        }
    }
}
