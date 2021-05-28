using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    public class InchConverter {
        private const double inch = 0.0254;

        //インチからメートルを求める
        public static double ToMeter(double meter) {
            return meter * inch; 
        }

    }
}
