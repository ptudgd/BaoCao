namespace dashboard
{
    partial class DanhSachBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachBanHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tenSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giabanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomHanghoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanghoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Datepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Datepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuCustomDataGrid1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 340);
            this.groupBox1.TabIndex = 0;
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
            this.tenSanPhamDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giabanDataGridViewTextBoxColumn,
            this.ngayBanDataGridViewTextBoxColumn,
            this.nhomHanghoaIdDataGridViewTextBoxColumn,
            this.hanghoaIdDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.banHangBindingSource;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.DimGray;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.LightYellow;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(3, 16);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(877, 321);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            // 
            // tenSanPhamDataGridViewTextBoxColumn
            // 
            this.tenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham";
            this.tenSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên hàng hóa";
            this.tenSanPhamDataGridViewTextBoxColumn.Name = "tenSanPhamDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // giabanDataGridViewTextBoxColumn
            // 
            this.giabanDataGridViewTextBoxColumn.DataPropertyName = "Giaban";
            this.giabanDataGridViewTextBoxColumn.HeaderText = "Giá bán";
            this.giabanDataGridViewTextBoxColumn.Name = "giabanDataGridViewTextBoxColumn";
            // 
            // ngayBanDataGridViewTextBoxColumn
            // 
            this.ngayBanDataGridViewTextBoxColumn.DataPropertyName = "NgayBan";
            this.ngayBanDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.ngayBanDataGridViewTextBoxColumn.Name = "ngayBanDataGridViewTextBoxColumn";
            // 
            // nhomHanghoaIdDataGridViewTextBoxColumn
            // 
            this.nhomHanghoaIdDataGridViewTextBoxColumn.DataPropertyName = "NhomHanghoaId";
            this.nhomHanghoaIdDataGridViewTextBoxColumn.HeaderText = "Mã nhóm hàng hóa";
            this.nhomHanghoaIdDataGridViewTextBoxColumn.Name = "nhomHanghoaIdDataGridViewTextBoxColumn";
            // 
            // hanghoaIdDataGridViewTextBoxColumn
            // 
            this.hanghoaIdDataGridViewTextBoxColumn.DataPropertyName = "HanghoaId";
            this.hanghoaIdDataGridViewTextBoxColumn.HeaderText = "Mã hàng hóa";
            this.hanghoaIdDataGridViewTextBoxColumn.Name = "hanghoaIdDataGridViewTextBoxColumn";
            // 
            // banHangBindingSource
            // 
            this.banHangBindingSource.DataSource = typeof(BanHang.Domain.BanHang);
            // 
            // Datepicker1
            // 
            this.Datepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.Datepicker1.BorderRadius = 0;
            this.Datepicker1.ForeColor = System.Drawing.Color.White;
            this.Datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker1.FormatCustom = null;
            this.Datepicker1.Location = new System.Drawing.Point(12, 20);
            this.Datepicker1.Name = "Datepicker1";
            this.Datepicker1.Size = new System.Drawing.Size(237, 36);
            this.Datepicker1.TabIndex = 28;
            this.Datepicker1.Value = new System.DateTime(2017, 12, 14, 20, 3, 6, 397);
            // 
            // Datepicker2
            // 
            this.Datepicker2.BackColor = System.Drawing.Color.SeaGreen;
            this.Datepicker2.BorderRadius = 0;
            this.Datepicker2.ForeColor = System.Drawing.Color.White;
            this.Datepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker2.FormatCustom = null;
            this.Datepicker2.Location = new System.Drawing.Point(12, 77);
            this.Datepicker2.Name = "Datepicker2";
            this.Datepicker2.Size = new System.Drawing.Size(237, 36);
            this.Datepicker2.TabIndex = 29;
            this.Datepicker2.Value = new System.DateTime(2017, 12, 14, 20, 3, 6, 397);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "~";
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 21;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 43;
            this.bunifuTileButton1.LabelText = "Xem tất cả";
            this.bunifuTileButton1.Location = new System.Drawing.Point(736, 6);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(140, 133);
            this.bunifuTileButton1.TabIndex = 32;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton2.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 21;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 43;
            this.bunifuTileButton2.LabelText = "Lưu";
            this.bunifuTileButton2.Location = new System.Drawing.Point(593, 6);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(140, 133);
            this.bunifuTileButton2.TabIndex = 33;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton3.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 21;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 43;
            this.bunifuTileButton3.LabelText = "Xóa";
            this.bunifuTileButton3.Location = new System.Drawing.Point(450, 6);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(140, 133);
            this.bunifuTileButton3.TabIndex = 34;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton4.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 21;
            this.bunifuTileButton4.ImageZoom = 50;
            this.bunifuTileButton4.LabelPosition = 43;
            this.bunifuTileButton4.LabelText = "Tìm kiếm";
            this.bunifuTileButton4.Location = new System.Drawing.Point(307, 6);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(140, 133);
            this.bunifuTileButton4.TabIndex = 44;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // DanhSachBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuTileButton4);
            this.Controls.Add(this.bunifuTileButton3);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datepicker2);
            this.Controls.Add(this.Datepicker1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DanhSachBanHang";
            this.Size = new System.Drawing.Size(883, 488);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomHanghoaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanghoaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource banHangBindingSource;
        private Bunifu.Framework.UI.BunifuDatepicker Datepicker1;
        private Bunifu.Framework.UI.BunifuDatepicker Datepicker2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
    }
}
