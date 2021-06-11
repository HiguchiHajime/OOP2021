using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {


            #region  問題5.1
            //var line = Console.ReadLine();
            //var line2 = Console.ReadLine();
            //if (String.Compare(line,line2,ignoreCase:true) == 0) {
            //    Console.WriteLine("上記の文字列は等しい");
            //}
            //else {
            //    Console.WriteLine("等しくない");
            //}
            #endregion

            // 5.2
            var line_num = Console.ReadLine();
            var line_num2 = Console.ReadLine();

            var num = 0;
            var num2 = 0;
            var result = int.TryParse(line_num, out num);
            var result2 = int.TryParse(line_num2, out num2);

            Console.WriteLine($"{num:#,0} {num2:#,0}");


        }
    }
}
