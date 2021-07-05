using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Execise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btToday_Click_Click(object sender, EventArgs e) {
            var today = DateTime.Now;

            tbDateDisp.Text = string.Format("{0:yyyy/M/d HH:mm}",today) + "\r\n";
            tbDateDisp.Text += today.ToString("yyyy年MM月dd日 HH字mm分ss秒") + "\r\n";
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            tbDateDisp.Text += today.ToString("ggyy年 M月dd日(dddd)",culture);

            //tbDateDisp.Text = today.ToString("d");
        }

        private void Form1_Load(object sender, EventArgs e) {

            var Timer = new Timer();

            var Now = DateTime.Now;

            Timer.Tick += Timer_Tick;
            Timer.Interval = 1000; 
            tssTimeLabel.Text = DateTime.Now.ToString();
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) {
            var Now = DateTime.Now;
            tssTimeLabel.Text = DateTime.Now.ToString();

        }
    }
}
