using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    // 売上集計クラス
    public class SalesCounter {
        private List<Sale> _sales;

        public SalesCounter(List<Sale> sales) {
            _sales = sales;
        }

        // 店舗売り上げを求める
        public Dictionary<string,int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                    // ContainsKeyは店舗名がコレクションの中にあるかどうかを調べている。
                if (dict.ContainsKey(sale.ShopName))
                    // すでにコレクションに店舗が設定されている
                    dict[sale.ShopName] += sale.Amount;
                else
                    // コレクションに店舗を登録
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
    }
}
