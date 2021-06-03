using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            //var names = new List<string> {
            //    "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            //};

            //IEnumerable<string> query = names.Where(s => s.Length <= 5).Select(s=>s.ToLower());
            //foreach (string s in query)
            //    Console.WriteLine(s);

            //string[] names = {
            //    "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra"  };
            //var query = names.Where(s => s.Length <= 5).ToList();

            //foreach (var item in query)
            //    Console.WriteLine(item);
            //Console.WriteLine("------");

            //names[0] = "Osaka";
            //foreach (var item in query)
            //    Console.WriteLine(item);

            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);



        }



        private static void Exercise1_1(List<int> numbers) {
            var exist = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);

            if (exist)
                Console.WriteLine("存在しています");
            else
                Console.WriteLine("存在していません");
        }


        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(s => Console.WriteLine(s / 2.0));
        }

        private static void Exercise1_3(List<int> numbers) {
            IEnumerable<int> num = numbers.Where(s => s >= 50);
            foreach (var n in num)
                Console.WriteLine(n);
        }

        private static void Exercise1_4(List<int> numbers) {
            var query = numbers.Select(n => n * 2).ToList();
            foreach (var n in query)
                Console.WriteLine(n);
        }



    }
}
