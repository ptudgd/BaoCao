namespace dashboard
{
    partial class BangThongKeThuChiControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangThongKeThuChiControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Datepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.banHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuChiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuCustomDataGrid2);
            this.groupBox1.Controls.Add(this.bunifuCustomDataGrid1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 340);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.bunifuCustomDataGrid2.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayDataGridViewTextBoxColumn,
            this.thuDataGridViewTextBoxColumn,
            this.chiDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid2.DataSource = this.thuChiBindingSource;
            this.bunifuCustomDataGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.DimGray;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.LightYellow;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(3, 16);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(877, 321);
            this.bunifuCustomDataGrid2.TabIndex = 1;
            // 
            // ngayDataGridViewTextBoxColumn
            // 
            this.ngayDataGridViewTextBoxColumn.DataPropertyName = "Ngay";
            this.ngayDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.ngayDataGridViewTextBoxColumn.Name = "ngayDataGridViewTextBoxColumn";
            // 
            // thuDataGridViewTextBoxColumn
            // 
            this.thuDataGridViewTextBoxColumn.DataPropertyName = "Thu";
            this.thuDataGridViewTextBoxColumn.HeaderText = "Thu";
            this.thuDataGridViewTextBoxColumn.Name = "thuDataGridViewTextBoxColumn";
            // 
            // chiDataGridViewTextBoxColumn
            // 
            this.chiDataGridViewTextBoxColumn.DataPropertyName = "Chi";
            this.chiDataGridViewTextBoxColumn.HeaderText = "Chi";
            this.chiDataGridViewTextBoxColumn.Name = "chiDataGridViewTextBoxColumn";
            // 
            // thuChiBindingSource
            // 
            this.thuChiBindingSource.DataSource = typeof(ThuChi.Domain.ThuChi);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.bunifuTileButton3.Location = new System.Drawing.Point(450, 3);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(140, 133);
            this.bunifuTileButton3.TabIndex = 42;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton2.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Enabled = false;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 21;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 43;
            this.bunifuTileButton2.LabelText = "Lưu";
            this.bunifuTileButton2.Location = new System.Drawing.Point(593, 3);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(140, 133);
            this.bunifuTileButton2.TabIndex = 41;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Enabled = false;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 21;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 43;
            this.bunifuTileButton1.LabelText = "Xem tất cả";
            this.bunifuTileButton1.Location = new System.Drawing.Point(736, 3);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(140, 133);
            this.bunifuTileButton1.TabIndex = 40;
            // 
            // Datepicker1
            // 
            this.Datepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.Datepicker1.BorderRadius = 0;
            this.Datepicker1.ForeColor = System.Drawing.Color.White;
            this.Datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker1.FormatCustom = null;
            this.Datepicker1.Location = new System.Drawing.Point(12, 42);
            this.Datepicker1.Name = "Datepicker1";
            this.Datepicker1.Size = new System.Drawing.Size(237, 36);
            this.Datepicker1.TabIndex = 36;
            this.Datepicker1.Value = new System.DateTime(2017, 12, 14, 20, 3, 6, 397);
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
            this.bunifuTileButton4.Location = new System.Drawing.Point(307, 3);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(140, 133);
            this.bunifuTileButton4.TabIndex = 43;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // banHangBindingSource
            // 
            this.banHangBindingSource.DataSource = typeof(BanHang.Domain.BanHang);
            // 
            // BangThongKeThuChiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuTileButton4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuTileButton3);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.Datepicker1);
            this.Name = "BangThongKeThuChiControl";
            this.Size = new System.Drawing.Size(883, 488);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuChiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.BindingSource banHangBindingSource;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuDatepicker Datepicker1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource thuChiBindingSource;
    }
}
