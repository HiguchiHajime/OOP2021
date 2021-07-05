using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {
        // 時間計測
        Stopwatch sw = new Stopwatch();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            tmDisp.Tick += TmDisp_Tick;
            tmDisp.Start();
        }

        private void TmDisp_Tick(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void btstart_Click(object sender, EventArgs e) {
            sw.Start();
        }

        private void btstop_Click(object sender, EventArgs e) {
            sw.Stop();
        }

        private void button2_Click(object sender, EventArgs e) {
            sw.Reset();
        }

        //private void btrap_Click(object sender, EventArgs e) {
        //    sw.Elapsed.ToString();
        //}
    }
}
