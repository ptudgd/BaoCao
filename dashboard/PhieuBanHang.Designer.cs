namespace dashboard
{
    partial class PhieuBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuBanHang));
            this.cbbNhomHangHoa = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbbHangHoa = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PhieuBanHangDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.banHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelPhieuBanHang = new System.Windows.Forms.Panel();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.tenSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giabanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomHanghoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanghoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuBanHangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangBindingSource)).BeginInit();
            this.PanelPhieuBanHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbNhomHangHoa
            // 
            this.cbbNhomHangHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhomHangHoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNhomHangHoa.FormattingEnabled = true;
            this.cbbNhomHangHoa.Location = new System.Drawing.Point(19, 19);
            this.cbbNhomHangHoa.Name = "cbbNhomHangHoa";
            this.cbbNhomHangHoa.Size = new System.Drawing.Size(244, 27);
            this.cbbNhomHangHoa.TabIndex = 0;
            this.cbbNhomHangHoa.SelectedIndexChanged += new System.EventHandler(this.cbbNhomHangHoa_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuTileButton4);
            this.groupBox1.Controls.Add(this.bunifuTileButton3);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.bunifuTileButton2);
            this.groupBox1.Controls.Add(this.bunifuTileButton1);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.cbbHangHoa);
            this.groupBox1.Controls.Add(this.cbbNhomHangHoa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoLuong.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoLuong.HintText = "";
            this.txtSoLuong.isPassword = false;
            this.txtSoLuong.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSoLuong.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSoLuong.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSoLuong.LineThickness = 3;
            this.txtSoLuong.Location = new System.Drawing.Point(111, 91);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(186, 30);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(19, 128);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(168, 20);
            this.txtGiaBan.TabIndex = 6;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton2.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "Bán hàng";
            this.bunifuTileButton2.Location = new System.Drawing.Point(597, 6);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(134, 153);
            this.bunifuTileButton2.TabIndex = 5;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "In hóa đơn";
            this.bunifuTileButton1.Location = new System.Drawing.Point(743, 6);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(134, 153);
            this.bunifuTileButton1.TabIndex = 4;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Brown;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(17, 97);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(87, 22);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Số lượng";
            // 
            // cbbHangHoa
            // 
            this.cbbHangHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHangHoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHangHoa.FormattingEnabled = true;
            this.cbbHangHoa.Location = new System.Drawing.Point(19, 54);
            this.cbbHangHoa.Name = "cbbHangHoa";
            this.cbbHangHoa.Size = new System.Drawing.Size(244, 27);
            this.cbbHangHoa.TabIndex = 1;
            this.cbbHangHoa.SelectedIndexChanged += new System.EventHandler(this.cbbHangHoa_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(883, 467);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // PhieuBanHangDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PhieuBanHangDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PhieuBanHangDataGridView.AutoGenerateColumns = false;
            this.PhieuBanHangDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PhieuBanHangDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.PhieuBanHangDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhieuBanHangDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhieuBanHangDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PhieuBanHangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhieuBanHangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSanPhamDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giabanDataGridViewTextBoxColumn,
            this.ngayBanDataGridViewTextBoxColumn,
            this.nhomHanghoaIdDataGridViewTextBoxColumn,
            this.hanghoaIdDataGridViewTextBoxColumn});
            this.PhieuBanHangDataGridView.DataSource = this.banHangBindingSource;
            this.PhieuBanHangDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PhieuBanHangDataGridView.DoubleBuffered = true;
            this.PhieuBanHangDataGridView.EnableHeadersVisualStyles = false;
            this.PhieuBanHangDataGridView.HeaderBgColor = System.Drawing.Color.DimGray;
            this.PhieuBanHangDataGridView.HeaderForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.PhieuBanHangDataGridView.Location = new System.Drawing.Point(0, 168);
            this.PhieuBanHangDataGridView.Name = "PhieuBanHangDataGridView";
            this.PhieuBanHangDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PhieuBanHangDataGridView.Size = new System.Drawing.Size(883, 320);
            this.PhieuBanHangDataGridView.TabIndex = 0;
            // 
            // banHangBindingSource
            // 
            this.banHangBindingSource.DataSource = typeof(BanHang.Domain.BanHang);
            // 
            // PanelPhieuBanHang
            // 
            this.PanelPhieuBanHang.Controls.Add(this.groupBox1);
            this.PanelPhieuBanHang.Controls.Add(this.PhieuBanHangDataGridView);
            this.PanelPhieuBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPhieuBanHang.Location = new System.Drawing.Point(0, 0);
            this.PanelPhieuBanHang.Name = "PanelPhieuBanHang";
            this.PanelPhieuBanHang.Size = new System.Drawing.Size(883, 488);
            this.PanelPhieuBanHang.TabIndex = 3;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataSource = typeof(HangHoa.Domain.HangHoa);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton3.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "Hủy";
            this.bunifuTileButton3.Location = new System.Drawing.Point(305, 6);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(134, 153);
            this.bunifuTileButton3.TabIndex = 8;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton4.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 20;
            this.bunifuTileButton4.ImageZoom = 50;
            this.bunifuTileButton4.LabelPosition = 41;
            this.bunifuTileButton4.LabelText = "Xóa";
            this.bunifuTileButton4.Location = new System.Drawing.Point(451, 6);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(134, 153);
            this.bunifuTileButton4.TabIndex = 9;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
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
            // PhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelPhieuBanHang);
            this.Controls.Add(this.groupBox2);
            this.Name = "PhieuBanHang";
            this.Size = new System.Drawing.Size(883, 488);
            this.Load += new System.EventHandler(this.PhieuBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuBanHangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangBindingSource)).EndInit();
            this.PanelPhieuBanHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbNhomHangHoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbHangHoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid PhieuBanHangDataGridView;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.BindingSource banHangBindingSource;
        private System.Windows.Forms.TextBox txtGiaBan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSoLuong;
        private System.Windows.Forms.Panel PanelPhieuBanHang;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomHanghoaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanghoaIdDataGridViewTextBoxColumn;
    }
}
