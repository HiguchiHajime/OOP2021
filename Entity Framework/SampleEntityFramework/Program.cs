using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {

            #region
            //データの追加
            //InsertBooks();
            //DisplayAllBooks();
            //AddAuthors();
            //AddBooks();
            //UpdateBook();
            //DeleteBook();
            //var db = new BooksDbContext();

            //var authors = db.Authors.Where(a => a.Books.Count() >= 2);

            //foreach (var author in authors) {
            //    Console.WriteLine($"{author.Name} {author.Gender} {author.Birthday}");
            //}

            //var books = db.Books
            //              .OrderBy(b => b.PublishedYear)
            //              .ThenBy(b => b.Author.Name);
            //foreach(var book in books) {
            //    Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
            //}

            //var groups = db.Books
            //               .GroupBy(b => b.PublishedYear)
            //               .Select(g => new
            //               {
            //                   Year = g.Key,
            //                   Count = g.Count()
            //               });
            //foreach (var g in groups) {
            //    Console.WriteLine($"{g.Year}{g.Count}");
            //}

            //var author2 = db.Authors
            //               .Where(a => a.Books.Count() ==
            //                           db.Authors.Max(x => x.Books.Count())).First();
            //Console.WriteLine($"{author2.Name} {author2.Gender} {author2.Birthday}");
            #endregion
            Console.WriteLine("#1.1");
            //Exercise13_1();
            Console.WriteLine("#1.2");
            Exercise13_2();
            Console.WriteLine("#1.3");
            Exercise13_3();
            Console.WriteLine("#1.4");
            Exercise13_4();
            Console.WriteLine("#1.5");
            Exercise13_5();
        }

        private static void Exercise13_1() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author
                {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛"
                };

                db.Authors.Add(author1);

                var author2 = new Author
                {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };

                db.Authors.Add(author2);
                db.SaveChanges();

                var Author1 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book1 = new Book
                {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = Author1,
                };

                db.Books.Add(book1);

                var Author2 = db.Authors.Single(a => a.Name == "川端康成");
                var book2 = new Book
                {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = Author2,
                };
                db.Books.Add(book2);

                var Author3 = db.Authors.Single(a => a.Name == "菊池寛");
                var book3 = new Book
                {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = Author3,
                };
                db.Books.Add(book3);

                var Author4 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book4 = new Book
                {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = Author4,
                };
                db.Books.Add(book4);
                db.SaveChanges();

                db.SaveChanges();
            }
        }

        private static void Exercise13_2() {
            var db = new BooksDbContext();


            foreach (var book in db.Books) {
                Console.WriteLine($"書籍名:{book.Title} 著者名:{book.Author.Name} 発行年:{book.PublishedYear}");
            }
        }

        private static void Exercise13_3() {

            var db = new BooksDbContext();

            var books = db.Books.Where(s => s.Title.Length == db.Books.Max(d => d.Title.Length));

            foreach(var book in books)
            Console.WriteLine($"タイトルが最も長い書籍は: {book.Title}");
        }

        private static void Exercise13_4() {
            var db = new BooksDbContext();

            var books = db.Books.OrderBy(x => x.PublishedYear).Take(3).ToList();
            Console.WriteLine($"発行年が古い順の3冊は");
            foreach (var book in books) {
                Console.WriteLine($"タイトル:{book.Title} 著者名:{book.Author.Name}");
            }

        }

        
        private static void Exercise13_5() {
            var db = new BooksDbContext();

            var books = db.Books.OrderByDescending(x => x.Author.Birthday);
            
            foreach(var book in books) {
                Console.WriteLine($"誕生日:{book.Author.Birthday} 著者名: {book.Author.Name} 書籍名: {book.Title}");
            }

        }



        private static void DeleteBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x=> x.id == 10);
                if(book != null)
                {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
                db.SaveChanges();
            }
        }

        private static void UpdateBook() {
            
            using(var db = new BooksDbContext()) {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }


        }


        // List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book
                {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);


                var book2 = new Book
                {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author
                    {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);

                db.SaveChanges();

            }
        }

        //List 13-7
        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext()) {

                return db.Books.Where(book => book.Author.Name.StartsWith("夏目")).ToList();
            }

        }

        // List 13-8
        static void DisplayAllBooks() {
            var books = GetBooks();
            foreach(var book in books) {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }
            Console.ReadLine(); // 一時停止させる
        }

        // List 13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author
                {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };

                db.Authors.Add(author1);

                var author2 = new Author
                {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };

                db.Authors.Add(author2);
                db.SaveChanges();
               
            }
        }

        // List 13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book
                {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };

                db.Books.Add(book1);

                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book
                {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }
    }
}
