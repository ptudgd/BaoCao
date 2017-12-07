namespace KhachHangForm
{
    partial class frmKhachHang
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label gioitinhLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label khachhangIdLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label tenlotLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.khachhangIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPhieuMuaHang = new System.Windows.Forms.Button();
            this.diachiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.gioitinhCheckBox = new System.Windows.Forms.CheckBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.khachhangIdTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.tenlotTextBox = new System.Windows.Forms.TextBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            diachiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            gioitinhLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            khachhangIdLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            tenlotLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diachiLabel.Location = new System.Drawing.Point(8, 183);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(51, 13);
            diachiLabel.TabIndex = 14;
            diachiLabel.Text = "Địa chỉ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(8, 209);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(41, 13);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email:";
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gioitinhLabel.Location = new System.Drawing.Point(8, 127);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(60, 13);
            gioitinhLabel.TabIndex = 18;
            gioitinhLabel.Text = "Giới tính:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoLabel.Location = new System.Drawing.Point(8, 48);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(27, 13);
            hoLabel.TabIndex = 20;
            hoLabel.Text = "Họ:";
            // 
            // khachhangIdLabel
            // 
            khachhangIdLabel.AutoSize = true;
            khachhangIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            khachhangIdLabel.Location = new System.Drawing.Point(8, 22);
            khachhangIdLabel.Name = "khachhangIdLabel";
            khachhangIdLabel.Size = new System.Drawing.Size(99, 13);
            khachhangIdLabel.TabIndex = 22;
            khachhangIdLabel.Text = "Mã khách hàng:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(8, 155);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(87, 13);
            sDTLabel.TabIndex = 24;
            sDTLabel.Text = "Số điện thọai:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.Location = new System.Drawing.Point(8, 99);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(33, 13);
            tenLabel.TabIndex = 26;
            tenLabel.Text = "Tên:";
            // 
            // tenlotLabel
            // 
            tenlotLabel.AutoSize = true;
            tenlotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenlotLabel.Location = new System.Drawing.Point(8, 73);
            tenlotLabel.Name = "tenlotLabel";
            tenlotLabel.Size = new System.Drawing.Size(51, 13);
            tenlotLabel.TabIndex = 28;
            tenlotLabel.Text = "Tên lót:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.khachhangIdDataGridViewTextBoxColumn,
            this.hoDataGridViewTextBoxColumn,
            this.tenlotDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewCheckBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.khachHangBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // khachhangIdDataGridViewTextBoxColumn
            // 
            this.khachhangIdDataGridViewTextBoxColumn.DataPropertyName = "KhachhangId";
            this.khachhangIdDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.khachhangIdDataGridViewTextBoxColumn.Name = "khachhangIdDataGridViewTextBoxColumn";
            // 
            // hoDataGridViewTextBoxColumn
            // 
            this.hoDataGridViewTextBoxColumn.DataPropertyName = "Ho";
            this.hoDataGridViewTextBoxColumn.HeaderText = "Họ";
            this.hoDataGridViewTextBoxColumn.Name = "hoDataGridViewTextBoxColumn";
            // 
            // tenlotDataGridViewTextBoxColumn
            // 
            this.tenlotDataGridViewTextBoxColumn.DataPropertyName = "Tenlot";
            this.tenlotDataGridViewTextBoxColumn.HeaderText = "Tên lót";
            this.tenlotDataGridViewTextBoxColumn.Name = "tenlotDataGridViewTextBoxColumn";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // gioitinhDataGridViewCheckBoxColumn
            // 
            this.gioitinhDataGridViewCheckBoxColumn.DataPropertyName = "Gioitinh";
            this.gioitinhDataGridViewCheckBoxColumn.HeaderText = "Giới tính";
            this.gioitinhDataGridViewCheckBoxColumn.Name = "gioitinhDataGridViewCheckBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số điện thọai";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(KhachHang.Domain.KhachHang);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 342);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(553, 53);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 53);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Lưu";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(445, 53);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 53);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(610, 130);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(153, 70);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Tải dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPhieuMuaHang);
            this.groupBox1.Controls.Add(diachiLabel);
            this.groupBox1.Controls.Add(this.diachiTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(gioitinhLabel);
            this.groupBox1.Controls.Add(this.gioitinhCheckBox);
            this.groupBox1.Controls.Add(hoLabel);
            this.groupBox1.Controls.Add(this.hoTextBox);
            this.groupBox1.Controls.Add(khachhangIdLabel);
            this.groupBox1.Controls.Add(this.khachhangIdTextBox);
            this.groupBox1.Controls.Add(sDTLabel);
            this.groupBox1.Controls.Add(this.sDTTextBox);
            this.groupBox1.Controls.Add(tenLabel);
            this.groupBox1.Controls.Add(this.tenTextBox);
            this.groupBox1.Controls.Add(tenlotLabel);
            this.groupBox1.Controls.Add(this.tenlotTextBox);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách Hàng";
            // 
            // btnPhieuMuaHang
            // 
            this.btnPhieuMuaHang.Location = new System.Drawing.Point(661, 53);
            this.btnPhieuMuaHang.Name = "btnPhieuMuaHang";
            this.btnPhieuMuaHang.Size = new System.Drawing.Size(102, 53);
            this.btnPhieuMuaHang.TabIndex = 31;
            this.btnPhieuMuaHang.Text = "Phiếu mua hàng";
            this.btnPhieuMuaHang.UseVisualStyleBackColor = true;
            this.btnPhieuMuaHang.Click += new System.EventHandler(this.btnPhieuMuaHang_Click);
            // 
            // diachiTextBox
            // 
            this.diachiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Diachi", true));
            this.diachiTextBox.Location = new System.Drawing.Point(130, 180);
            this.diachiTextBox.Name = "diachiTextBox";
            this.diachiTextBox.Size = new System.Drawing.Size(261, 20);
            this.diachiTextBox.TabIndex = 15;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(130, 206);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(261, 20);
            this.emailTextBox.TabIndex = 17;
            // 
            // gioitinhCheckBox
            // 
            this.gioitinhCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.khachHangBindingSource, "Gioitinh", true));
            this.gioitinhCheckBox.Location = new System.Drawing.Point(130, 122);
            this.gioitinhCheckBox.Name = "gioitinhCheckBox";
            this.gioitinhCheckBox.Size = new System.Drawing.Size(261, 24);
            this.gioitinhCheckBox.TabIndex = 19;
            this.gioitinhCheckBox.Text = "Nam";
            this.gioitinhCheckBox.UseVisualStyleBackColor = true;
            // 
            // hoTextBox
            // 
            this.hoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Ho", true));
            this.hoTextBox.Location = new System.Drawing.Point(130, 45);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(261, 20);
            this.hoTextBox.TabIndex = 21;
            // 
            // khachhangIdTextBox
            // 
            this.khachhangIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "KhachhangId", true));
            this.khachhangIdTextBox.Location = new System.Drawing.Point(130, 19);
            this.khachhangIdTextBox.Name = "khachhangIdTextBox";
            this.khachhangIdTextBox.Size = new System.Drawing.Size(261, 20);
            this.khachhangIdTextBox.TabIndex = 23;
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(130, 152);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(261, 20);
            this.sDTTextBox.TabIndex = 25;
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(130, 96);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(261, 20);
            this.tenTextBox.TabIndex = 27;
            // 
            // tenlotTextBox
            // 
            this.tenlotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Tenlot", true));
            this.tenlotTextBox.Location = new System.Drawing.Point(130, 70);
            this.tenlotTextBox.Name = "tenlotTextBox";
            this.tenlotTextBox.Size = new System.Drawing.Size(261, 20);
            this.tenlotTextBox.TabIndex = 29;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(854, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachhangIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioitinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox diachiTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox gioitinhCheckBox;
        private System.Windows.Forms.TextBox hoTextBox;
        private System.Windows.Forms.TextBox khachhangIdTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox tenTextBox;
        private System.Windows.Forms.TextBox tenlotTextBox;
        private System.Windows.Forms.Button btnPhieuMuaHang;
    }
}

