using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-toi") {
                PrintInchToMeter(1, 10);
            }
            else {
                PrintMeterToInch(1, 10);
            }
        }

        private static void PrintInchToMeter(int start, int stop) {
            for (double inch = start; inch <= stop; inch++) {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0} in = {1:0.0000} m", inch, meter);
            }
        }

            private static void PrintMeterToInch(int start, int stop) {
                for (double meter = start; meter <= stop; meter++) {
                    double inch = InchConverter.FromMeter(meter);
                    Console.WriteLine("{0} m = {1:0.0000} in", meter, inch);
                }
            }
        }
}