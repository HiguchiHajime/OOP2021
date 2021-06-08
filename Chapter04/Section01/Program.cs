using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            // null合体演算子
            #region
            //    Name = "新井",
            //    Birthday = new DateTime(1995, 11, 23),
            //    PhoneNumber = "123-3456-7890",
            //};
            //var list = new List<int> { 10, 20, 30, 40 };
            //var key = 140;
            //var num = list.Contains(key) ? 1:0 ;

            //    string code = "12345";
            //    // null合体演算子
            //    var message = GetMessage(code) ?? DefaultMessage();
            //    Console.WriteLine(message);
            //}
            ////スタブ
            //private static object DefaultMessage() {
            //    return "Default Message";
            //}
            //// スタブ
            //private static object GetMessage(object code) {
            //    return null;
            //}
            #endregion  

            //var ret = GetProductA();

            int count = 0;
            Console.WriteLine($"後置：{count++ }");
            Console.WriteLine($"前置：{++count }");
        }
        private static Product GetProductA() {
            Sale sale = new Sale();
            sale.product = new Product();
            //sale = null;
            return sale?.product;  // null条件演算子
        }

    }
        class Sale {
            public string ShopName { get; set; }
            public int Amount { get; set; }
            public Product product { get; set; }
        }

}

