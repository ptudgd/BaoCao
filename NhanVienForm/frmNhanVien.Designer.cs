namespace NhanVienForm
{
    partial class FrmNhanVien
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
            System.Windows.Forms.Label gioitinhLabel;
            System.Windows.Forms.Label holotLabel;
            System.Windows.Forms.Label ngaysinhLabel;
            System.Windows.Forms.Label ngayVaolamLabel;
            System.Windows.Forms.Label nhanvienIdLabel;
            System.Windows.Forms.Label tenLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gioitinhCheckBox = new System.Windows.Forms.CheckBox();
            this.holotTextBox = new System.Windows.Forms.TextBox();
            this.ngaysinhTextBox = new System.Windows.Forms.TextBox();
            this.ngayVaolamTextBox = new System.Windows.Forms.TextBox();
            this.nhanvienIdTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.nhanvienIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayVaolamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gioitinhLabel = new System.Windows.Forms.Label();
            holotLabel = new System.Windows.Forms.Label();
            ngaysinhLabel = new System.Windows.Forms.Label();
            ngayVaolamLabel = new System.Windows.Forms.Label();
            nhanvienIdLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(gioitinhLabel);
            this.groupBox1.Controls.Add(this.gioitinhCheckBox);
            this.groupBox1.Controls.Add(holotLabel);
            this.groupBox1.Controls.Add(this.holotTextBox);
            this.groupBox1.Controls.Add(ngaysinhLabel);
            this.groupBox1.Controls.Add(this.ngaysinhTextBox);
            this.groupBox1.Controls.Add(ngayVaolamLabel);
            this.groupBox1.Controls.Add(this.ngayVaolamTextBox);
            this.groupBox1.Controls.Add(nhanvienIdLabel);
            this.groupBox1.Controls.Add(this.nhanvienIdTextBox);
            this.groupBox1.Controls.Add(tenLabel);
            this.groupBox1.Controls.Add(this.tenTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Phiếu bán hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(535, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 53);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(628, 179);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 44);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Tải dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nhanvienIdDataGridViewTextBoxColumn,
            this.holotDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewCheckBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.ngayVaolamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhanVienBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(NhanVien.Domain.NhanVien);
            this.nhanVienBindingSource.CurrentChanged += new System.EventHandler(this.nhanVienBindingSource_CurrentChanged);
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Location = new System.Drawing.Point(24, 31);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(50, 13);
            gioitinhLabel.TabIndex = 14;
            gioitinhLabel.Text = "Giới tính:";
            // 
            // gioitinhCheckBox
            // 
            this.gioitinhCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.nhanVienBindingSource, "Gioitinh", true));
            this.gioitinhCheckBox.Location = new System.Drawing.Point(109, 26);
            this.gioitinhCheckBox.Name = "gioitinhCheckBox";
            this.gioitinhCheckBox.Size = new System.Drawing.Size(104, 24);
            this.gioitinhCheckBox.TabIndex = 15;
            this.gioitinhCheckBox.Text = "Nam";
            this.gioitinhCheckBox.UseVisualStyleBackColor = true;
            // 
            // holotLabel
            // 
            holotLabel.AutoSize = true;
            holotLabel.Location = new System.Drawing.Point(24, 59);
            holotLabel.Name = "holotLabel";
            holotLabel.Size = new System.Drawing.Size(38, 13);
            holotLabel.TabIndex = 16;
            holotLabel.Text = "Họ lót:";
            // 
            // holotTextBox
            // 
            this.holotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "Holot", true));
            this.holotTextBox.Location = new System.Drawing.Point(109, 56);
            this.holotTextBox.Name = "holotTextBox";
            this.holotTextBox.Size = new System.Drawing.Size(104, 20);
            this.holotTextBox.TabIndex = 17;
            // 
            // ngaysinhLabel
            // 
            ngaysinhLabel.AutoSize = true;
            ngaysinhLabel.Location = new System.Drawing.Point(24, 85);
            ngaysinhLabel.Name = "ngaysinhLabel";
            ngaysinhLabel.Size = new System.Drawing.Size(57, 13);
            ngaysinhLabel.TabIndex = 18;
            ngaysinhLabel.Text = "Ngày sinh:";
            // 
            // ngaysinhTextBox
            // 
            this.ngaysinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "Ngaysinh", true));
            this.ngaysinhTextBox.Location = new System.Drawing.Point(109, 82);
            this.ngaysinhTextBox.Name = "ngaysinhTextBox";
            this.ngaysinhTextBox.Size = new System.Drawing.Size(104, 20);
            this.ngaysinhTextBox.TabIndex = 19;
            // 
            // ngayVaolamLabel
            // 
            ngayVaolamLabel.AutoSize = true;
            ngayVaolamLabel.Location = new System.Drawing.Point(24, 111);
            ngayVaolamLabel.Name = "ngayVaolamLabel";
            ngayVaolamLabel.Size = new System.Drawing.Size(75, 13);
            ngayVaolamLabel.TabIndex = 20;
            ngayVaolamLabel.Text = "Ngày vào làm:";
            // 
            // ngayVaolamTextBox
            // 
            this.ngayVaolamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "NgayVaolam", true));
            this.ngayVaolamTextBox.Location = new System.Drawing.Point(109, 108);
            this.ngayVaolamTextBox.Name = "ngayVaolamTextBox";
            this.ngayVaolamTextBox.Size = new System.Drawing.Size(104, 20);
            this.ngayVaolamTextBox.TabIndex = 21;
            // 
            // nhanvienIdLabel
            // 
            nhanvienIdLabel.AutoSize = true;
            nhanvienIdLabel.Location = new System.Drawing.Point(24, 137);
            nhanvienIdLabel.Name = "nhanvienIdLabel";
            nhanvienIdLabel.Size = new System.Drawing.Size(75, 13);
            nhanvienIdLabel.TabIndex = 22;
            nhanvienIdLabel.Text = "Mã nhân viên:";
            // 
            // nhanvienIdTextBox
            // 
            this.nhanvienIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "NhanvienId", true));
            this.nhanvienIdTextBox.Location = new System.Drawing.Point(109, 134);
            this.nhanvienIdTextBox.Name = "nhanvienIdTextBox";
            this.nhanvienIdTextBox.Size = new System.Drawing.Size(104, 20);
            this.nhanvienIdTextBox.TabIndex = 23;
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(24, 163);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(79, 13);
            tenLabel.TabIndex = 24;
            tenLabel.Text = "Tên nhân viên:";
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(109, 160);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(104, 20);
            this.tenTextBox.TabIndex = 25;
            // 
            // nhanvienIdDataGridViewTextBoxColumn
            // 
            this.nhanvienIdDataGridViewTextBoxColumn.DataPropertyName = "NhanvienId";
            this.nhanvienIdDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.nhanvienIdDataGridViewTextBoxColumn.Name = "nhanvienIdDataGridViewTextBoxColumn";
            // 
            // holotDataGridViewTextBoxColumn
            // 
            this.holotDataGridViewTextBoxColumn.DataPropertyName = "Holot";
            this.holotDataGridViewTextBoxColumn.HeaderText = "Họ lót";
            this.holotDataGridViewTextBoxColumn.Name = "holotDataGridViewTextBoxColumn";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // gioitinhDataGridViewCheckBoxColumn
            // 
            this.gioitinhDataGridViewCheckBoxColumn.DataPropertyName = "Gioitinh";
            this.gioitinhDataGridViewCheckBoxColumn.HeaderText = "Giới tính";
            this.gioitinhDataGridViewCheckBoxColumn.Name = "gioitinhDataGridViewCheckBoxColumn";
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "Ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            // 
            // ngayVaolamDataGridViewTextBoxColumn
            // 
            this.ngayVaolamDataGridViewTextBoxColumn.DataPropertyName = "NgayVaolam";
            this.ngayVaolamDataGridViewTextBoxColumn.HeaderText = "Ngày vào làm";
            this.ngayVaolamDataGridViewTextBoxColumn.Name = "ngayVaolamDataGridViewTextBoxColumn";
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNhanVien";
            this.Text = "Form nhân viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox gioitinhCheckBox;
        private System.Windows.Forms.TextBox holotTextBox;
        private System.Windows.Forms.TextBox ngaysinhTextBox;
        private System.Windows.Forms.TextBox ngayVaolamTextBox;
        private System.Windows.Forms.TextBox nhanvienIdTextBox;
        private System.Windows.Forms.TextBox tenTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanvienIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioitinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayVaolamDataGridViewTextBoxColumn;
    }
}

