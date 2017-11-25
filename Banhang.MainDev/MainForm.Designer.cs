namespace Banhang.MainDev
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.DulieuNenRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.HanghoaRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.HanghoaBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.NhomHanghoaBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.HanghoaBarButtonItem,
            this.NhomHanghoaBarButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.DulieuNenRibbonPage});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(760, 166);
            // 
            // DulieuNenRibbonPage
            // 
            this.DulieuNenRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.HanghoaRibbonPageGroup});
            this.DulieuNenRibbonPage.Image = ((System.Drawing.Image)(resources.GetObject("DulieuNenRibbonPage.Image")));
            this.DulieuNenRibbonPage.Name = "DulieuNenRibbonPage";
            this.DulieuNenRibbonPage.Text = "Dữ liệu nền";
            // 
            // HanghoaRibbonPageGroup
            // 
            this.HanghoaRibbonPageGroup.ItemLinks.Add(this.HanghoaBarButtonItem);
            this.HanghoaRibbonPageGroup.ItemLinks.Add(this.NhomHanghoaBarButtonItem);
            this.HanghoaRibbonPageGroup.Name = "HanghoaRibbonPageGroup";
            this.HanghoaRibbonPageGroup.Text = "Quản lý hàng hóa";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // HanghoaBarButtonItem
            // 
            this.HanghoaBarButtonItem.Caption = "Hàng hóa";
            this.HanghoaBarButtonItem.Id = 1;
            this.HanghoaBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("HanghoaBarButtonItem.LargeGlyph")));
            this.HanghoaBarButtonItem.LargeWidth = 100;
            this.HanghoaBarButtonItem.Name = "HanghoaBarButtonItem";
            this.HanghoaBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HanghoaBarButtonItem_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Hàng hóa";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.LargeWidth = 100;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Hàng hóa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.LargeWidth = 100;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // NhomHanghoaBarButtonItem
            // 
            this.NhomHanghoaBarButtonItem.Caption = "Nhóm hàng hóa";
            this.NhomHanghoaBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("NhomHanghoaBarButtonItem.Glyph")));
            this.NhomHanghoaBarButtonItem.Id = 2;
            this.NhomHanghoaBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("NhomHanghoaBarButtonItem.LargeGlyph")));
            this.NhomHanghoaBarButtonItem.Name = "NhomHanghoaBarButtonItem";
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 479);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage DulieuNenRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup HanghoaRibbonPageGroup;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem HanghoaBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem NhomHanghoaBarButtonItem;
    }
}

