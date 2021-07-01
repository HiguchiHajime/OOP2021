using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は" + books.Average( x=> x.Price).ToString("#,0") + "円");
            Console.WriteLine("本のページ数の合計は" + books.Sum(x => x.Pages) + "ページ");
            Console.WriteLine("一番高い本は" + books.Max(x => x.Price) + "円");
            Console.WriteLine("一番安い本は" + books.Min(x => x.Price) + "円");
            Console.WriteLine("本は" + books.Count() + "冊あります");
            //500円以上の本は何冊あるか
            Console.WriteLine("500円以上の本は" + books.Where(x => x.Price >= 500).Count() + "冊あります");
        }
    }
}
