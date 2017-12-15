namespace dashboard
{
    partial class KhachHangControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.khachhangIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSearchStaff = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearchCustomer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuCustomDataGrid1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 384);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.khachhangIdDataGridViewTextBoxColumn,
            this.hoDataGridViewTextBoxColumn,
            this.tenlotDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewCheckBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.khachHangBindingSource;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.DimGray;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.LightYellow;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(3, 16);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(877, 365);
            this.bunifuCustomDataGrid1.TabIndex = 0;
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
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(NhanVien.Domain.NhanVien);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(731, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 41);
            this.button3.TabIndex = 24;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(731, 52);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 38);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(731, 9);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(141, 37);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Tải dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.BackColor = System.Drawing.Color.White;
            this.btnSearchStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchStaff.Image")));
            this.btnSearchStaff.ImageActive = null;
            this.btnSearchStaff.Location = new System.Drawing.Point(566, 13);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(29, 33);
            this.btnSearchStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchStaff.TabIndex = 21;
            this.btnSearchStaff.TabStop = false;
            this.btnSearchStaff.Zoom = 10;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchCustomer.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchCustomer.HintText = "Nhập tên khách hàng";
            this.txtSearchCustomer.isPassword = false;
            this.txtSearchCustomer.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchCustomer.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchCustomer.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchCustomer.LineThickness = 3;
            this.txtSearchCustomer.Location = new System.Drawing.Point(373, 13);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(196, 33);
            this.txtSearchCustomer.TabIndex = 20;
            this.txtSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(158, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // KhachHangControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSearchStaff);
            this.Controls.Add(this.txtSearchCustomer);
            this.Name = "KhachHangControl";
            this.Size = new System.Drawing.Size(883, 543);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private Bunifu.Framework.UI.BunifuImageButton btnSearchStaff;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchCustomer;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
