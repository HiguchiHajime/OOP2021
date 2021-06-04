﻿using System;
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
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };
            //// 3.1.1
            //Exercise1_1(numbers);
            //Console.WriteLine("-----");

            //// 3.1.2
            //Exercise1_2(numbers);
            //Console.WriteLine("-----");

            //// 3.1.3
            //Exercise1_3(numbers);
            //Console.WriteLine("-----");

            //// 3.1.4
            //Exercise1_4(numbers);


            //// 3.2.1
            //Exercise2_1(names);
            //Console.WriteLine();

            //// 3.2.2
            //Exercise2_2(names);
            //Console.WriteLine();

            //// 3.2.3
            //Exercise2_3(names);
            //Console.WriteLine();

            //// 3.2.4
            //Exercise2_4(names);

            // 追加問題
            Exercise2_5(names);

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
            //IEnumerable<int> num = numbers.Where(s => s >= 50);
            foreach (var n in numbers.Where(n=> n >= 50))
                Console.WriteLine(n);
        }

        private static void Exercise1_4(List<int> numbers) {
            var query = numbers.Select(n => n * 2);
            foreach (var n in query)
                Console.WriteLine(n);
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名の入力＞");
            var line = Console.ReadLine();
            int num = names.FindIndex(s => s == line);
            Console.WriteLine(num);
        }

        private static void Exercise2_2(List<string> names) {
            var query = names.Count(s => s.Contains("o"));
            Console.WriteLine(query);
        }

        private static void Exercise2_3(List<string> names) {
           names.Where(s => s.Contains("o")).ToList().ForEach(Console.WriteLine);
        }

        private static void Exercise2_4(List<string> names) {
           var num = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var n in num)
                Console.WriteLine(n);
        }

        private static void Exercise2_5(List<string> names) {
            //for (int i = 0; i < names.Count; i++) {
            //    var num = names[i].ToCharArray().Count(s => char.IsLower(s));
            //    Console.WriteLine(num);
            //}
            int count = 0;
            foreach(var name in names) {
               count += name.Count(c => char.IsLower(c));
            }
            Console.WriteLine(count);
        }


    }
}
