using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Exec_Click(object sender, EventArgs e) {
            //int num = int.Parse(Value.Text);
            //for(int i = 2; i<= int.Parse(Jyou.Text); i++) {
            //    num *= int.Parse(Value.Text);
            //}
            //Result.Text = num.ToString();

            Result.Text = Math.Pow(int.Parse(Value.Text), int.Parse(Jyou.Text)).ToString();

        }
    }
}
