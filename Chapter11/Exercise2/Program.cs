using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            var xdoc = XDocument.Load("11_2.xml");
            var newfile = "kanji.xml";
            var pairs = xdoc.Root.Elements()
                                 .Select(x => new
                                 {
                                     Key = x.Name.LocalName,
                                     Value = x.Value
                                 });

            var dict = pairs.ToDictionary(x => x.Key, x => x.Value);

            var query = dict.Select(s => new XElement("word",
                                         new XAttribute("kanji", s.Key),
                                         new XAttribute("yomi", s.Value)));
            var root = new XElement("difficultkanji", query);

            xdoc.Root.Add(root);
            xdoc.Save("kanji.xml");
             
        }
    }
}
