
namespace StopWatch {
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
            this.components = new System.ComponentModel.Container();
            this.btstart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btrap = new System.Windows.Forms.Button();
            this.btstop = new System.Windows.Forms.Button();
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.tmDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btstart
            // 
            this.btstart.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btstart.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btstart.Location = new System.Drawing.Point(100, 189);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(174, 49);
            this.btstart.TabIndex = 0;
            this.btstart.Text = "スタート";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.button2.Location = new System.Drawing.Point(321, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 49);
            this.button2.TabIndex = 0;
            this.button2.Text = "リセット";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btrap
            // 
            this.btrap.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btrap.Location = new System.Drawing.Point(321, 296);
            this.btrap.Name = "btrap";
            this.btrap.Size = new System.Drawing.Size(174, 49);
            this.btrap.TabIndex = 0;
            this.btrap.Text = "ラップ";
            this.btrap.UseVisualStyleBackColor = true;
            this.btrap.Click += new System.EventHandler(this.btrap_Click);
            // 
            // btstop
            // 
            this.btstop.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btstop.Location = new System.Drawing.Point(100, 296);
            this.btstop.Name = "btstop";
            this.btstop.Size = new System.Drawing.Size(174, 49);
            this.btstop.TabIndex = 0;
            this.btstop.Text = "ストップ";
            this.btstop.UseVisualStyleBackColor = true;
            this.btstop.Click += new System.EventHandler(this.btstop_Click);
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.Location = new System.Drawing.Point(96, 73);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(449, 88);
            this.lbTimerDisp.TabIndex = 1;
            // 
            // tmDisp
            // 
            this.tmDisp.Interval = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTimerDisp);
            this.Controls.Add(this.btrap);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btstop);
            this.Controls.Add(this.btstart);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "タイマー";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btrap;
        private System.Windows.Forms.Button btstop;
        private System.Windows.Forms.Label lbTimerDisp;
        private System.Windows.Forms.Timer tmDisp;
    }
}

