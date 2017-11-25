namespace NhaCungCapForm
{
    partial class Form1
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
            System.Windows.Forms.Label diachiLabel;
            System.Windows.Forms.Label hangHoaCungCapLabel;
            System.Windows.Forms.Label nhacungcapIdLabel;
            System.Windows.Forms.Label nhomhanghoaIdLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label tenLabel;
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nhacungcapIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangHoaCungCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomhanghoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiTextBox = new System.Windows.Forms.TextBox();
            this.hangHoaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.nhacungcapIdTextBox = new System.Windows.Forms.TextBox();
            this.nhomhanghoaIdTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            diachiLabel = new System.Windows.Forms.Label();
            hangHoaCungCapLabel = new System.Windows.Forms.Label();
            nhacungcapIdLabel = new System.Windows.Forms.Label();
            nhomhanghoaIdLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 256);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nhacungcapIdDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.hangHoaCungCapDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.nhomhanghoaIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhaCungCapBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataSource = typeof(NhaCungCap.Domain.NhaCungCap);
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
            this.btnLoad.Location = new System.Drawing.Point(569, 150);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 44);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Tải dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(diachiLabel);
            this.groupBox1.Controls.Add(this.diachiTextBox);
            this.groupBox1.Controls.Add(hangHoaCungCapLabel);
            this.groupBox1.Controls.Add(this.hangHoaCungCapTextBox);
            this.groupBox1.Controls.Add(nhacungcapIdLabel);
            this.groupBox1.Controls.Add(this.nhacungcapIdTextBox);
            this.groupBox1.Controls.Add(nhomhanghoaIdLabel);
            this.groupBox1.Controls.Add(this.nhomhanghoaIdTextBox);
            this.groupBox1.Controls.Add(sDTLabel);
            this.groupBox1.Controls.Add(this.sDTTextBox);
            this.groupBox1.Controls.Add(tenLabel);
            this.groupBox1.Controls.Add(this.tenTextBox);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 225);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhà cung cấp";
            // 
            // nhacungcapIdDataGridViewTextBoxColumn
            // 
            this.nhacungcapIdDataGridViewTextBoxColumn.DataPropertyName = "NhacungcapId";
            this.nhacungcapIdDataGridViewTextBoxColumn.HeaderText = "Mã nhà cung cấp";
            this.nhacungcapIdDataGridViewTextBoxColumn.Name = "nhacungcapIdDataGridViewTextBoxColumn";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên nhà cung cấp";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // hangHoaCungCapDataGridViewTextBoxColumn
            // 
            this.hangHoaCungCapDataGridViewTextBoxColumn.DataPropertyName = "HangHoaCungCap";
            this.hangHoaCungCapDataGridViewTextBoxColumn.HeaderText = "Mặt hàng cung cấp";
            this.hangHoaCungCapDataGridViewTextBoxColumn.Name = "hangHoaCungCapDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            // 
            // nhomhanghoaIdDataGridViewTextBoxColumn
            // 
            this.nhomhanghoaIdDataGridViewTextBoxColumn.DataPropertyName = "NhomhanghoaId";
            this.nhomhanghoaIdDataGridViewTextBoxColumn.HeaderText = "Nhóm hàng hóa";
            this.nhomhanghoaIdDataGridViewTextBoxColumn.Name = "nhomhanghoaIdDataGridViewTextBoxColumn";
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Location = new System.Drawing.Point(25, 37);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(43, 13);
            diachiLabel.TabIndex = 13;
            diachiLabel.Text = "Địa chỉ:";
            // 
            // diachiTextBox
            // 
            this.diachiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "Diachi", true));
            this.diachiTextBox.Location = new System.Drawing.Point(134, 34);
            this.diachiTextBox.Name = "diachiTextBox";
            this.diachiTextBox.Size = new System.Drawing.Size(100, 20);
            this.diachiTextBox.TabIndex = 14;
            // 
            // hangHoaCungCapLabel
            // 
            hangHoaCungCapLabel.AutoSize = true;
            hangHoaCungCapLabel.Location = new System.Drawing.Point(25, 63);
            hangHoaCungCapLabel.Name = "hangHoaCungCapLabel";
            hangHoaCungCapLabel.Size = new System.Drawing.Size(103, 13);
            hangHoaCungCapLabel.TabIndex = 15;
            hangHoaCungCapLabel.Text = "Mặt hàng cung cấp:";
            // 
            // hangHoaCungCapTextBox
            // 
            this.hangHoaCungCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "HangHoaCungCap", true));
            this.hangHoaCungCapTextBox.Location = new System.Drawing.Point(134, 60);
            this.hangHoaCungCapTextBox.Name = "hangHoaCungCapTextBox";
            this.hangHoaCungCapTextBox.Size = new System.Drawing.Size(100, 20);
            this.hangHoaCungCapTextBox.TabIndex = 16;
            // 
            // nhacungcapIdLabel
            // 
            nhacungcapIdLabel.AutoSize = true;
            nhacungcapIdLabel.Location = new System.Drawing.Point(25, 89);
            nhacungcapIdLabel.Name = "nhacungcapIdLabel";
            nhacungcapIdLabel.Size = new System.Drawing.Size(94, 13);
            nhacungcapIdLabel.TabIndex = 17;
            nhacungcapIdLabel.Text = "Mã nhà cung cấp:";
            // 
            // nhacungcapIdTextBox
            // 
            this.nhacungcapIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "NhacungcapId", true));
            this.nhacungcapIdTextBox.Location = new System.Drawing.Point(134, 86);
            this.nhacungcapIdTextBox.Name = "nhacungcapIdTextBox";
            this.nhacungcapIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.nhacungcapIdTextBox.TabIndex = 18;
            // 
            // nhomhanghoaIdLabel
            // 
            nhomhanghoaIdLabel.AutoSize = true;
            nhomhanghoaIdLabel.Location = new System.Drawing.Point(25, 115);
            nhomhanghoaIdLabel.Name = "nhomhanghoaIdLabel";
            nhomhanghoaIdLabel.Size = new System.Drawing.Size(86, 13);
            nhomhanghoaIdLabel.TabIndex = 19;
            nhomhanghoaIdLabel.Text = "Nhóm hàng hóa:";
            // 
            // nhomhanghoaIdTextBox
            // 
            this.nhomhanghoaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "NhomhanghoaId", true));
            this.nhomhanghoaIdTextBox.Location = new System.Drawing.Point(134, 112);
            this.nhomhanghoaIdTextBox.Name = "nhomhanghoaIdTextBox";
            this.nhomhanghoaIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.nhomhanghoaIdTextBox.TabIndex = 20;
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(25, 141);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(73, 13);
            sDTLabel.TabIndex = 21;
            sDTLabel.Text = "Số điện thoại:";
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(134, 138);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(100, 20);
            this.sDTTextBox.TabIndex = 22;
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(25, 167);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(98, 13);
            tenLabel.TabIndex = 23;
            tenLabel.Text = "Tên nhà cung cấp:";
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(134, 164);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenTextBox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Nhà Cung Cấp";
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhacungcapIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangHoaCungCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomhanghoaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox diachiTextBox;
        private System.Windows.Forms.TextBox hangHoaCungCapTextBox;
        private System.Windows.Forms.TextBox nhacungcapIdTextBox;
        private System.Windows.Forms.TextBox nhomhanghoaIdTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox tenTextBox;
    }
}

