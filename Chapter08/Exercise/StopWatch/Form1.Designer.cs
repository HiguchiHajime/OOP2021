
using System;

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
            this.btreset = new System.Windows.Forms.Button();
            this.btrap = new System.Windows.Forms.Button();
            this.btstop = new System.Windows.Forms.Button();
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.tmDisp = new System.Windows.Forms.Timer(this.components);
            this.lbrapDisp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btstart
            // 
            this.btstart.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btstart.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btstart.Location = new System.Drawing.Point(57, 120);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(200, 92);
            this.btstart.TabIndex = 0;
            this.btstart.Text = "スタート";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // btreset
            // 
            this.btreset.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btreset.Location = new System.Drawing.Point(293, 120);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(185, 92);
            this.btreset.TabIndex = 0;
            this.btreset.Text = "リセット";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btrap
            // 
            this.btrap.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btrap.Location = new System.Drawing.Point(293, 244);
            this.btrap.Name = "btrap";
            this.btrap.Size = new System.Drawing.Size(185, 101);
            this.btrap.TabIndex = 0;
            this.btrap.Text = "ラップ";
            this.btrap.UseVisualStyleBackColor = true;
            this.btrap.Click += new System.EventHandler(this.btrap_Click);
            // 
            // btstop
            // 
            this.btstop.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btstop.Location = new System.Drawing.Point(57, 244);
            this.btstop.Name = "btstop";
            this.btstop.Size = new System.Drawing.Size(200, 101);
            this.btstop.TabIndex = 0;
            this.btstop.Text = "ストップ";
            this.btstop.UseVisualStyleBackColor = true;
            this.btstop.Click += new System.EventHandler(this.btstop_Click);
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.Location = new System.Drawing.Point(56, 12);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(422, 88);
            this.lbTimerDisp.TabIndex = 1;
            // 
            // tmDisp
            // 
            this.tmDisp.Interval = 1;
            // 
            // lbrapDisp
            // 
            this.lbrapDisp.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lbrapDisp.FormattingEnabled = true;
            this.lbrapDisp.ItemHeight = 24;
            this.lbrapDisp.Location = new System.Drawing.Point(507, 12);
            this.lbrapDisp.Name = "lbrapDisp";
            this.lbrapDisp.Size = new System.Drawing.Size(272, 340);
            this.lbrapDisp.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(791, 381);
            this.Controls.Add(this.lbrapDisp);
            this.Controls.Add(this.lbTimerDisp);
            this.Controls.Add(this.btrap);
            this.Controls.Add(this.btreset);
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
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btrap;
        private System.Windows.Forms.Button btstop;
        private System.Windows.Forms.Label lbTimerDisp;
        private System.Windows.Forms.Timer tmDisp;
        private System.Windows.Forms.ListBox lbrapDisp;
    }
}

