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
            this.nhacungcapIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangHoaCungCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomhanghoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diachiLabel.Location = new System.Drawing.Point(12, 156);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(51, 13);
            diachiLabel.TabIndex = 13;
            diachiLabel.Text = "Địa chỉ:";
            // 
            // hangHoaCungCapLabel
            // 
            hangHoaCungCapLabel.AutoSize = true;
            hangHoaCungCapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hangHoaCungCapLabel.Location = new System.Drawing.Point(12, 78);
            hangHoaCungCapLabel.Name = "hangHoaCungCapLabel";
            hangHoaCungCapLabel.Size = new System.Drawing.Size(121, 13);
            hangHoaCungCapLabel.TabIndex = 15;
            hangHoaCungCapLabel.Text = "Mặt hàng cung cấp:";
            // 
            // nhacungcapIdLabel
            // 
            nhacungcapIdLabel.AutoSize = true;
            nhacungcapIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nhacungcapIdLabel.Location = new System.Drawing.Point(12, 26);
            nhacungcapIdLabel.Name = "nhacungcapIdLabel";
            nhacungcapIdLabel.Size = new System.Drawing.Size(110, 13);
            nhacungcapIdLabel.TabIndex = 17;
            nhacungcapIdLabel.Text = "Mã nhà cung cấp:";
            // 
            // nhomhanghoaIdLabel
            // 
            nhomhanghoaIdLabel.AutoSize = true;
            nhomhanghoaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nhomhanghoaIdLabel.Location = new System.Drawing.Point(12, 104);
            nhomhanghoaIdLabel.Name = "nhomhanghoaIdLabel";
            nhomhanghoaIdLabel.Size = new System.Drawing.Size(100, 13);
            nhomhanghoaIdLabel.TabIndex = 19;
            nhomhanghoaIdLabel.Text = "Nhóm hàng hóa:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(12, 130);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(87, 13);
            sDTLabel.TabIndex = 21;
            sDTLabel.Text = "Số điện thoại:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.Location = new System.Drawing.Point(12, 52);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(115, 13);
            tenLabel.TabIndex = 23;
            tenLabel.Text = "Tên nhà cung cấp:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 299);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.Size = new System.Drawing.Size(685, 280);
            this.dataGridView1.TabIndex = 0;
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
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataSource = typeof(NhaCungCap.Domain.NhaCungCap);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(450, 64);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 53);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Lưu";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(342, 64);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 53);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(560, 64);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 53);
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
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 182);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhà cung cấp";
            // 
            // diachiTextBox
            // 
            this.diachiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "Diachi", true));
            this.diachiTextBox.Location = new System.Drawing.Point(137, 156);
            this.diachiTextBox.Name = "diachiTextBox";
            this.diachiTextBox.Size = new System.Drawing.Size(168, 20);
            this.diachiTextBox.TabIndex = 14;
            // 
            // hangHoaCungCapTextBox
            // 
            this.hangHoaCungCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "HangHoaCungCap", true));
            this.hangHoaCungCapTextBox.Location = new System.Drawing.Point(137, 78);
            this.hangHoaCungCapTextBox.Name = "hangHoaCungCapTextBox";
            this.hangHoaCungCapTextBox.Size = new System.Drawing.Size(168, 20);
            this.hangHoaCungCapTextBox.TabIndex = 16;
            // 
            // nhacungcapIdTextBox
            // 
            this.nhacungcapIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "NhacungcapId", true));
            this.nhacungcapIdTextBox.Location = new System.Drawing.Point(137, 26);
            this.nhacungcapIdTextBox.Name = "nhacungcapIdTextBox";
            this.nhacungcapIdTextBox.Size = new System.Drawing.Size(168, 20);
            this.nhacungcapIdTextBox.TabIndex = 18;
            // 
            // nhomhanghoaIdTextBox
            // 
            this.nhomhanghoaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "NhomhanghoaId", true));
            this.nhomhanghoaIdTextBox.Location = new System.Drawing.Point(137, 104);
            this.nhomhanghoaIdTextBox.Name = "nhomhanghoaIdTextBox";
            this.nhomhanghoaIdTextBox.Size = new System.Drawing.Size(168, 20);
            this.nhomhanghoaIdTextBox.TabIndex = 20;
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(137, 130);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(168, 20);
            this.sDTTextBox.TabIndex = 22;
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapBindingSource, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(137, 52);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(168, 20);
            this.tenTextBox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 481);
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

