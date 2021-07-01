using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Execise2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int result = 0;
            if (int.TryParse(inStrNum.Text, out result))
                Anser.Text = result.ToString("#,0");
            else
                Anser.Text = "変換文字列ではありません";
        }
    }
}
