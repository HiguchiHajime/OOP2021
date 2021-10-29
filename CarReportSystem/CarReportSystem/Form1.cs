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
     

        // メーカーを返す
        private CarReport.MakerGroup SelectedGroup() {
            foreach(var rb in gpMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
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
        // 更新イベント処理
        private void btUpdate_Click(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) return;
                carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;    // 日付
                carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;    // 記録者
                carReportDataGridView.CurrentRow.Cells[3].Value = SelectedGroup();  // メーカー
                carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;   // 車名
                carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;    // レポート
                carReportDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);  // 画像
                                                                                
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
            bindingNavigatorAddNewItem.Enabled = true;

            foreach(var info in this.infosys202135DataSet.CarReport) {
                setCbAuthor(info.Author);
                setCbCarName(info.CarName);
            }


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
            bindingNavigatorAddNewItem.Enabled = false;
            carReportDataGridView.Columns[0].Visible = false;
            carReportDataGridView.Columns[1].HeaderText = "日付";
            carReportDataGridView.Columns[2].HeaderText = "記録者";
            carReportDataGridView.Columns[3].HeaderText = "メーカー";
            carReportDataGridView.Columns[4].HeaderText = "車名";
            carReportDataGridView.Columns[5].HeaderText = "レポート";
            carReportDataGridView.Columns[6].Visible = false;
        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) return;
            try {
                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;                            // 日付
                cbAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();                           // 記録者
                SetMakerRadioButton((CarReport.MakerGroup)
                                    Enum.Parse(typeof(CarReport.MakerGroup), 
                                    carReportDataGridView.CurrentRow.Cells[3].Value.ToString()));                     // メーカー(文字列から列挙型に変換)
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();                          // 車名
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();                           // レポート
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);                           // 画像

            }
            catch (Exception) { 
                pbPicture.Image = null;
            }
            
           
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }
        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            cbCarName.Text = string.Empty;
            SetMakerRadioButton(CarReport.MakerGroup.その他);
            tbReport.Text = string.Empty;
            pbPicture.Image = null;
        }


        //コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if (string.IsNullOrEmpty(author)) return;
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carName) {
            if (string.IsNullOrEmpty(carName)) return;
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }
        }

    }
}