namespace Banhang.Forms
{
    partial class HanghoaForm
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
            System.Windows.Forms.Label giaBanLabel;
            System.Windows.Forms.Label hanghoaIdLabel;
            System.Windows.Forms.Label motaLabel;
            System.Windows.Forms.Label soLuongTonKhoLabel;
            System.Windows.Forms.Label tenHanghoaLabel;
            System.Windows.Forms.Label nhomHanghoaIdLabel;
            this.NhomGroupBox = new System.Windows.Forms.GroupBox();
            this.nhomHanghoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomHanghoaBindingSource = new System.Windows.Forms.BindingSource();
            this.NhomChucnangGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoaDataButton = new System.Windows.Forms.Button();
            this.DetailGroupBox = new System.Windows.Forms.GroupBox();
            this.NhomHanghoaComboBox = new System.Windows.Forms.ComboBox();
            this.hanghoaBindingSource = new System.Windows.Forms.BindingSource();
            this.bindingSource1 = new System.Windows.Forms.BindingSource();
            this.HanghoaDeleteButton = new System.Windows.Forms.Button();
            this.HanghoaSaveButton = new System.Windows.Forms.Button();
            this.giaBanTextBox = new System.Windows.Forms.TextBox();
            this.hanghoaIdTextBox = new System.Windows.Forms.TextBox();
            this.motaTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTonKhoTextBox = new System.Windows.Forms.TextBox();
            this.tenHanghoaTextBox = new System.Windows.Forms.TextBox();
            this.hanghoaDataGridView = new System.Windows.Forms.DataGridView();
            this.recidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanghoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHanghoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomHanghoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            giaBanLabel = new System.Windows.Forms.Label();
            hanghoaIdLabel = new System.Windows.Forms.Label();
            motaLabel = new System.Windows.Forms.Label();
            soLuongTonKhoLabel = new System.Windows.Forms.Label();
            tenHanghoaLabel = new System.Windows.Forms.Label();
            nhomHanghoaIdLabel = new System.Windows.Forms.Label();
            this.NhomGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaBindingSource)).BeginInit();
            this.NhomChucnangGroupBox.SuspendLayout();
            this.DetailGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.Location = new System.Drawing.Point(14, 26);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(47, 13);
            giaBanLabel.TabIndex = 0;
            giaBanLabel.Text = "Giá bán:";
            // 
            // hanghoaIdLabel
            // 
            hanghoaIdLabel.AutoSize = true;
            hanghoaIdLabel.Location = new System.Drawing.Point(14, 52);
            hanghoaIdLabel.Name = "hanghoaIdLabel";
            hanghoaIdLabel.Size = new System.Drawing.Size(52, 13);
            hanghoaIdLabel.TabIndex = 2;
            hanghoaIdLabel.Text = "Mã hàng:";
            // 
            // motaLabel
            // 
            motaLabel.AutoSize = true;
            motaLabel.Location = new System.Drawing.Point(14, 78);
            motaLabel.Name = "motaLabel";
            motaLabel.Size = new System.Drawing.Size(37, 13);
            motaLabel.TabIndex = 4;
            motaLabel.Text = "Mô tả:";
            // 
            // soLuongTonKhoLabel
            // 
            soLuongTonKhoLabel.AutoSize = true;
            soLuongTonKhoLabel.Location = new System.Drawing.Point(14, 130);
            soLuongTonKhoLabel.Name = "soLuongTonKhoLabel";
            soLuongTonKhoLabel.Size = new System.Drawing.Size(52, 13);
            soLuongTonKhoLabel.TabIndex = 8;
            soLuongTonKhoLabel.Text = "Số lượng:";
            // 
            // tenHanghoaLabel
            // 
            tenHanghoaLabel.AutoSize = true;
            tenHanghoaLabel.Location = new System.Drawing.Point(14, 156);
            tenHanghoaLabel.Name = "tenHanghoaLabel";
            tenHanghoaLabel.Size = new System.Drawing.Size(56, 13);
            tenHanghoaLabel.TabIndex = 10;
            tenHanghoaLabel.Text = "Tên hàng:";
            // 
            // nhomHanghoaIdLabel
            // 
            nhomHanghoaIdLabel.AutoSize = true;
            nhomHanghoaIdLabel.Location = new System.Drawing.Point(14, 104);
            nhomHanghoaIdLabel.Name = "nhomHanghoaIdLabel";
            nhomHanghoaIdLabel.Size = new System.Drawing.Size(65, 13);
            nhomHanghoaIdLabel.TabIndex = 6;
            nhomHanghoaIdLabel.Text = "Nhóm hàng:";
            // 
            // NhomGroupBox
            // 
            this.NhomGroupBox.Controls.Add(this.nhomHanghoaDataGridView);
            this.NhomGroupBox.Controls.Add(this.NhomChucnangGroupBox);
            this.NhomGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.NhomGroupBox.Location = new System.Drawing.Point(0, 0);
            this.NhomGroupBox.Name = "NhomGroupBox";
            this.NhomGroupBox.Size = new System.Drawing.Size(284, 508);
            this.NhomGroupBox.TabIndex = 0;
            this.NhomGroupBox.TabStop = false;
            this.NhomGroupBox.Text = "Nhóm hàng hóa";
            // 
            // nhomHanghoaDataGridView
            // 
            this.nhomHanghoaDataGridView.AutoGenerateColumns = false;
            this.nhomHanghoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomHanghoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.nhomHanghoaDataGridView.DataSource = this.nhomHanghoaBindingSource;
            this.nhomHanghoaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhomHanghoaDataGridView.Location = new System.Drawing.Point(3, 69);
            this.nhomHanghoaDataGridView.Name = "nhomHanghoaDataGridView";
            this.nhomHanghoaDataGridView.Size = new System.Drawing.Size(278, 436);
            this.nhomHanghoaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NhomHanghoaId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhóm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhomHanghoa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhóm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ghichu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // nhomHanghoaBindingSource
            // 
            this.nhomHanghoaBindingSource.DataSource = typeof(Banhang.Domain.HanghoaHandler.NhomHanghoa);
            this.nhomHanghoaBindingSource.PositionChanged += new System.EventHandler(this.nhomHanghoaBindingSource_PositionChanged);
            // 
            // NhomChucnangGroupBox
            // 
            this.NhomChucnangGroupBox.Controls.Add(this.DeleteButton);
            this.NhomChucnangGroupBox.Controls.Add(this.SaveButton);
            this.NhomChucnangGroupBox.Controls.Add(this.LoaDataButton);
            this.NhomChucnangGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NhomChucnangGroupBox.Location = new System.Drawing.Point(3, 16);
            this.NhomChucnangGroupBox.Name = "NhomChucnangGroupBox";
            this.NhomChucnangGroupBox.Size = new System.Drawing.Size(278, 53);
            this.NhomChucnangGroupBox.TabIndex = 1;
            this.NhomChucnangGroupBox.TabStop = false;
            this.NhomChucnangGroupBox.Text = "Thao tác";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(103, 19);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(197, 19);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoaDataButton
            // 
            this.LoaDataButton.Location = new System.Drawing.Point(9, 19);
            this.LoaDataButton.Name = "LoaDataButton";
            this.LoaDataButton.Size = new System.Drawing.Size(75, 23);
            this.LoaDataButton.TabIndex = 5;
            this.LoaDataButton.Text = "Load Data";
            this.LoaDataButton.UseVisualStyleBackColor = true;
            this.LoaDataButton.Click += new System.EventHandler(this.LoaDataButton_Click);
            // 
            // DetailGroupBox
            // 
            this.DetailGroupBox.Controls.Add(this.NhomHanghoaComboBox);
            this.DetailGroupBox.Controls.Add(this.HanghoaDeleteButton);
            this.DetailGroupBox.Controls.Add(this.HanghoaSaveButton);
            this.DetailGroupBox.Controls.Add(giaBanLabel);
            this.DetailGroupBox.Controls.Add(this.giaBanTextBox);
            this.DetailGroupBox.Controls.Add(hanghoaIdLabel);
            this.DetailGroupBox.Controls.Add(this.hanghoaIdTextBox);
            this.DetailGroupBox.Controls.Add(motaLabel);
            this.DetailGroupBox.Controls.Add(this.motaTextBox);
            this.DetailGroupBox.Controls.Add(nhomHanghoaIdLabel);
            this.DetailGroupBox.Controls.Add(soLuongTonKhoLabel);
            this.DetailGroupBox.Controls.Add(this.soLuongTonKhoTextBox);
            this.DetailGroupBox.Controls.Add(tenHanghoaLabel);
            this.DetailGroupBox.Controls.Add(this.tenHanghoaTextBox);
            this.DetailGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DetailGroupBox.Location = new System.Drawing.Point(284, 0);
            this.DetailGroupBox.Name = "DetailGroupBox";
            this.DetailGroupBox.Size = new System.Drawing.Size(623, 193);
            this.DetailGroupBox.TabIndex = 1;
            this.DetailGroupBox.TabStop = false;
            this.DetailGroupBox.Text = "Thông tin chi tiết";
            // 
            // NhomHanghoaComboBox
            // 
            this.NhomHanghoaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hanghoaBindingSource, "NhomHanghoaId", true));
            this.NhomHanghoaComboBox.DataSource = this.bindingSource1;
            this.NhomHanghoaComboBox.DisplayMember = "DisplayString";
            this.NhomHanghoaComboBox.FormattingEnabled = true;
            this.NhomHanghoaComboBox.Location = new System.Drawing.Point(85, 101);
            this.NhomHanghoaComboBox.Name = "NhomHanghoaComboBox";
            this.NhomHanghoaComboBox.Size = new System.Drawing.Size(279, 21);
            this.NhomHanghoaComboBox.TabIndex = 14;
            this.NhomHanghoaComboBox.ValueMember = "NhomHanghoaId";
            // 
            // hanghoaBindingSource
            // 
            this.hanghoaBindingSource.DataSource = typeof(Banhang.Domain.HanghoaHandler.Hanghoa);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Banhang.Domain.HanghoaHandler.NhomHanghoa);
            // 
            // HanghoaDeleteButton
            // 
            this.HanghoaDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HanghoaDeleteButton.Location = new System.Drawing.Point(443, 23);
            this.HanghoaDeleteButton.Name = "HanghoaDeleteButton";
            this.HanghoaDeleteButton.Size = new System.Drawing.Size(75, 24);
            this.HanghoaDeleteButton.TabIndex = 13;
            this.HanghoaDeleteButton.Text = "Delete";
            this.HanghoaDeleteButton.UseVisualStyleBackColor = true;
            this.HanghoaDeleteButton.Click += new System.EventHandler(this.HanghoaDeleteButton_Click);
            // 
            // HanghoaSaveButton
            // 
            this.HanghoaSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HanghoaSaveButton.Location = new System.Drawing.Point(537, 23);
            this.HanghoaSaveButton.Name = "HanghoaSaveButton";
            this.HanghoaSaveButton.Size = new System.Drawing.Size(75, 24);
            this.HanghoaSaveButton.TabIndex = 12;
            this.HanghoaSaveButton.Text = "Save";
            this.HanghoaSaveButton.UseVisualStyleBackColor = true;
            this.HanghoaSaveButton.Click += new System.EventHandler(this.HanghoaSaveButton_Click);
            // 
            // giaBanTextBox
            // 
            this.giaBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hanghoaBindingSource, "GiaBan", true));
            this.giaBanTextBox.Location = new System.Drawing.Point(85, 23);
            this.giaBanTextBox.Name = "giaBanTextBox";
            this.giaBanTextBox.Size = new System.Drawing.Size(100, 20);
            this.giaBanTextBox.TabIndex = 1;
            // 
            // hanghoaIdTextBox
            // 
            this.hanghoaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hanghoaBindingSource, "HanghoaId", true));
            this.hanghoaIdTextBox.Location = new System.Drawing.Point(85, 49);
            this.hanghoaIdTextBox.Name = "hanghoaIdTextBox";
            this.hanghoaIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.hanghoaIdTextBox.TabIndex = 3;
            // 
            // motaTextBox
            // 
            this.motaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hanghoaBindingSource, "Mota", true));
            this.motaTextBox.Location = new System.Drawing.Point(85, 75);
            this.motaTextBox.Name = "motaTextBox";
            this.motaTextBox.Size = new System.Drawing.Size(100, 20);
            this.motaTextBox.TabIndex = 5;
            // 
            // soLuongTonKhoTextBox
            // 
            this.soLuongTonKhoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hanghoaBindingSource, "SoLuongTonKho", true));
            this.soLuongTonKhoTextBox.Location = new System.Drawing.Point(85, 127);
            this.soLuongTonKhoTextBox.Name = "soLuongTonKhoTextBox";
            this.soLuongTonKhoTextBox.Size = new System.Drawing.Size(100, 20);
            this.soLuongTonKhoTextBox.TabIndex = 9;
            // 
            // tenHanghoaTextBox
            // 
            this.tenHanghoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hanghoaBindingSource, "TenHanghoa", true));
            this.tenHanghoaTextBox.Location = new System.Drawing.Point(85, 153);
            this.tenHanghoaTextBox.Name = "tenHanghoaTextBox";
            this.tenHanghoaTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenHanghoaTextBox.TabIndex = 11;
            // 
            // hanghoaDataGridView
            // 
            this.hanghoaDataGridView.AutoGenerateColumns = false;
            this.hanghoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hanghoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recidDataGridViewTextBoxColumn,
            this.hanghoaIdDataGridViewTextBoxColumn,
            this.tenHanghoaDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.motaDataGridViewTextBoxColumn,
            this.soLuongTonKhoDataGridViewTextBoxColumn,
            this.nhomHanghoaIdDataGridViewTextBoxColumn});
            this.hanghoaDataGridView.DataSource = this.hanghoaBindingSource;
            this.hanghoaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hanghoaDataGridView.Location = new System.Drawing.Point(284, 193);
            this.hanghoaDataGridView.Name = "hanghoaDataGridView";
            this.hanghoaDataGridView.Size = new System.Drawing.Size(623, 315);
            this.hanghoaDataGridView.TabIndex = 2;
            // 
            // recidDataGridViewTextBoxColumn
            // 
            this.recidDataGridViewTextBoxColumn.DataPropertyName = "recid";
            this.recidDataGridViewTextBoxColumn.HeaderText = "recid";
            this.recidDataGridViewTextBoxColumn.Name = "recidDataGridViewTextBoxColumn";
            this.recidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hanghoaIdDataGridViewTextBoxColumn
            // 
            this.hanghoaIdDataGridViewTextBoxColumn.DataPropertyName = "HanghoaId";
            this.hanghoaIdDataGridViewTextBoxColumn.HeaderText = "Mã hàng";
            this.hanghoaIdDataGridViewTextBoxColumn.Name = "hanghoaIdDataGridViewTextBoxColumn";
            // 
            // tenHanghoaDataGridViewTextBoxColumn
            // 
            this.tenHanghoaDataGridViewTextBoxColumn.DataPropertyName = "TenHanghoa";
            this.tenHanghoaDataGridViewTextBoxColumn.HeaderText = "Tên hàng";
            this.tenHanghoaDataGridViewTextBoxColumn.Name = "tenHanghoaDataGridViewTextBoxColumn";
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "Giá bán";
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            // 
            // motaDataGridViewTextBoxColumn
            // 
            this.motaDataGridViewTextBoxColumn.DataPropertyName = "Mota";
            this.motaDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.motaDataGridViewTextBoxColumn.Name = "motaDataGridViewTextBoxColumn";
            // 
            // soLuongTonKhoDataGridViewTextBoxColumn
            // 
            this.soLuongTonKhoDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTonKho";
            this.soLuongTonKhoDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongTonKhoDataGridViewTextBoxColumn.Name = "soLuongTonKhoDataGridViewTextBoxColumn";
            // 
            // nhomHanghoaIdDataGridViewTextBoxColumn
            // 
            this.nhomHanghoaIdDataGridViewTextBoxColumn.DataPropertyName = "NhomHanghoaId";
            this.nhomHanghoaIdDataGridViewTextBoxColumn.HeaderText = "Nhóm hàng";
            this.nhomHanghoaIdDataGridViewTextBoxColumn.Name = "nhomHanghoaIdDataGridViewTextBoxColumn";
            // 
            // HanghoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 508);
            this.Controls.Add(this.hanghoaDataGridView);
            this.Controls.Add(this.DetailGroupBox);
            this.Controls.Add(this.NhomGroupBox);
            this.Name = "HanghoaForm";
            this.Text = "HanghoaForm";
            this.Load += new System.EventHandler(this.HanghoaForm_Load);
            this.NhomGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaBindingSource)).EndInit();
            this.NhomChucnangGroupBox.ResumeLayout(false);
            this.DetailGroupBox.ResumeLayout(false);
            this.DetailGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NhomGroupBox;
        private System.Windows.Forms.GroupBox DetailGroupBox;
        private System.Windows.Forms.DataGridView nhomHanghoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource nhomHanghoaBindingSource;
        private System.Windows.Forms.TextBox giaBanTextBox;
        private System.Windows.Forms.BindingSource hanghoaBindingSource;
        private System.Windows.Forms.TextBox hanghoaIdTextBox;
        private System.Windows.Forms.TextBox motaTextBox;
        private System.Windows.Forms.TextBox soLuongTonKhoTextBox;
        private System.Windows.Forms.TextBox tenHanghoaTextBox;
        private System.Windows.Forms.DataGridView hanghoaDataGridView;
        private System.Windows.Forms.GroupBox NhomChucnangGroupBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoaDataButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn recidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanghoaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHanghoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomHanghoaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button HanghoaDeleteButton;
        private System.Windows.Forms.Button HanghoaSaveButton;
        private System.Windows.Forms.ComboBox NhomHanghoaComboBox;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}