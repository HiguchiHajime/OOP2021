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
                new YearMonth(2005,12),
                new YearMonth(2012,5),
                new YearMonth(2020,12),
                };
            // 4.2.2
            Exercise2_2(ym);
            Console.WriteLine("---------");

            // 4.2.4
            Exercise2_4(ym);
            Console.WriteLine("---------");

            // 4.2.5
            Exercise2_5(ym);

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

        static void Exercise2_4(YearMonth[] ym) {
            var year = FindFirst21C(ym);
            Console.WriteLine(year?.Year.ToString() + "年" ?? "２１世紀のデータはありません");

        }

        private static void Exercise2_5(YearMonth[] ym) {
            var qury = ym.Select(s => s.AddOneMonth()).ToArray();
            foreach (var YM in qury) {
                Console.WriteLine(YM);
            }
        }
    }
}
