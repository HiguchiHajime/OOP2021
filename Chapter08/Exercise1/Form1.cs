using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            var today = new DateTime((int)nubyear.Value,(int)nubmonth.Value,(int)nubday.Value);
            DayOfWeek dayOfWeek = today.DayOfWeek;
            string dow = "";
            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;
            }

                tbOutput.Text = dow + "です";
            TimeSpan diff = DateTime.Today - today;
            tb.Text = "現在との差は" +diff.Days +"日間です";


            if (DateTime.IsLeapYear(today.Year))
                tbOutput.Text = "うるう年です";
            else
                tbOutput.Text = "うるう年ではありません";
    
            var age = GetAge(Dtpbarth.Value, DateTime.Today);

            tbAge.Text = "あなたは" + age + "歳です";
            //tbOutput.Text = DateTime.Today.DayOfYear.ToString();
        }

        public static int GetAge(DateTime birthday,DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if(targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
        
    }
}
