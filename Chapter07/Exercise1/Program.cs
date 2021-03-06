using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<Char, int>();
            foreach (var c in text) {
                var uc = char.ToUpper(c);
                if ('A' <= uc && uc <= 'Z') {
                    if (dict.ContainsKey(uc)) {
                        dict[uc]++;
                    }
                    else {
                        dict[uc] = 1;
                    }
                }
            }
            foreach (var v in dict.OrderBy(n => n.Key))
                Console.WriteLine("{0}:{1}", v.Key, v.Value);
        }


        private static void Exercise1_2(string text) {
            var sortdict = new SortedDictionary<char,int>();
            foreach (var c in text) {
                var uc = char.ToUpper(c);
                if ('A' <= uc && uc <= 'Z') {
                    if (sortdict.ContainsKey(uc)) {
                        sortdict[uc]++;
                    }
                    else {
                        sortdict[uc] = 1;
                    }
                }
            }
            foreach (var v in sortdict.OrderBy(n => n.Key))
                Console.WriteLine("{0}:{1}", v.Key, v.Value);
        }
    }
}
       
