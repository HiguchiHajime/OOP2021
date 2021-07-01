using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
    class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Console.WriteLine("ページ数が４００ページ以上の書籍を降順に表示");
            Exercise2_6(books);
            Console.WriteLine("-----");

            Console.WriteLine("タイトルにC#が含まれていて５００ページ以下の書籍");
            Exercise2_7(books);
        }
        
        private static void Exercise2_1(List<Book> books) {
            var book = books.FirstOrDefault(b => b.Title == "ワンダフル・C#ライフ");
            if(book != null) {
                Console.WriteLine("ワンダフル・C#ライフの価格は{0}:ページ数は{1}です", book.Price, book.Pages);
            }
        }

        private static void Exercise2_2(List<Book> books) {
            var bookcount = books.Count(b => b.Title.Contains("C#"));
            Console.WriteLine("タイトルにC#が含まれている書籍の数は{0}冊です",bookcount);
        }

        private static void Exercise2_3(List<Book> books) {
            var Book = books.Where(b => b.Title.Contains("C#")).Average(b => b.Pages);
            Console.WriteLine("タイトルにC#が含まれている書籍のページ数平均は{0}ページです", Book);
        }

        private static void Exercise2_4(List<Book> books) {
            var Book = books.FirstOrDefault(n => n.Price >= 4000);
            if (Book != null) {
                Console.WriteLine("価格が4000円以上の最初に見つかった書籍：{0}", Book.Title);
            }
        }

        private static void Exercise2_5(List<Book> books) {
            var BelowBookPage = books.Where(p => p.Price < 4000).Max(p => p.Pages);
            Console.WriteLine("価格が４０００円未満で最大のページ数:{0}",BelowBookPage);
        }

        private static void Exercise2_6(List<Book> books) {
            var TargetBooks = books.Where(p => p.Pages >= 400).OrderByDescending(x => x.Price);
            
            foreach (var ta in TargetBooks)
                Console.WriteLine("タイトル:{0} 価格:{1}",ta.Title,ta.Price);
        }

        private static void Exercise2_7(List<Book> books) {
            var Titlebooks = books.Where(b => b.Title.Contains("C#") && b.Pages <= 500);
            foreach (var bo in Titlebooks)
                Console.WriteLine("タイトル:{0}", bo.Title);
        }

    }



}
