
namespace AddressBook {
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
            this.personDataGridView = new System.Windows.Forms.DataGridView();
            this.btConnect = new System.Windows.Forms.Button();
            this.btNameFilter = new System.Windows.Forms.Button();
            this.tbNameSearch = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202135DataSet = new AddressBook.infosys202135DataSet();
            this.personTableAdapter = new AddressBook.infosys202135DataSetTableAdapters.PersonTableAdapter();
            this.tableAdapterManager = new AddressBook.infosys202135DataSetTableAdapters.TableAdapterManager();
            this.dtBirthday_Search = new System.Windows.Forms.DateTimePicker();
            this.btBirthday_Filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202135DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // personDataGridView
            // 
            this.personDataGridView.AllowUserToAddRows = false;
            this.personDataGridView.AutoGenerateColumns = false;
            this.personDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.personDataGridView.DataSource = this.personBindingSource;
            this.personDataGridView.Location = new System.Drawing.Point(12, 199);
            this.personDataGridView.MultiSelect = false;
            this.personDataGridView.Name = "personDataGridView";
            this.personDataGridView.ReadOnly = true;
            this.personDataGridView.RowTemplate.Height = 21;
            this.personDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personDataGridView.Size = new System.Drawing.Size(784, 156);
            this.personDataGridView.TabIndex = 1;
            this.personDataGridView.SelectionChanged += new System.EventHandler(this.personDataGridView_SelectionChanged);
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btConnect.Location = new System.Drawing.Point(12, 371);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(111, 45);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "接続";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btNameFilter
            // 
            this.btNameFilter.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNameFilter.Location = new System.Drawing.Point(501, 409);
            this.btNameFilter.Name = "btNameFilter";
            this.btNameFilter.Size = new System.Drawing.Size(114, 31);
            this.btNameFilter.TabIndex = 3;
            this.btNameFilter.Text = "名前抽出";
            this.btNameFilter.UseVisualStyleBackColor = true;
            this.btNameFilter.Click += new System.EventHandler(this.btNameFilter_Click);
            // 
            // tbNameSearch
            // 
            this.tbNameSearch.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.tbNameSearch.Location = new System.Drawing.Point(287, 409);
            this.tbNameSearch.Name = "tbNameSearch";
            this.tbNameSearch.Size = new System.Drawing.Size(189, 29);
            this.tbNameSearch.TabIndex = 4;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSave.Location = new System.Drawing.Point(139, 371);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(111, 45);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "誕生日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(18, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "電話番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(344, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "備考";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.tbName.Location = new System.Drawing.Point(98, 43);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(202, 23);
            this.tbName.TabIndex = 7;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.tbTelephone.Location = new System.Drawing.Point(98, 127);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(202, 23);
            this.tbTelephone.TabIndex = 7;
            // 
            // tbMemo
            // 
            this.tbMemo.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.tbMemo.Location = new System.Drawing.Point(346, 43);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(243, 122);
            this.tbMemo.TabIndex = 7;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.dtBirthday.Location = new System.Drawing.Point(98, 86);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(200, 23);
            this.dtBirthday.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn3.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Memo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Memo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.infosys202135DataSet;
            // 
            // infosys202135DataSet
            // 
            this.infosys202135DataSet.DataSetName = "infosys202135DataSet";
            this.infosys202135DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonTableAdapter = this.personTableAdapter;
            this.tableAdapterManager.UpdateOrder = AddressBook.infosys202135DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dtBirthday_Search
            // 
            this.dtBirthday_Search.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.dtBirthday_Search.Location = new System.Drawing.Point(287, 371);
            this.dtBirthday_Search.Name = "dtBirthday_Search";
            this.dtBirthday_Search.Size = new System.Drawing.Size(189, 23);
            this.dtBirthday_Search.TabIndex = 9;
            // 
            // btBirthday_Filter
            // 
            this.btBirthday_Filter.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBirthday_Filter.Location = new System.Drawing.Point(501, 371);
            this.btBirthday_Filter.Name = "btBirthday_Filter";
            this.btBirthday_Filter.Size = new System.Drawing.Size(149, 31);
            this.btBirthday_Filter.TabIndex = 3;
            this.btBirthday_Filter.Text = "誕生日抽出";
            this.btBirthday_Filter.UseVisualStyleBackColor = true;
            this.btBirthday_Filter.Click += new System.EventHandler(this.btBirthday_Filter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.dtBirthday_Search);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbNameSearch);
            this.Controls.Add(this.btBirthday_Filter);
            this.Controls.Add(this.btNameFilter);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.personDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202135DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private infosys202135DataSet infosys202135DataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private infosys202135DataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private infosys202135DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView personDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btNameFilter;
        private System.Windows.Forms.TextBox tbNameSearch;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.DateTimePicker dtBirthday_Search;
        private System.Windows.Forms.Button btBirthday_Filter;
    }
}

