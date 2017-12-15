namespace dashboard
{
    partial class ThuChiTabList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThuChiTabList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SlidePanelRight = new System.Windows.Forms.Panel();
            this.SlidePanelLeft = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.btnInfoStaff = new System.Windows.Forms.Button();
            this.PanelThongKeThuChi = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SlidePanelRight);
            this.panel1.Controls.Add(this.SlidePanelLeft);
            this.panel1.Controls.Add(this.btnList);
            this.panel1.Controls.Add(this.btnInfoStaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 55);
            this.panel1.TabIndex = 1;
            // 
            // SlidePanelRight
            // 
            this.SlidePanelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SlidePanelRight.Location = new System.Drawing.Point(217, 45);
            this.SlidePanelRight.Name = "SlidePanelRight";
            this.SlidePanelRight.Size = new System.Drawing.Size(183, 10);
            this.SlidePanelRight.TabIndex = 3;
            // 
            // SlidePanelLeft
            // 
            this.SlidePanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SlidePanelLeft.Location = new System.Drawing.Point(25, 45);
            this.SlidePanelLeft.Name = "SlidePanelLeft";
            this.SlidePanelLeft.Size = new System.Drawing.Size(186, 10);
            this.SlidePanelLeft.TabIndex = 2;
            // 
            // btnList
            // 
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(217, 3);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(183, 42);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Xem biểu đồ thu chi";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnInfoStaff
            // 
            this.btnInfoStaff.FlatAppearance.BorderSize = 0;
            this.btnInfoStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoStaff.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoStaff.ForeColor = System.Drawing.Color.White;
            this.btnInfoStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoStaff.Image")));
            this.btnInfoStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoStaff.Location = new System.Drawing.Point(25, 3);
            this.btnInfoStaff.Name = "btnInfoStaff";
            this.btnInfoStaff.Size = new System.Drawing.Size(186, 42);
            this.btnInfoStaff.TabIndex = 0;
            this.btnInfoStaff.Text = "Bảng thống kê thu chi";
            this.btnInfoStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfoStaff.UseVisualStyleBackColor = true;
            this.btnInfoStaff.Click += new System.EventHandler(this.btnInfoStaff_Click);
            // 
            // PanelThongKeThuChi
            // 
            this.PanelThongKeThuChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelThongKeThuChi.Location = new System.Drawing.Point(0, 55);
            this.PanelThongKeThuChi.Name = "PanelThongKeThuChi";
            this.PanelThongKeThuChi.Size = new System.Drawing.Size(883, 488);
            this.PanelThongKeThuChi.TabIndex = 2;
            // 
            // ThuChiTabList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelThongKeThuChi);
            this.Controls.Add(this.panel1);
            this.Name = "ThuChiTabList";
            this.Size = new System.Drawing.Size(883, 543);
            this.Load += new System.EventHandler(this.ThuChiTabList_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SlidePanelRight;
        private System.Windows.Forms.Panel SlidePanelLeft;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnInfoStaff;
        private System.Windows.Forms.Panel PanelThongKeThuChi;
    }
}
