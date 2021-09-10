
namespace RssReader {
    partial class Form31063 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.btRead = new System.Windows.Forms.Button();
            this.btWebbro = new System.Windows.Forms.Button();
            this.tbDes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(221, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(631, 30);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/top-picks.xml";
            // 
            // lbTitles
            // 
            this.lbTitles.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.ItemHeight = 18;
            this.lbTitles.Location = new System.Drawing.Point(17, 79);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(313, 544);
            this.lbTitles.TabIndex = 2;
            this.lbTitles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTitles_MouseDoubleClick);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(904, 5);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(103, 48);
            this.btRead.TabIndex = 4;
            this.btRead.Text = "読み込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btWebbro
            // 
            this.btWebbro.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWebbro.Location = new System.Drawing.Point(787, 249);
            this.btWebbro.Name = "btWebbro";
            this.btWebbro.Size = new System.Drawing.Size(271, 66);
            this.btWebbro.TabIndex = 6;
            this.btWebbro.Text = "ブラウザ表示";
            this.btWebbro.UseVisualStyleBackColor = true;
            this.btWebbro.Click += new System.EventHandler(this.btWebbro_Click);
            // 
            // tbDes
            // 
            this.tbDes.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDes.Location = new System.Drawing.Point(359, 79);
            this.tbDes.Multiline = true;
            this.tbDes.Name = "tbDes";
            this.tbDes.Size = new System.Drawing.Size(798, 99);
            this.tbDes.TabIndex = 7;
            // 
            // Form31063
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 677);
            this.Controls.Add(this.tbDes);
            this.Controls.Add(this.btWebbro);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form31063";
            this.Text = "31063";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btWebbro;
        private System.Windows.Forms.TextBox tbDes;
    }
}

