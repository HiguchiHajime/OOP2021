using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            InputStr.Text = "Jackdaws love my big sphinx of quartz";
            NovelistStr.Text = "Born=1886;BestWork=春琴抄;Novelist=谷崎潤一郎";
        }

        private void Button5_3_1_Click(object sender, EventArgs e) {
            var target = InputStr.Text;
            textBoxSpaceCount.Text = target.Count(s => s.ToString() == " ").ToString();
        }

        private void Button5_3_2_Click(object sender, EventArgs e) {
            TextBoxWordChange.Text = InputStr.Text.Replace("big", "small");
        }

        private void Button5_3_3_Click(object sender, EventArgs e) {
            TextBoxWordCount.Text = InputStr.Text.Split(' ').Length.ToString();
        }

        private void Button5_3_4_Click(object sender, EventArgs e) {
            var target = InputStr.Text.Split(' ').Where(c => c.Length <= 4);
            foreach (var ta in target)
            TextBoxWordEnumerate.Text += " " + ta.Trim();
        }

        private void Button5_3_5_Click(object sender, EventArgs e) {
            var target = InputStr.Text.Split(' ').ToArray();
            if (target.Length > 0) {
                var sb = new StringBuilder(target[0]);
                foreach (var ta in target.Skip(1)) {
                    sb.Append(" ");
                    sb.Append(ta);
                }
                WordCreate.Text = sb.ToString();
            }
        }

        private void Output_Click(object sender, EventArgs e) {
            //var target = NovelistStr.Text.Split(';');
            //var NewWord = target.Select(s => s.Remove(0, s.IndexOf('=') +1 )).ToArray();
            //TextBoxOutPut.Text = $"作家　:" + NewWord[0].ToString() 
            //                     + "\r\n代表作:" + NewWord[1].ToString()
            //                     + "\r\n誕生年:" + NewWord[2].ToString();
            #region 模範解答
            //"Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886"
            foreach (var pair in NovelistStr.Text.Split(';')) {
                var array = pair.Split('=');
                TextBoxOutPut.Text += ToJapanese(array[0]) + ":" + array[1] + "\r\n";
            }
            #endregion

        }

        private string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数が正しくありません");
        }
    }
}
