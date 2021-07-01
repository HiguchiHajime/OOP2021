
namespace Exercise3 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputStr = new System.Windows.Forms.TextBox();
            this.Button5_3_1 = new System.Windows.Forms.Button();
            this.textBoxSpaceCount = new System.Windows.Forms.TextBox();
            this.TextBoxWordChange = new System.Windows.Forms.TextBox();
            this.Button5_3_2 = new System.Windows.Forms.Button();
            this.TextBoxWordCount = new System.Windows.Forms.TextBox();
            this.Button5_3_3 = new System.Windows.Forms.Button();
            this.TextBoxWordEnumerate = new System.Windows.Forms.TextBox();
            this.Button5_3_4 = new System.Windows.Forms.Button();
            this.WordCreate = new System.Windows.Forms.TextBox();
            this.Button5_3_5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NovelistStr = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Button();
            this.TextBoxOutPut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.3";
            // 
            // InputStr
            // 
            this.InputStr.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InputStr.Location = new System.Drawing.Point(17, 39);
            this.InputStr.Name = "InputStr";
            this.InputStr.Size = new System.Drawing.Size(681, 31);
            this.InputStr.TabIndex = 1;
            // 
            // Button5_3_1
            // 
            this.Button5_3_1.AutoSize = true;
            this.Button5_3_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5_3_1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_1.Location = new System.Drawing.Point(17, 76);
            this.Button5_3_1.Name = "Button5_3_1";
            this.Button5_3_1.Size = new System.Drawing.Size(158, 36);
            this.Button5_3_1.TabIndex = 2;
            this.Button5_3_1.Text = "空白をカウント";
            this.Button5_3_1.UseVisualStyleBackColor = true;
            this.Button5_3_1.Click += new System.EventHandler(this.Button5_3_1_Click);
            // 
            // textBoxSpaceCount
            // 
            this.textBoxSpaceCount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSpaceCount.Location = new System.Drawing.Point(307, 79);
            this.textBoxSpaceCount.Name = "textBoxSpaceCount";
            this.textBoxSpaceCount.Size = new System.Drawing.Size(106, 31);
            this.textBoxSpaceCount.TabIndex = 3;
            // 
            // TextBoxWordChange
            // 
            this.TextBoxWordChange.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordChange.Location = new System.Drawing.Point(307, 121);
            this.TextBoxWordChange.Name = "TextBoxWordChange";
            this.TextBoxWordChange.Size = new System.Drawing.Size(507, 31);
            this.TextBoxWordChange.TabIndex = 5;
            // 
            // Button5_3_2
            // 
            this.Button5_3_2.AutoSize = true;
            this.Button5_3_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5_3_2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_2.Location = new System.Drawing.Point(17, 118);
            this.Button5_3_2.Name = "Button5_3_2";
            this.Button5_3_2.Size = new System.Drawing.Size(162, 36);
            this.Button5_3_2.TabIndex = 4;
            this.Button5_3_2.Text = "big　→　small";
            this.Button5_3_2.UseVisualStyleBackColor = true;
            this.Button5_3_2.Click += new System.EventHandler(this.Button5_3_2_Click);
            // 
            // TextBoxWordCount
            // 
            this.TextBoxWordCount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordCount.Location = new System.Drawing.Point(307, 165);
            this.TextBoxWordCount.Name = "TextBoxWordCount";
            this.TextBoxWordCount.Size = new System.Drawing.Size(106, 31);
            this.TextBoxWordCount.TabIndex = 7;
            // 
            // Button5_3_3
            // 
            this.Button5_3_3.AutoSize = true;
            this.Button5_3_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5_3_3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_3.Location = new System.Drawing.Point(17, 160);
            this.Button5_3_3.Name = "Button5_3_3";
            this.Button5_3_3.Size = new System.Drawing.Size(160, 36);
            this.Button5_3_3.TabIndex = 6;
            this.Button5_3_3.Text = "単語をカウント";
            this.Button5_3_3.UseVisualStyleBackColor = true;
            this.Button5_3_3.Click += new System.EventHandler(this.Button5_3_3_Click);
            // 
            // TextBoxWordEnumerate
            // 
            this.TextBoxWordEnumerate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordEnumerate.Location = new System.Drawing.Point(307, 207);
            this.TextBoxWordEnumerate.Name = "TextBoxWordEnumerate";
            this.TextBoxWordEnumerate.Size = new System.Drawing.Size(507, 31);
            this.TextBoxWordEnumerate.TabIndex = 9;
            // 
            // Button5_3_4
            // 
            this.Button5_3_4.AutoSize = true;
            this.Button5_3_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5_3_4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_4.Location = new System.Drawing.Point(17, 202);
            this.Button5_3_4.Name = "Button5_3_4";
            this.Button5_3_4.Size = new System.Drawing.Size(264, 36);
            this.Button5_3_4.TabIndex = 8;
            this.Button5_3_4.Text = "4文字以下の単語を列挙";
            this.Button5_3_4.UseVisualStyleBackColor = true;
            this.Button5_3_4.Click += new System.EventHandler(this.Button5_3_4_Click);
            // 
            // WordCreate
            // 
            this.WordCreate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WordCreate.Location = new System.Drawing.Point(307, 256);
            this.WordCreate.Name = "WordCreate";
            this.WordCreate.Size = new System.Drawing.Size(507, 31);
            this.WordCreate.TabIndex = 11;
            // 
            // Button5_3_5
            // 
            this.Button5_3_5.AutoSize = true;
            this.Button5_3_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5_3_5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_5.Location = new System.Drawing.Point(17, 251);
            this.Button5_3_5.Name = "Button5_3_5";
            this.Button5_3_5.Size = new System.Drawing.Size(259, 36);
            this.Button5_3_5.TabIndex = 10;
            this.Button5_3_5.Text = "同じ配列を作る";
            this.Button5_3_5.UseVisualStyleBackColor = true;
            this.Button5_3_5.Click += new System.EventHandler(this.Button5_3_5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "問題5.4";
            // 
            // NovelistStr
            // 
            this.NovelistStr.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NovelistStr.Location = new System.Drawing.Point(17, 333);
            this.NovelistStr.Name = "NovelistStr";
            this.NovelistStr.Size = new System.Drawing.Size(681, 31);
            this.NovelistStr.TabIndex = 13;
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Output.Location = new System.Drawing.Point(17, 380);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(100, 40);
            this.Output.TabIndex = 14;
            this.Output.Text = "出力";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // TextBoxOutPut
            // 
            this.TextBoxOutPut.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxOutPut.Location = new System.Drawing.Point(133, 385);
            this.TextBoxOutPut.Multiline = true;
            this.TextBoxOutPut.Name = "TextBoxOutPut";
            this.TextBoxOutPut.Size = new System.Drawing.Size(681, 139);
            this.TextBoxOutPut.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 637);
            this.Controls.Add(this.TextBoxOutPut);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.NovelistStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WordCreate);
            this.Controls.Add(this.Button5_3_5);
            this.Controls.Add(this.TextBoxWordEnumerate);
            this.Controls.Add(this.Button5_3_4);
            this.Controls.Add(this.TextBoxWordCount);
            this.Controls.Add(this.Button5_3_3);
            this.Controls.Add(this.TextBoxWordChange);
            this.Controls.Add(this.Button5_3_2);
            this.Controls.Add(this.textBoxSpaceCount);
            this.Controls.Add(this.Button5_3_1);
            this.Controls.Add(this.InputStr);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputStr;
        private System.Windows.Forms.Button Button5_3_1;
        private System.Windows.Forms.TextBox textBoxSpaceCount;
        private System.Windows.Forms.TextBox TextBoxWordChange;
        private System.Windows.Forms.Button Button5_3_2;
        private System.Windows.Forms.TextBox TextBoxWordCount;
        private System.Windows.Forms.Button Button5_3_3;
        private System.Windows.Forms.TextBox TextBoxWordEnumerate;
        private System.Windows.Forms.Button Button5_3_4;
        private System.Windows.Forms.TextBox WordCreate;
        private System.Windows.Forms.Button Button5_3_5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NovelistStr;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.TextBox TextBoxOutPut;
    }
}

