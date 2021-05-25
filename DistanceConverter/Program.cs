using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {

        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                // フィートからメートルへの対応表を出力
                PrintFeetToMeterList(1,15);
            }
            else {
                //メートルからフィートへの対応表を出力
                PrintMeterToFeet(5,20);
            }
        }

        private static void PrintFeetToMeterList(int start,int stop) {
            FeetConverter feetConverter = new FeetConverter();
            for (int feet = start; feet <= stop; feet++) {
                double meter = feetConverter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        private static void PrintMeterToFeet(int start, int stop) {
            FeetConverter feetConverter = new FeetConverter();
            for (int meter = start; meter <= stop; meter++) {
                double feet = feetConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000}ft", meter, feet);
            }
        }

    }
}
