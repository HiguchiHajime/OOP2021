
namespace Exercise1 {
    partial class Form1 {
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
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.btAllOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "ofdOpenFile";
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.tbOutput.Location = new System.Drawing.Point(52, 72);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(668, 350);
            this.tbOutput.TabIndex = 0;
            // 
            // btOpen
            // 
            this.btOpen.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btOpen.Location = new System.Drawing.Point(52, 5);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(201, 51);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(277, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "キーワード";
            // 
            // tbKeyword
            // 
            this.tbKeyword.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.tbKeyword.Location = new System.Drawing.Point(280, 33);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(146, 23);
            this.tbKeyword.TabIndex = 3;
            // 
            // btAllOpen
            // 
            this.btAllOpen.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btAllOpen.Location = new System.Drawing.Point(455, 5);
            this.btAllOpen.Name = "btAllOpen";
            this.btAllOpen.Size = new System.Drawing.Size(201, 51);
            this.btAllOpen.TabIndex = 1;
            this.btAllOpen.Text = "Exercise9.1-2";
            this.btAllOpen.UseVisualStyleBackColor = true;
            this.btAllOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAllOpen);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Button btAllOpen;
    }
}

