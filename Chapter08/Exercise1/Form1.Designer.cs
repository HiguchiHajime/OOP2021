
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btAction = new System.Windows.Forms.Button();
            this.nubyear = new System.Windows.Forms.NumericUpDown();
            this.nubmonth = new System.Windows.Forms.NumericUpDown();
            this.nubday = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Dtpbarth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nubyear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubmonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubday)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOutput.Location = new System.Drawing.Point(39, 196);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(309, 31);
            this.tbOutput.TabIndex = 0;
            // 
            // btAction
            // 
            this.btAction.Location = new System.Drawing.Point(384, 255);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(98, 32);
            this.btAction.TabIndex = 1;
            this.btAction.Text = "実行";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.btAction_Click);
            // 
            // nubyear
            // 
            this.nubyear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nubyear.Location = new System.Drawing.Point(39, 74);
            this.nubyear.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.nubyear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nubyear.Name = "nubyear";
            this.nubyear.Size = new System.Drawing.Size(120, 31);
            this.nubyear.TabIndex = 2;
            this.nubyear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nubmonth
            // 
            this.nubmonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nubmonth.Location = new System.Drawing.Point(216, 75);
            this.nubmonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nubmonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nubmonth.Name = "nubmonth";
            this.nubmonth.Size = new System.Drawing.Size(120, 31);
            this.nubmonth.TabIndex = 2;
            this.nubmonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nubday
            // 
            this.nubday.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nubday.Location = new System.Drawing.Point(401, 74);
            this.nubday.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nubday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nubday.Name = "nubday";
            this.nubday.Size = new System.Drawing.Size(133, 31);
            this.nubday.TabIndex = 2;
            this.nubday.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(165, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(342, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label3.Location = new System.Drawing.Point(540, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "日";
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb.Location = new System.Drawing.Point(39, 256);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(309, 31);
            this.tb.TabIndex = 0;
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAge.Location = new System.Drawing.Point(39, 308);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(309, 31);
            this.tbAge.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label6.Location = new System.Drawing.Point(35, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "誕生日";
            // 
            // Dtpbarth
            // 
            this.Dtpbarth.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.Dtpbarth.Location = new System.Drawing.Point(39, 135);
            this.Dtpbarth.Name = "Dtpbarth";
            this.Dtpbarth.Size = new System.Drawing.Size(183, 31);
            this.Dtpbarth.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dtpbarth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nubday);
            this.Controls.Add(this.nubmonth);
            this.Controls.Add(this.nubyear);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nubyear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubmonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.NumericUpDown nubyear;
        private System.Windows.Forms.NumericUpDown nubmonth;
        private System.Windows.Forms.NumericUpDown nubday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Dtpbarth;
    }
}

