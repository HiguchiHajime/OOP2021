
namespace WeatherApp {
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
            this.cbCityName = new System.Windows.Forms.ComboBox();
            this.Weather = new System.Windows.Forms.TextBox();
            this.btWeatherReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "地域";
            // 
            // cbCityName
            // 
            this.cbCityName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.cbCityName.FormattingEnabled = true;
            this.cbCityName.Location = new System.Drawing.Point(135, 43);
            this.cbCityName.Name = "cbCityName";
            this.cbCityName.Size = new System.Drawing.Size(170, 38);
            this.cbCityName.TabIndex = 1;
            // 
            // Weather
            // 
            this.Weather.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Weather.Location = new System.Drawing.Point(47, 90);
            this.Weather.Multiline = true;
            this.Weather.Name = "Weather";
            this.Weather.Size = new System.Drawing.Size(721, 314);
            this.Weather.TabIndex = 2;
            // 
            // btWeatherReport
            // 
            this.btWeatherReport.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btWeatherReport.Location = new System.Drawing.Point(370, 35);
            this.btWeatherReport.Name = "btWeatherReport";
            this.btWeatherReport.Size = new System.Drawing.Size(156, 49);
            this.btWeatherReport.TabIndex = 3;
            this.btWeatherReport.Text = "実行";
            this.btWeatherReport.UseVisualStyleBackColor = true;
            this.btWeatherReport.Click += new System.EventHandler(this.btWeatherReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btWeatherReport);
            this.Controls.Add(this.Weather);
            this.Controls.Add(this.cbCityName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCityName;
        private System.Windows.Forms.TextBox Weather;
        private System.Windows.Forms.Button btWeatherReport;
    }
}

