namespace Banhang.MainDevPro
{
    partial class HanghoaDevForm
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
            System.Windows.Forms.Label giaBanLabel;
            System.Windows.Forms.Label hanghoaIdLabel;
            System.Windows.Forms.Label motaLabel;
            System.Windows.Forms.Label nhomHanghoaIdLabel;
            System.Windows.Forms.Label soLuongTonKhoLabel;
            System.Windows.Forms.Label tenHanghoaLabel;
            this.productGridControl = new DevExpress.XtraGrid.GridControl();
            this.hanghoaBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colrecid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHanghoaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHanghoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongTonKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhomHanghoaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.giaBanSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.hanghoaIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.motaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nhomHanghoaIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.soLuongTonKhoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tenHanghoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            giaBanLabel = new System.Windows.Forms.Label();
            hanghoaIdLabel = new System.Windows.Forms.Label();
            motaLabel = new System.Windows.Forms.Label();
            nhomHanghoaIdLabel = new System.Windows.Forms.Label();
            soLuongTonKhoLabel = new System.Windows.Forms.Label();
            tenHanghoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaBanSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongTonKhoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHanghoaTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.Location = new System.Drawing.Point(22, 39);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(47, 13);
            giaBanLabel.TabIndex = 0;
            giaBanLabel.Text = "Giá bán:";
            // 
            // hanghoaIdLabel
            // 
            hanghoaIdLabel.AutoSize = true;
            hanghoaIdLabel.Location = new System.Drawing.Point(22, 65);
            hanghoaIdLabel.Name = "hanghoaIdLabel";
            hanghoaIdLabel.Size = new System.Drawing.Size(52, 13);
            hanghoaIdLabel.TabIndex = 2;
            hanghoaIdLabel.Text = "Mã hàng:";
            // 
            // motaLabel
            // 
            motaLabel.AutoSize = true;
            motaLabel.Location = new System.Drawing.Point(22, 91);
            motaLabel.Name = "motaLabel";
            motaLabel.Size = new System.Drawing.Size(38, 13);
            motaLabel.TabIndex = 4;
            motaLabel.Text = "Mô tả:";
            // 
            // nhomHanghoaIdLabel
            // 
            nhomHanghoaIdLabel.AutoSize = true;
            nhomHanghoaIdLabel.Location = new System.Drawing.Point(211, 101);
            nhomHanghoaIdLabel.Name = "nhomHanghoaIdLabel";
            nhomHanghoaIdLabel.Size = new System.Drawing.Size(65, 13);
            nhomHanghoaIdLabel.TabIndex = 6;
            nhomHanghoaIdLabel.Text = "Nhóm hàng:";
            // 
            // soLuongTonKhoLabel
            // 
            soLuongTonKhoLabel.AutoSize = true;
            soLuongTonKhoLabel.Location = new System.Drawing.Point(211, 35);
            soLuongTonKhoLabel.Name = "soLuongTonKhoLabel";
            soLuongTonKhoLabel.Size = new System.Drawing.Size(53, 13);
            soLuongTonKhoLabel.TabIndex = 10;
            soLuongTonKhoLabel.Text = "Số lượng:";
            // 
            // tenHanghoaLabel
            // 
            tenHanghoaLabel.AutoSize = true;
            tenHanghoaLabel.Location = new System.Drawing.Point(211, 61);
            tenHanghoaLabel.Name = "tenHanghoaLabel";
            tenHanghoaLabel.Size = new System.Drawing.Size(56, 13);
            tenHanghoaLabel.TabIndex = 12;
            tenHanghoaLabel.Text = "Tên hàng:";
            // 
            // productGridControl
            // 
            this.productGridControl.DataSource = this.hanghoaBindingSource;
            this.productGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridControl.Location = new System.Drawing.Point(0, 160);
            this.productGridControl.MainView = this.gridView1;
            this.productGridControl.Name = "productGridControl";
            this.productGridControl.Size = new System.Drawing.Size(736, 369);
            this.productGridControl.TabIndex = 1;
            this.productGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hanghoaBindingSource
            // 
            this.hanghoaBindingSource.DataSource = typeof(Banhang.Domain.HanghoaHandler.Hanghoa);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colrecid,
            this.colHanghoaId,
            this.colTenHanghoa,
            this.colGiaBan,
            this.colMota,
            this.colSoLuongTonKho,
            this.colNhomHanghoaId});
            this.gridView1.GridControl = this.productGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colrecid
            // 
            this.colrecid.FieldName = "recid";
            this.colrecid.Name = "colrecid";
            this.colrecid.OptionsColumn.ReadOnly = true;
            this.colrecid.Visible = true;
            this.colrecid.VisibleIndex = 0;
            // 
            // colHanghoaId
            // 
            this.colHanghoaId.FieldName = "HanghoaId";
            this.colHanghoaId.Name = "colHanghoaId";
            this.colHanghoaId.Visible = true;
            this.colHanghoaId.VisibleIndex = 1;
            // 
            // colTenHanghoa
            // 
            this.colTenHanghoa.FieldName = "TenHanghoa";
            this.colTenHanghoa.Name = "colTenHanghoa";
            this.colTenHanghoa.Visible = true;
            this.colTenHanghoa.VisibleIndex = 2;
            // 
            // colGiaBan
            // 
            this.colGiaBan.FieldName = "GiaBan";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.Visible = true;
            this.colGiaBan.VisibleIndex = 3;
            // 
            // colMota
            // 
            this.colMota.FieldName = "Mota";
            this.colMota.Name = "colMota";
            this.colMota.Visible = true;
            this.colMota.VisibleIndex = 4;
            // 
            // colSoLuongTonKho
            // 
            this.colSoLuongTonKho.FieldName = "SoLuongTonKho";
            this.colSoLuongTonKho.Name = "colSoLuongTonKho";
            this.colSoLuongTonKho.Visible = true;
            this.colSoLuongTonKho.VisibleIndex = 5;
            // 
            // colNhomHanghoaId
            // 
            this.colNhomHanghoaId.FieldName = "NhomHanghoaId";
            this.colNhomHanghoaId.Name = "colNhomHanghoaId";
            this.colNhomHanghoaId.Visible = true;
            this.colNhomHanghoaId.VisibleIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(giaBanLabel);
            this.groupControl1.Controls.Add(this.giaBanSpinEdit);
            this.groupControl1.Controls.Add(hanghoaIdLabel);
            this.groupControl1.Controls.Add(this.hanghoaIdTextEdit);
            this.groupControl1.Controls.Add(motaLabel);
            this.groupControl1.Controls.Add(this.motaTextEdit);
            this.groupControl1.Controls.Add(nhomHanghoaIdLabel);
            this.groupControl1.Controls.Add(this.nhomHanghoaIdTextEdit);
            this.groupControl1.Controls.Add(soLuongTonKhoLabel);
            this.groupControl1.Controls.Add(this.soLuongTonKhoSpinEdit);
            this.groupControl1.Controls.Add(tenHanghoaLabel);
            this.groupControl1.Controls.Add(this.tenHanghoaTextEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(736, 160);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin chi tiết";
            // 
            // giaBanSpinEdit
            // 
            this.giaBanSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaBindingSource, "GiaBan", true));
            this.giaBanSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.giaBanSpinEdit.Location = new System.Drawing.Point(93, 36);
            this.giaBanSpinEdit.Name = "giaBanSpinEdit";
            this.giaBanSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.giaBanSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.giaBanSpinEdit.TabIndex = 1;
            // 
            // hanghoaIdTextEdit
            // 
            this.hanghoaIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaBindingSource, "HanghoaId", true));
            this.hanghoaIdTextEdit.Location = new System.Drawing.Point(93, 62);
            this.hanghoaIdTextEdit.Name = "hanghoaIdTextEdit";
            this.hanghoaIdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.hanghoaIdTextEdit.TabIndex = 3;
            // 
            // motaTextEdit
            // 
            this.motaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaBindingSource, "Mota", true));
            this.motaTextEdit.Location = new System.Drawing.Point(93, 88);
            this.motaTextEdit.Name = "motaTextEdit";
            this.motaTextEdit.Size = new System.Drawing.Size(100, 20);
            this.motaTextEdit.TabIndex = 5;
            // 
            // nhomHanghoaIdTextEdit
            // 
            this.nhomHanghoaIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaBindingSource, "NhomHanghoaId", true));
            this.nhomHanghoaIdTextEdit.Location = new System.Drawing.Point(282, 98);
            this.nhomHanghoaIdTextEdit.Name = "nhomHanghoaIdTextEdit";
            this.nhomHanghoaIdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nhomHanghoaIdTextEdit.TabIndex = 7;
            // 
            // soLuongTonKhoSpinEdit
            // 
            this.soLuongTonKhoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaBindingSource, "SoLuongTonKho", true));
            this.soLuongTonKhoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soLuongTonKhoSpinEdit.Location = new System.Drawing.Point(282, 32);
            this.soLuongTonKhoSpinEdit.Name = "soLuongTonKhoSpinEdit";
            this.soLuongTonKhoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soLuongTonKhoSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.soLuongTonKhoSpinEdit.TabIndex = 11;
            // 
            // tenHanghoaTextEdit
            // 
            this.tenHanghoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaBindingSource, "TenHanghoa", true));
            this.tenHanghoaTextEdit.Location = new System.Drawing.Point(282, 58);
            this.tenHanghoaTextEdit.Name = "tenHanghoaTextEdit";
            this.tenHanghoaTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenHanghoaTextEdit.TabIndex = 13;
            // 
            // HanghoaDevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 529);
            this.Controls.Add(this.productGridControl);
            this.Controls.Add(this.groupControl1);
            this.Name = "HanghoaDevForm";
            this.Text = "HanghoaDevForm";
            this.Load += new System.EventHandler(this.HanghoaDevForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaBanSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongTonKhoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHanghoaTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl productGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource hanghoaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colrecid;
        private DevExpress.XtraGrid.Columns.GridColumn colHanghoaId;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHanghoa;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn colMota;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongTonKho;
        private DevExpress.XtraGrid.Columns.GridColumn colNhomHanghoaId;
        private DevExpress.XtraEditors.SpinEdit giaBanSpinEdit;
        private DevExpress.XtraEditors.TextEdit hanghoaIdTextEdit;
        private DevExpress.XtraEditors.TextEdit motaTextEdit;
        private DevExpress.XtraEditors.TextEdit nhomHanghoaIdTextEdit;
        private DevExpress.XtraEditors.SpinEdit soLuongTonKhoSpinEdit;
        private DevExpress.XtraEditors.TextEdit tenHanghoaTextEdit;
    }
}