using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        private int Anser;
        Stopwatch sw = new Stopwatch();

        public MainWindow() {
            InitializeComponent();
           
        }


        private void Button_Click(object sender, RoutedEventArgs e) {
            sw.Start();
           int num = int.Parse(((Button)sender).Content.ToString());
            if (Anser > num) {
                this.NumberText.Text = "選択した値は答えの数字よりも大きいです";
                this.GameTimer.Text = sw.Elapsed.ToString();
            }
            else if (Anser < num) {
                this.NumberText.Text = "選択した値は答えの数字よりも小さいです";
                this.GameTimer.Text = sw.Elapsed.ToString();
            }
            else {
                this.NumberText.Text = "ゲームクリア";
                sw.Stop();
                this.GameTimer.Text = sw.Elapsed.ToString();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            Random num =  new Random();
            Anser = num.Next(1,25);
        }
    }
}
