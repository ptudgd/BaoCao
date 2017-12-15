namespace dashboard
{
    partial class BieuDoThuChiControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BieuDoThuChiControl));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BieuDoThuChi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.thuChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoThuChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuChiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BieuDoThuChi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // datepicker
            // 
            this.datepicker.BackColor = System.Drawing.Color.SeaGreen;
            this.datepicker.BorderRadius = 0;
            this.datepicker.ForeColor = System.Drawing.Color.White;
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepicker.FormatCustom = null;
            this.datepicker.Location = new System.Drawing.Point(3, 12);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(303, 36);
            this.datepicker.TabIndex = 1;
            this.datepicker.Value = new System.DateTime(2017, 12, 16, 2, 20, 53, 605);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Tìm kiếm";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(314, 12);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 2;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // BieuDoThuChi
            // 
            chartArea1.Name = "ChartArea1";
            this.BieuDoThuChi.ChartAreas.Add(chartArea1);
            this.BieuDoThuChi.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.BieuDoThuChi.Legends.Add(legend1);
            this.BieuDoThuChi.Location = new System.Drawing.Point(3, 16);
            this.BieuDoThuChi.Name = "BieuDoThuChi";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Thu";
            series1.XValueMember = "Ngay";
            series1.YValueMembers = "Thu";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Chi";
            series2.XValueMember = "Ngay";
            series2.YValueMembers = "Chi";
            this.BieuDoThuChi.Series.Add(series1);
            this.BieuDoThuChi.Series.Add(series2);
            this.BieuDoThuChi.Size = new System.Drawing.Size(877, 407);
            this.BieuDoThuChi.TabIndex = 0;
            this.BieuDoThuChi.Text = "chart1";
            // 
            // thuChiBindingSource
            // 
            this.thuChiBindingSource.DataSource = typeof(ThuChi.Domain.ThuChi);
            // 
            // BieuDoThuChiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.groupBox1);
            this.Name = "BieuDoThuChiControl";
            this.Size = new System.Drawing.Size(883, 488);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoThuChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuChiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDoThuChi;
        private System.Windows.Forms.BindingSource thuChiBindingSource;
        private Bunifu.Framework.UI.BunifuDatepicker datepicker;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}
