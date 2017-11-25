namespace HangHoaForm
{
    partial class frmHangHoa
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
            System.Windows.Forms.Label giaBanLabel;
            System.Windows.Forms.Label hanghoaIdLabel;
            System.Windows.Forms.Label motaLabel;
            System.Windows.Forms.Label nhomHanghoaIdLabel;
            System.Windows.Forms.Label soLuongTonKhoLabel;
            System.Windows.Forms.Label tenHanghoaLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hanghoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHanghoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomHanghoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.giaBanTextBox = new System.Windows.Forms.TextBox();
            this.hanghoaIdTextBox = new System.Windows.Forms.TextBox();
            this.motaTextBox = new System.Windows.Forms.TextBox();
            this.nhomHanghoaIdTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTonKhoTextBox = new System.Windows.Forms.TextBox();
            this.tenHanghoaTextBox = new System.Windows.Forms.TextBox();
            giaBanLabel = new System.Windows.Forms.Label();
            hanghoaIdLabel = new System.Windows.Forms.Label();
            motaLabel = new System.Windows.Forms.Label();
            nhomHanghoaIdLabel = new System.Windows.Forms.Label();
            soLuongTonKhoLabel = new System.Windows.Forms.Label();
            tenHanghoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.Location = new System.Drawing.Point(12, 28);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(47, 13);
            giaBanLabel.TabIndex = 13;
            giaBanLabel.Text = "Giá bán:";
            // 
            // hanghoaIdLabel
            // 
            hanghoaIdLabel.AutoSize = true;
            hanghoaIdLabel.Location = new System.Drawing.Point(12, 54);
            hanghoaIdLabel.Name = "hanghoaIdLabel";
            hanghoaIdLabel.Size = new System.Drawing.Size(73, 13);
            hanghoaIdLabel.TabIndex = 15;
            hanghoaIdLabel.Text = "Mã hàng hóa:";
            // 
            // motaLabel
            // 
            motaLabel.AutoSize = true;
            motaLabel.Location = new System.Drawing.Point(12, 80);
            motaLabel.Name = "motaLabel";
            motaLabel.Size = new System.Drawing.Size(37, 13);
            motaLabel.TabIndex = 17;
            motaLabel.Text = "Mô tả:";
            // 
            // nhomHanghoaIdLabel
            // 
            nhomHanghoaIdLabel.AutoSize = true;
            nhomHanghoaIdLabel.Location = new System.Drawing.Point(12, 106);
            nhomHanghoaIdLabel.Name = "nhomHanghoaIdLabel";
            nhomHanghoaIdLabel.Size = new System.Drawing.Size(102, 13);
            nhomHanghoaIdLabel.TabIndex = 19;
            nhomHanghoaIdLabel.Text = "Mã nhóm hàng hóa:";
            // 
            // soLuongTonKhoLabel
            // 
            soLuongTonKhoLabel.AutoSize = true;
            soLuongTonKhoLabel.Location = new System.Drawing.Point(12, 132);
            soLuongTonKhoLabel.Name = "soLuongTonKhoLabel";
            soLuongTonKhoLabel.Size = new System.Drawing.Size(91, 13);
            soLuongTonKhoLabel.TabIndex = 21;
            soLuongTonKhoLabel.Text = "Số lượng tồn kho:";
            // 
            // tenHanghoaLabel
            // 
            tenHanghoaLabel.AutoSize = true;
            tenHanghoaLabel.Location = new System.Drawing.Point(12, 158);
            tenHanghoaLabel.Name = "tenHanghoaLabel";
            tenHanghoaLabel.Size = new System.Drawing.Size(77, 13);
            tenHanghoaLabel.TabIndex = 23;
            tenHanghoaLabel.Text = "Tên hàng hóa:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hanghoaIdDataGridViewTextBoxColumn,
            this.tenHanghoaDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.motaDataGridViewTextBoxColumn,
            this.soLuongTonKhoDataGridViewTextBoxColumn,
            this.nhomHanghoaIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hangHoaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CursorChanged += new System.EventHandler(this.dataGridView1_CursorChanged);
            // 
            // hanghoaIdDataGridViewTextBoxColumn
            // 
            this.hanghoaIdDataGridViewTextBoxColumn.DataPropertyName = "HanghoaId";
            this.hanghoaIdDataGridViewTextBoxColumn.HeaderText = "Mã hàng hóa";
            this.hanghoaIdDataGridViewTextBoxColumn.Name = "hanghoaIdDataGridViewTextBoxColumn";
            // 
            // tenHanghoaDataGridViewTextBoxColumn
            // 
            this.tenHanghoaDataGridViewTextBoxColumn.DataPropertyName = "TenHanghoa";
            this.tenHanghoaDataGridViewTextBoxColumn.HeaderText = "Tên hàng hóa";
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
            this.soLuongTonKhoDataGridViewTextBoxColumn.HeaderText = "Số lượng tồn kho";
            this.soLuongTonKhoDataGridViewTextBoxColumn.Name = "soLuongTonKhoDataGridViewTextBoxColumn";
            // 
            // nhomHanghoaIdDataGridViewTextBoxColumn
            // 
            this.nhomHanghoaIdDataGridViewTextBoxColumn.DataPropertyName = "NhomHanghoaId";
            this.nhomHanghoaIdDataGridViewTextBoxColumn.HeaderText = "Mã nhóm hàng hóa";
            this.nhomHanghoaIdDataGridViewTextBoxColumn.Name = "nhomHanghoaIdDataGridViewTextBoxColumn";
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataSource = typeof(HangHoa.Domain.HangHoa);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 248);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(535, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 53);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(427, 60);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 53);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(319, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 53);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(754, 193);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 44);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Tải dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(giaBanLabel);
            this.groupBox1.Controls.Add(this.giaBanTextBox);
            this.groupBox1.Controls.Add(hanghoaIdLabel);
            this.groupBox1.Controls.Add(this.hanghoaIdTextBox);
            this.groupBox1.Controls.Add(motaLabel);
            this.groupBox1.Controls.Add(this.motaTextBox);
            this.groupBox1.Controls.Add(nhomHanghoaIdLabel);
            this.groupBox1.Controls.Add(this.nhomHanghoaIdTextBox);
            this.groupBox1.Controls.Add(soLuongTonKhoLabel);
            this.groupBox1.Controls.Add(this.soLuongTonKhoTextBox);
            this.groupBox1.Controls.Add(tenHanghoaLabel);
            this.groupBox1.Controls.Add(this.tenHanghoaTextBox);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hàng hóa";
            // 
            // giaBanTextBox
            // 
            this.giaBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "GiaBan", true));
            this.giaBanTextBox.Location = new System.Drawing.Point(120, 25);
            this.giaBanTextBox.Name = "giaBanTextBox";
            this.giaBanTextBox.Size = new System.Drawing.Size(134, 20);
            this.giaBanTextBox.TabIndex = 14;
            // 
            // hanghoaIdTextBox
            // 
            this.hanghoaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "HanghoaId", true));
            this.hanghoaIdTextBox.Location = new System.Drawing.Point(120, 51);
            this.hanghoaIdTextBox.Name = "hanghoaIdTextBox";
            this.hanghoaIdTextBox.Size = new System.Drawing.Size(134, 20);
            this.hanghoaIdTextBox.TabIndex = 16;
            // 
            // motaTextBox
            // 
            this.motaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "Mota", true));
            this.motaTextBox.Location = new System.Drawing.Point(120, 77);
            this.motaTextBox.Name = "motaTextBox";
            this.motaTextBox.Size = new System.Drawing.Size(134, 20);
            this.motaTextBox.TabIndex = 18;
            // 
            // nhomHanghoaIdTextBox
            // 
            this.nhomHanghoaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "NhomHanghoaId", true));
            this.nhomHanghoaIdTextBox.Location = new System.Drawing.Point(120, 103);
            this.nhomHanghoaIdTextBox.Name = "nhomHanghoaIdTextBox";
            this.nhomHanghoaIdTextBox.Size = new System.Drawing.Size(134, 20);
            this.nhomHanghoaIdTextBox.TabIndex = 20;
            // 
            // soLuongTonKhoTextBox
            // 
            this.soLuongTonKhoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "SoLuongTonKho", true));
            this.soLuongTonKhoTextBox.Location = new System.Drawing.Point(120, 129);
            this.soLuongTonKhoTextBox.Name = "soLuongTonKhoTextBox";
            this.soLuongTonKhoTextBox.Size = new System.Drawing.Size(134, 20);
            this.soLuongTonKhoTextBox.TabIndex = 22;
            // 
            // tenHanghoaTextBox
            // 
            this.tenHanghoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "TenHanghoa", true));
            this.tenHanghoaTextBox.Location = new System.Drawing.Point(120, 155);
            this.tenHanghoaTextBox.Name = "tenHanghoaTextBox";
            this.tenHanghoaTextBox.Size = new System.Drawing.Size(134, 20);
            this.tenHanghoaTextBox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hàng hóa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanghoaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHanghoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomHanghoaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox giaBanTextBox;
        private System.Windows.Forms.TextBox hanghoaIdTextBox;
        private System.Windows.Forms.TextBox motaTextBox;
        private System.Windows.Forms.TextBox nhomHanghoaIdTextBox;
        private System.Windows.Forms.TextBox soLuongTonKhoTextBox;
        private System.Windows.Forms.TextBox tenHanghoaTextBox;
    }
}

