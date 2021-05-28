using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    // 売上集計クラス
    public class SalesCounter {
        private IEnumerable<Sale> _sales;

        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }


        // リスト2-15
        // 売上データを読み込み、saleオブジェクトのリストを返す
        private static IEnumerable<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }


        // 店舗売り上げを求める
        public IDictionary<string,int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
            // ContainsKeyは店舗名がコレクションの中にあるかどうかを調べている。
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ProductCategory))
                    // すでにコレクションに店舗が設定されている
                    dict[sale.ProductCategory] += sale.Amount;
                else
                    // コレクションに店舗を登録
                    dict[sale.ProductCategory] = sale.Amount;
            }
            return dict;
        }
    }
}
