namespace dashboard
{
    partial class NhanVienTabList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienTabList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelPhieuBanHang = new System.Windows.Forms.Panel();
            this.btnPhieuBanHang = new System.Windows.Forms.Button();
            this.SlidePanelRight = new System.Windows.Forms.Panel();
            this.SlidePanelLeft = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.btnInfoStaff = new System.Windows.Forms.Button();
            this.PanelStaff = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.PanelPhieuBanHang);
            this.panel1.Controls.Add(this.btnPhieuBanHang);
            this.panel1.Controls.Add(this.SlidePanelRight);
            this.panel1.Controls.Add(this.SlidePanelLeft);
            this.panel1.Controls.Add(this.btnList);
            this.panel1.Controls.Add(this.btnInfoStaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 55);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PanelPhieuBanHang
            // 
            this.PanelPhieuBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.PanelPhieuBanHang.Location = new System.Drawing.Point(463, 45);
            this.PanelPhieuBanHang.Name = "PanelPhieuBanHang";
            this.PanelPhieuBanHang.Size = new System.Drawing.Size(160, 10);
            this.PanelPhieuBanHang.TabIndex = 4;
            // 
            // btnPhieuBanHang
            // 
            this.btnPhieuBanHang.FlatAppearance.BorderSize = 0;
            this.btnPhieuBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuBanHang.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuBanHang.ForeColor = System.Drawing.Color.White;
            this.btnPhieuBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuBanHang.Image")));
            this.btnPhieuBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuBanHang.Location = new System.Drawing.Point(463, 3);
            this.btnPhieuBanHang.Name = "btnPhieuBanHang";
            this.btnPhieuBanHang.Size = new System.Drawing.Size(160, 42);
            this.btnPhieuBanHang.TabIndex = 4;
            this.btnPhieuBanHang.Text = "Phiếu bán hàng";
            this.btnPhieuBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhieuBanHang.UseVisualStyleBackColor = true;
            this.btnPhieuBanHang.Click += new System.EventHandler(this.btnPhieuBanHang_Click);
            // 
            // SlidePanelRight
            // 
            this.SlidePanelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SlidePanelRight.Location = new System.Drawing.Point(217, 45);
            this.SlidePanelRight.Name = "SlidePanelRight";
            this.SlidePanelRight.Size = new System.Drawing.Size(240, 10);
            this.SlidePanelRight.TabIndex = 3;
            // 
            // SlidePanelLeft
            // 
            this.SlidePanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SlidePanelLeft.Location = new System.Drawing.Point(25, 45);
            this.SlidePanelLeft.Name = "SlidePanelLeft";
            this.SlidePanelLeft.Size = new System.Drawing.Size(186, 10);
            this.SlidePanelLeft.TabIndex = 2;
            this.SlidePanelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.SlidePanelLeft_Paint);
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
            this.btnList.Size = new System.Drawing.Size(240, 42);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "       Danh sách phiếu bán hàng";
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
            this.btnInfoStaff.Text = "          Thông tin nhân viên";
            this.btnInfoStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfoStaff.UseVisualStyleBackColor = true;
            this.btnInfoStaff.Click += new System.EventHandler(this.btnInfoStaff_Click);
            // 
            // PanelStaff
            // 
            this.PanelStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelStaff.Location = new System.Drawing.Point(0, 55);
            this.PanelStaff.Name = "PanelStaff";
            this.PanelStaff.Size = new System.Drawing.Size(883, 488);
            this.PanelStaff.TabIndex = 1;
            this.PanelStaff.Paint += new System.Windows.Forms.PaintEventHandler(this.SlidePanelStaff_Paint);
            // 
            // NhanVienTabList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelStaff);
            this.Controls.Add(this.panel1);
            this.Name = "NhanVienTabList";
            this.Size = new System.Drawing.Size(883, 543);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SlidePanelLeft;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnInfoStaff;
        private System.Windows.Forms.Panel PanelStaff;
        private System.Windows.Forms.Panel SlidePanelRight;
        private System.Windows.Forms.Panel PanelPhieuBanHang;
        private System.Windows.Forms.Button btnPhieuBanHang;
    }
}
