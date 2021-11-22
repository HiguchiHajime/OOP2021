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
using System.Windows.Threading;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        private int Anser;
        Stopwatch sw = new Stopwatch();
        private int Row = 5;
        private int Column = 5;

        public MainWindow() {
            InitializeComponent();
            
        }

        private void Create_Button(int row , int column) {
            for (int j = 0; j < column; j++) {
                this.NumGame.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < row+1; i++) {
                this.NumGame.RowDefinitions.Add(new RowDefinition());
               
            }

            

            var count = 1;

            for (int k = 0; k < column; k++) {
                for (int i = 0; i < row; i++) {
                    Button NButton = new Button();
                    NButton.SetValue(Grid.ColumnProperty, i);
                    NButton.SetValue(Grid.RowProperty, k);
                    NButton.Content = count;
                    NButton.Click += Button_Click;
                    this.NumGame.Children.Add(NButton);
                    ++count;
                }
            }

            this.NumberText.SetValue(Grid.RowProperty,Row);

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            sw.Start();
            // タイマのインスタンスを生成
            var timer = new DispatcherTimer(DispatcherPriority.Normal)
            {
                // インターバルを設定
                Interval = TimeSpan.FromSeconds(0.1),
                
            };
            timer.Tick += Timer_Tick;
            timer.Start();
            int num = int.Parse(((Button)sender).Content.ToString());
            if (Anser > num) {
                this.NumberText.Text = "選択した値は答えの数字よりも大きいです";
            }
            else if (Anser < num) {
                this.NumberText.Text = "選択した値は答えの数字よりも小さいです";

            }
            else {
                this.NumberText.Text = "ゲームクリア";
                sw.Stop();

            }
        }

        private void Timer_Tick(object sender, EventArgs e) {
            this.GameTimer.Text = sw.Elapsed.ToString(@"mm\:ss\.ff");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            Random num =  new Random();
            Create_Button(Row, Column);
            Anser = num.Next(1,Row*Column);
        }
    }
}
