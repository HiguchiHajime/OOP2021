using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain() {
            InitializeComponent();
            //dgvRegistData.DataSource = listCarReport;
        }

        // 終了ボタン
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        // 画像を開く
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if(ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        
        // 画像削除
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
        // 追加ボタン
        private void btDataAdd_Click(object sender, EventArgs e) {

            if (cbAuthor.Text == "" || cbCarName.Text == "" || tbReport.Text == "") {
                MessageBox.Show("エラー", "すべての項目を入力してください",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            CarReport carReport = new CarReport
            {
                ReportDate = dtpDate.Value,
                ReportAuther = cbAuthor.Text,
                maker = SelectedGroup(),
                CarName = cbCarName.Text.ToString(),
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            setCbAuther(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
            listCarReport.Add(carReport);           // 1レコード追加
        }

        // メーカーを返す
        private CarReport.MakerGroup SelectedGroup() {
            foreach(var rb in gpMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }


        // コンボボックスに記録者をセットする
        private void setCbAuther(string author) {
            if(!cbAuthor.Items.Contains(author) ) {
               cbAuthor.Items.Add(author);
            }
            
        }

        // コンボボックスに社名をセットする
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }

        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;
            // 選択された行のデータを取得
            CarReport selectedCar = listCarReport[e.RowIndex];

            // 取得したデータ項目を各コントロールへ設定
            dtpDate.Value = selectedCar.ReportDate;
            cbAuthor.Text = selectedCar.ReportAuther;
            SetMakerRadioButton(selectedCar.maker);
            //foreach (RadioButton rb in gpMaker.Controls) {
            //    if ((CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag)) == selectedCar.maker) {
            //        rb.Checked = true;
            //        break;
            //    }
            //}

            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
        }

        private void SetMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbImport.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }

        // 削除ボタン
        private void btDataDelete_Click(object sender, EventArgs e) {
            //if (listCarReport.Count <= 0)
            //    return;
            //try {
            //    listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);
            //}
            //catch(System.NullReferenceException ex) {
            //    MessageBox.Show(ex.Message);
            //}
            
        }

        // 修正ボタン
        private void btDataCorrect_Click(object sender, EventArgs e) {
            //try {
            //    listCarReport[dgvRegistData.CurrentRow.Index].UpdateCarReport(
            //        dtpDate.Value,
            //        cbAuthor.Text,
            //        SelectedGroup(),
            //        cbCarName.Text.ToString(),
            //        tbReport.Text,
            //        pbPicture.Image);
            //    dgvRegistData.Refresh();          // コントロールの強制再描画
            //}            
            //catch (System.NullReferenceException ex) {
            //    MessageBox.Show(ex.Message);
            //}
        }
        // 更新イベント処理
        private void btUpdate_Click(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) return;
                carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;    // 日付
                carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;    // 記録者
                carReportDataGridView.CurrentRow.Cells[3].Value = SelectedGroup();  // メーカー
                carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;   // 車名
                carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;    // レポート
                // データベースへ反映
                this.Validate();
                this.carReportBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.infosys202135DataSet);
#if false
            if(sfdFileSave.ShowDialog() == DialogResult.OK) {
                // バイナリ形式でファイル化
                var bf = new BinaryFormatter();

                using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create)) {
                    bf.Serialize(fs, listCarReport);
                }
#endif
        }

        private void btConnect_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202135DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202135DataSet.CarReport);
#if false
            if(ofdFileopen.ShowDialog() == DialogResult.OK) {
                try {
                    // バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileopen.FileName, FileMode.Open, FileAccess.Read)) {
                        // 逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRegistData.DataSource = null;
                        dgvRegistData.DataSource = listCarReport;
                    }
                }
                catch (System.Runtime.Serialization.SerializationException ex) {
                    MessageBox.Show(ex.Message);
                }
                //読み込んだデータを各コンボボックスに登録する
                foreach (var info in listCarReport) {
                    setCbAuther(info.ReportAuther);
                    setCbCarName(info.CarName);
                }
                //// dgvから取り出す
                //for(int i = 0; i<dgvRegistData.RowCount; i++) {
                //    setCbAuther(dgvRegistData.Rows[i].Cells[1].Value.ToString());
                //    setCbCarName(dgvRegistData.Rows[i].Cells[3].Value.ToString());
                //}
            }
#endif
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202135DataSet);

        }

        private void fmMain_Load(object sender, EventArgs e) {
           //dgvRegistData.Columns[5].Visible = false;
        }
    }
}
