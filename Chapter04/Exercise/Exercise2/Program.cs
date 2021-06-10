using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            // 4.2.1
            var ym = new YearMonth[] {
                new YearMonth(1980,1),
                new YearMonth(1990,7),
                new YearMonth(2001,8),
                new YearMonth(2020,5),
                new YearMonth(2021,8),
                };
            // 4.2.2
            Exercise2_2(ym);
            Console.WriteLine("------");


        }



        private static void Exercise2_2(YearMonth[] ym) {
            foreach (var yemo in ym) {
                Console.WriteLine(yemo);
            };
        }

        // 4.2.3
        static YearMonth FindFirst21C(YearMonth[] ym) {
            foreach (var YM in ym) {
                if (YM.Is21Centurury) {
                    return YM;
                }
            }
            return null;
        }
    }
}
