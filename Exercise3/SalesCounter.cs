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


        // カテゴリ別売り上げを求める
        public IDictionary<string,int> GetPerCategorySales() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ProductCategory))
                    // すでにコレクションにカテゴリが設定されている
                    dict[sale.ProductCategory] += sale.Amount;
                else
                    // コレクションにカテゴリを登録
                    dict[sale.ProductCategory] = sale.Amount;
            }
            

            return dict;
        }
    }
}
