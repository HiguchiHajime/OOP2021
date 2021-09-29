using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    [Serializable]
    public class CarReport {
        [DisplayName("日付")]
        public DateTime ReportDate { get; set; } // 日付
        [DisplayName("記録者")]
        public string ReportAuther { get; set; } // 記録者
        [DisplayName("メーカー")]
        public MakerGroup maker { get; set; }    // メーカー
        [DisplayName("車名")]
        public string CarName { get; set; }      // 車名
        [DisplayName("レポート")]
        public string Report { get; set; }
        public Image Picture { get; set; }

        // メーカー
        public enum MakerGroup {
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外国車,
            その他,
        }

        // データ更新
        public void UpdateCarReport(DateTime date,
                         string auther,
                         MakerGroup Maker,
                         string name,
                         string report,
                         Image image) {
            this.ReportDate = date;
            this.ReportAuther = auther;
            this.maker = Maker;
            this.CarName = name;
            this.Report = report;
            this.Picture = image;
        }

    }

    

}
