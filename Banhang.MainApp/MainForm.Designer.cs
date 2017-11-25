namespace Banhang.MainApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hanghoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banhangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hanghoaToolStripMenuItem,
            this.banhangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hanghoaToolStripMenuItem
            // 
            this.hanghoaToolStripMenuItem.Name = "hanghoaToolStripMenuItem";
            this.hanghoaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hanghoaToolStripMenuItem.Text = "Hàng hóa";
            this.hanghoaToolStripMenuItem.Click += new System.EventHandler(this.hanghoaToolStripMenuItem_Click);
            // 
            // banhangToolStripMenuItem
            // 
            this.banhangToolStripMenuItem.Name = "banhangToolStripMenuItem";
            this.banhangToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.banhangToolStripMenuItem.Text = "Bán hàng";
            this.banhangToolStripMenuItem.Click += new System.EventHandler(this.banhangToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 385);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hanghoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banhangToolStripMenuItem;
    }
}