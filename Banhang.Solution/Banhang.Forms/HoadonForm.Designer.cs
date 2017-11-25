namespace Banhang.Forms
{
    partial class HoadonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ghichuLabel;
            System.Windows.Forms.Label hoadonIdLabel;
            System.Windows.Forms.Label ngayHoadonLabel;
            System.Windows.Forms.Label nhanvienIdLabel;
            System.Windows.Forms.Label tongtienLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hanghoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanghoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ghichuTextBox = new System.Windows.Forms.TextBox();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoadonIdTextBox = new System.Windows.Forms.TextBox();
            this.ngayHoadonDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nhanvienIdComboBox = new System.Windows.Forms.ComboBox();
            this.tongtienTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cTHoadonDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTHoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            ghichuLabel = new System.Windows.Forms.Label();
            hoadonIdLabel = new System.Windows.Forms.Label();
            ngayHoadonLabel = new System.Windows.Forms.Label();
            nhanvienIdLabel = new System.Windows.Forms.Label();
            tongtienLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoadonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoadonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(314, 38);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(47, 13);
            ghichuLabel.TabIndex = 0;
            ghichuLabel.Text = "Ghi chú:";
            // 
            // hoadonIdLabel
            // 
            hoadonIdLabel.AutoSize = true;
            hoadonIdLabel.Location = new System.Drawing.Point(18, 35);
            hoadonIdLabel.Name = "hoadonIdLabel";
            hoadonIdLabel.Size = new System.Drawing.Size(44, 13);
            hoadonIdLabel.TabIndex = 2;
            hoadonIdLabel.Text = "Mã HĐ:";
            // 
            // ngayHoadonLabel
            // 
            ngayHoadonLabel.AutoSize = true;
            ngayHoadonLabel.Location = new System.Drawing.Point(18, 62);
            ngayHoadonLabel.Name = "ngayHoadonLabel";
            ngayHoadonLabel.Size = new System.Drawing.Size(53, 13);
            ngayHoadonLabel.TabIndex = 4;
            ngayHoadonLabel.Text = "Ngày tạo:";
            // 
            // nhanvienIdLabel
            // 
            nhanvienIdLabel.AutoSize = true;
            nhanvienIdLabel.Location = new System.Drawing.Point(18, 87);
            nhanvienIdLabel.Name = "nhanvienIdLabel";
            nhanvienIdLabel.Size = new System.Drawing.Size(59, 13);
            nhanvienIdLabel.TabIndex = 6;
            nhanvienIdLabel.Text = "Nhân viên:";
            // 
            // tongtienLabel
            // 
            tongtienLabel.AutoSize = true;
            tongtienLabel.Location = new System.Drawing.Point(18, 114);
            tongtienLabel.Name = "tongtienLabel";
            tongtienLabel.Size = new System.Drawing.Size(55, 13);
            tongtienLabel.TabIndex = 8;
            tongtienLabel.Text = "Tổng tiền:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hanghoaDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // hanghoaDataGridView
            // 
            this.hanghoaDataGridView.AutoGenerateColumns = false;
            this.hanghoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hanghoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7});
            this.hanghoaDataGridView.DataSource = this.hanghoaBindingSource;
            this.hanghoaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hanghoaDataGridView.Location = new System.Drawing.Point(3, 16);
            this.hanghoaDataGridView.Name = "hanghoaDataGridView";
            this.hanghoaDataGridView.Size = new System.Drawing.Size(359, 479);
            this.hanghoaDataGridView.TabIndex = 0;
            this.hanghoaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hanghoaDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HanghoaId";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenHanghoa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên hàng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GiaBan";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá bán";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NhomHanghoaId";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nhóm hàng";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // hanghoaBindingSource
            // 
            this.hanghoaBindingSource.DataSource = typeof(Banhang.Domain.HanghoaHandler.Hanghoa);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveButton);
            this.groupBox2.Controls.Add(ghichuLabel);
            this.groupBox2.Controls.Add(this.ghichuTextBox);
            this.groupBox2.Controls.Add(hoadonIdLabel);
            this.groupBox2.Controls.Add(this.hoadonIdTextBox);
            this.groupBox2.Controls.Add(ngayHoadonLabel);
            this.groupBox2.Controls.Add(this.ngayHoadonDateTimePicker);
            this.groupBox2.Controls.Add(nhanvienIdLabel);
            this.groupBox2.Controls.Add(this.nhanvienIdComboBox);
            this.groupBox2.Controls.Add(tongtienLabel);
            this.groupBox2.Controls.Add(this.tongtienTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(365, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // ghichuTextBox
            // 
            this.ghichuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoadonBindingSource, "Ghichu", true));
            this.ghichuTextBox.Location = new System.Drawing.Point(379, 35);
            this.ghichuTextBox.Multiline = true;
            this.ghichuTextBox.Name = "ghichuTextBox";
            this.ghichuTextBox.Size = new System.Drawing.Size(374, 96);
            this.ghichuTextBox.TabIndex = 1;
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataSource = typeof(Banhang.Domain.HanghoaHandler.Hoadon);
            // 
            // hoadonIdTextBox
            // 
            this.hoadonIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoadonBindingSource, "HoadonId", true));
            this.hoadonIdTextBox.Location = new System.Drawing.Point(83, 32);
            this.hoadonIdTextBox.Name = "hoadonIdTextBox";
            this.hoadonIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.hoadonIdTextBox.TabIndex = 3;
            // 
            // ngayHoadonDateTimePicker
            // 
            this.ngayHoadonDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.ngayHoadonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hoadonBindingSource, "NgayHoadon", true));
            this.ngayHoadonDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayHoadonDateTimePicker.Location = new System.Drawing.Point(83, 58);
            this.ngayHoadonDateTimePicker.Name = "ngayHoadonDateTimePicker";
            this.ngayHoadonDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngayHoadonDateTimePicker.TabIndex = 5;
            // 
            // nhanvienIdComboBox
            // 
            this.nhanvienIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoadonBindingSource, "NhanvienId", true));
            this.nhanvienIdComboBox.FormattingEnabled = true;
            this.nhanvienIdComboBox.Location = new System.Drawing.Point(83, 84);
            this.nhanvienIdComboBox.Name = "nhanvienIdComboBox";
            this.nhanvienIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.nhanvienIdComboBox.TabIndex = 7;
            // 
            // tongtienTextBox
            // 
            this.tongtienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoadonBindingSource, "Tongtien", true));
            this.tongtienTextBox.Location = new System.Drawing.Point(83, 111);
            this.tongtienTextBox.Name = "tongtienTextBox";
            this.tongtienTextBox.Size = new System.Drawing.Size(200, 20);
            this.tongtienTextBox.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cTHoadonDataGridView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(365, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 307);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // cTHoadonDataGridView
            // 
            this.cTHoadonDataGridView.AutoGenerateColumns = false;
            this.cTHoadonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cTHoadonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.cTHoadonDataGridView.DataSource = this.cTHoadonBindingSource;
            this.cTHoadonDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTHoadonDataGridView.Location = new System.Drawing.Point(3, 16);
            this.cTHoadonDataGridView.Name = "cTHoadonDataGridView";
            this.cTHoadonDataGridView.Size = new System.Drawing.Size(759, 288);
            this.cTHoadonDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CTHoadonId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã số";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HoadonId";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã HĐ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HanghoaId";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã hàng";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TenHanghoa";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tên hàng";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Soluong";
            this.dataGridViewTextBoxColumn9.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Dongia";
            this.dataGridViewTextBoxColumn10.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Ghichu";
            this.dataGridViewTextBoxColumn11.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // cTHoadonBindingSource
            // 
            this.cTHoadonBindingSource.DataSource = typeof(Banhang.Domain.HanghoaHandler.CTHoadon);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(678, 152);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BanhangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 498);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BanhangForm";
            this.Text = "BanhangForm";
            this.Load += new System.EventHandler(this.BanhangForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTHoadonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoadonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource hanghoaBindingSource;
        private System.Windows.Forms.DataGridView hanghoaDataGridView;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private System.Windows.Forms.TextBox ghichuTextBox;
        private System.Windows.Forms.TextBox hoadonIdTextBox;
        private System.Windows.Forms.DateTimePicker ngayHoadonDateTimePicker;
        private System.Windows.Forms.ComboBox nhanvienIdComboBox;
        private System.Windows.Forms.TextBox tongtienTextBox;
        private System.Windows.Forms.DataGridView cTHoadonDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource cTHoadonBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button SaveButton;
    }
}