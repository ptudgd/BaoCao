namespace HangHoaForm
{
    partial class frmHangHoa
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
            System.Windows.Forms.Label ghiChuLabel;
            System.Windows.Forms.Label nhomHanghoaIdLabel1;
            System.Windows.Forms.Label tenNhomHanghoaLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hanghoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHanghoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomHanghoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.giaBanTextBox = new System.Windows.Forms.TextBox();
            this.hanghoaIdTextBox = new System.Windows.Forms.TextBox();
            this.motaTextBox = new System.Windows.Forms.TextBox();
            this.nhomHanghoaIdTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTonKhoTextBox = new System.Windows.Forms.TextBox();
            this.tenHanghoaTextBox = new System.Windows.Forms.TextBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nhomHangHoaDataGridView = new System.Windows.Forms.DataGridView();
            this.tenNhomHanghoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomHanghoaIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomHangHoaBindingSource = new System.Windows.Forms.BindingSource();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ghiChuTextBox = new System.Windows.Forms.TextBox();
            this.nhomHanghoaIdTextBox1 = new System.Windows.Forms.TextBox();
            this.tenNhomHanghoaTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            giaBanLabel = new System.Windows.Forms.Label();
            hanghoaIdLabel = new System.Windows.Forms.Label();
            motaLabel = new System.Windows.Forms.Label();
            nhomHanghoaIdLabel = new System.Windows.Forms.Label();
            soLuongTonKhoLabel = new System.Windows.Forms.Label();
            tenHanghoaLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            nhomHanghoaIdLabel1 = new System.Windows.Forms.Label();
            tenNhomHanghoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHangHoaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHangHoaBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.Location = new System.Drawing.Point(12, 28);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(47, 13);
            giaBanLabel.TabIndex = 13;
            giaBanLabel.Text = "Giá bán:";
            // 
            // hanghoaIdLabel
            // 
            hanghoaIdLabel.AutoSize = true;
            hanghoaIdLabel.Location = new System.Drawing.Point(12, 54);
            hanghoaIdLabel.Name = "hanghoaIdLabel";
            hanghoaIdLabel.Size = new System.Drawing.Size(73, 13);
            hanghoaIdLabel.TabIndex = 15;
            hanghoaIdLabel.Text = "Mã hàng hóa:";
            // 
            // motaLabel
            // 
            motaLabel.AutoSize = true;
            motaLabel.Location = new System.Drawing.Point(12, 80);
            motaLabel.Name = "motaLabel";
            motaLabel.Size = new System.Drawing.Size(37, 13);
            motaLabel.TabIndex = 17;
            motaLabel.Text = "Mô tả:";
            // 
            // nhomHanghoaIdLabel
            // 
            nhomHanghoaIdLabel.AutoSize = true;
            nhomHanghoaIdLabel.Location = new System.Drawing.Point(12, 106);
            nhomHanghoaIdLabel.Name = "nhomHanghoaIdLabel";
            nhomHanghoaIdLabel.Size = new System.Drawing.Size(102, 13);
            nhomHanghoaIdLabel.TabIndex = 19;
            nhomHanghoaIdLabel.Text = "Mã nhóm hàng hóa:";
            // 
            // soLuongTonKhoLabel
            // 
            soLuongTonKhoLabel.AutoSize = true;
            soLuongTonKhoLabel.Location = new System.Drawing.Point(12, 132);
            soLuongTonKhoLabel.Name = "soLuongTonKhoLabel";
            soLuongTonKhoLabel.Size = new System.Drawing.Size(91, 13);
            soLuongTonKhoLabel.TabIndex = 21;
            soLuongTonKhoLabel.Text = "Số lượng tồn kho:";
            // 
            // tenHanghoaLabel
            // 
            tenHanghoaLabel.AutoSize = true;
            tenHanghoaLabel.Location = new System.Drawing.Point(12, 158);
            tenHanghoaLabel.Name = "tenHanghoaLabel";
            tenHanghoaLabel.Size = new System.Drawing.Size(77, 13);
            tenHanghoaLabel.TabIndex = 23;
            tenHanghoaLabel.Text = "Tên hàng hóa:";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ghiChuLabel.Location = new System.Drawing.Point(9, 116);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(66, 16);
            ghiChuLabel.TabIndex = 5;
            ghiChuLabel.Text = "Ghi chú:";
            // 
            // nhomHanghoaIdLabel1
            // 
            nhomHanghoaIdLabel1.AutoSize = true;
            nhomHanghoaIdLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nhomHanghoaIdLabel1.Location = new System.Drawing.Point(9, 62);
            nhomHanghoaIdLabel1.Name = "nhomHanghoaIdLabel1";
            nhomHanghoaIdLabel1.Size = new System.Drawing.Size(147, 16);
            nhomHanghoaIdLabel1.TabIndex = 7;
            nhomHanghoaIdLabel1.Text = "Mã nhóm hàng hóa:";
            // 
            // tenNhomHanghoaLabel
            // 
            tenNhomHanghoaLabel.AutoSize = true;
            tenNhomHanghoaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenNhomHanghoaLabel.Location = new System.Drawing.Point(9, 88);
            tenNhomHanghoaLabel.Name = "tenNhomHanghoaLabel";
            tenNhomHanghoaLabel.Size = new System.Drawing.Size(152, 16);
            tenNhomHanghoaLabel.TabIndex = 9;
            tenNhomHanghoaLabel.Text = "Tên nhóm hàng hóa:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hanghoaIdDataGridViewTextBoxColumn,
            this.tenHanghoaDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.motaDataGridViewTextBoxColumn,
            this.soLuongTonKhoDataGridViewTextBoxColumn,
            this.nhomHanghoaIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hangHoaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CursorChanged += new System.EventHandler(this.dataGridView1_CursorChanged);
            // 
            // hanghoaIdDataGridViewTextBoxColumn
            // 
            this.hanghoaIdDataGridViewTextBoxColumn.DataPropertyName = "HanghoaId";
            this.hanghoaIdDataGridViewTextBoxColumn.HeaderText = "Mã hàng hóa";
            this.hanghoaIdDataGridViewTextBoxColumn.Name = "hanghoaIdDataGridViewTextBoxColumn";
            // 
            // tenHanghoaDataGridViewTextBoxColumn
            // 
            this.tenHanghoaDataGridViewTextBoxColumn.DataPropertyName = "TenHanghoa";
            this.tenHanghoaDataGridViewTextBoxColumn.HeaderText = "Tên hàng hóa";
            this.tenHanghoaDataGridViewTextBoxColumn.Name = "tenHanghoaDataGridViewTextBoxColumn";
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "Giá bán";
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            // 
            // motaDataGridViewTextBoxColumn
            // 
            this.motaDataGridViewTextBoxColumn.DataPropertyName = "Mota";
            this.motaDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.motaDataGridViewTextBoxColumn.Name = "motaDataGridViewTextBoxColumn";
            // 
            // soLuongTonKhoDataGridViewTextBoxColumn
            // 
            this.soLuongTonKhoDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTonKho";
            this.soLuongTonKhoDataGridViewTextBoxColumn.HeaderText = "Số lượng tồn kho";
            this.soLuongTonKhoDataGridViewTextBoxColumn.Name = "soLuongTonKhoDataGridViewTextBoxColumn";
            // 
            // nhomHanghoaIdDataGridViewTextBoxColumn
            // 
            this.nhomHanghoaIdDataGridViewTextBoxColumn.DataPropertyName = "NhomHanghoaId";
            this.nhomHanghoaIdDataGridViewTextBoxColumn.HeaderText = "Mã nhóm hàng hóa";
            this.nhomHanghoaIdDataGridViewTextBoxColumn.Name = "nhomHanghoaIdDataGridViewTextBoxColumn";
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataSource = typeof(HangHoa.Domain.HangHoa);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 311);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(494, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 53);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Lưu";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(386, 60);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 53);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(602, 60);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 53);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Tải dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(giaBanLabel);
            this.groupBox1.Controls.Add(this.giaBanTextBox);
            this.groupBox1.Controls.Add(hanghoaIdLabel);
            this.groupBox1.Controls.Add(this.hanghoaIdTextBox);
            this.groupBox1.Controls.Add(motaLabel);
            this.groupBox1.Controls.Add(this.motaTextBox);
            this.groupBox1.Controls.Add(nhomHanghoaIdLabel);
            this.groupBox1.Controls.Add(this.nhomHanghoaIdTextBox);
            this.groupBox1.Controls.Add(soLuongTonKhoLabel);
            this.groupBox1.Controls.Add(this.soLuongTonKhoTextBox);
            this.groupBox1.Controls.Add(tenHanghoaLabel);
            this.groupBox1.Controls.Add(this.tenHanghoaTextBox);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hàng hóa";
            // 
            // giaBanTextBox
            // 
            this.giaBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "GiaBan", true));
            this.giaBanTextBox.Location = new System.Drawing.Point(120, 25);
            this.giaBanTextBox.Name = "giaBanTextBox";
            this.giaBanTextBox.Size = new System.Drawing.Size(153, 20);
            this.giaBanTextBox.TabIndex = 14;
            // 
            // hanghoaIdTextBox
            // 
            this.hanghoaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "HanghoaId", true));
            this.hanghoaIdTextBox.Location = new System.Drawing.Point(120, 51);
            this.hanghoaIdTextBox.Name = "hanghoaIdTextBox";
            this.hanghoaIdTextBox.Size = new System.Drawing.Size(153, 20);
            this.hanghoaIdTextBox.TabIndex = 16;
            // 
            // motaTextBox
            // 
            this.motaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "Mota", true));
            this.motaTextBox.Location = new System.Drawing.Point(120, 77);
            this.motaTextBox.Name = "motaTextBox";
            this.motaTextBox.Size = new System.Drawing.Size(153, 20);
            this.motaTextBox.TabIndex = 18;
            // 
            // nhomHanghoaIdTextBox
            // 
            this.nhomHanghoaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "NhomHanghoaId", true));
            this.nhomHanghoaIdTextBox.Location = new System.Drawing.Point(120, 103);
            this.nhomHanghoaIdTextBox.Name = "nhomHanghoaIdTextBox";
            this.nhomHanghoaIdTextBox.Size = new System.Drawing.Size(153, 20);
            this.nhomHanghoaIdTextBox.TabIndex = 20;
            // 
            // soLuongTonKhoTextBox
            // 
            this.soLuongTonKhoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "SoLuongTonKho", true));
            this.soLuongTonKhoTextBox.Location = new System.Drawing.Point(120, 129);
            this.soLuongTonKhoTextBox.Name = "soLuongTonKhoTextBox";
            this.soLuongTonKhoTextBox.Size = new System.Drawing.Size(153, 20);
            this.soLuongTonKhoTextBox.TabIndex = 22;
            // 
            // tenHanghoaTextBox
            // 
            this.tenHanghoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangHoaBindingSource, "TenHanghoa", true));
            this.tenHanghoaTextBox.Location = new System.Drawing.Point(120, 155);
            this.tenHanghoaTextBox.Name = "tenHanghoaTextBox";
            this.tenHanghoaTextBox.Size = new System.Drawing.Size(153, 20);
            this.tenHanghoaTextBox.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(449, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(782, 529);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 529);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nhomHangHoaDataGridView);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 165);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(443, 361);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // nhomHangHoaDataGridView
            // 
            this.nhomHangHoaDataGridView.AutoGenerateColumns = false;
            this.nhomHangHoaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhomHangHoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomHangHoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhomHanghoaDataGridViewTextBoxColumn,
            this.nhomHanghoaIdDataGridViewTextBoxColumn1,
            this.ghiChuDataGridViewTextBoxColumn});
            this.nhomHangHoaDataGridView.DataSource = this.nhomHangHoaBindingSource;
            this.nhomHangHoaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhomHangHoaDataGridView.Location = new System.Drawing.Point(3, 16);
            this.nhomHangHoaDataGridView.Name = "nhomHangHoaDataGridView";
            this.nhomHangHoaDataGridView.Size = new System.Drawing.Size(437, 342);
            this.nhomHangHoaDataGridView.TabIndex = 0;
            this.nhomHangHoaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhomHangHoaDataGridView_CellClick);
            this.nhomHangHoaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhomHangHoaDataGridView_CellContentClick);
            // 
            // tenNhomHanghoaDataGridViewTextBoxColumn
            // 
            this.tenNhomHanghoaDataGridViewTextBoxColumn.DataPropertyName = "TenNhomHanghoa";
            this.tenNhomHanghoaDataGridViewTextBoxColumn.HeaderText = "Tên nhóm hàng hóa";
            this.tenNhomHanghoaDataGridViewTextBoxColumn.Name = "tenNhomHanghoaDataGridViewTextBoxColumn";
            // 
            // nhomHanghoaIdDataGridViewTextBoxColumn1
            // 
            this.nhomHanghoaIdDataGridViewTextBoxColumn1.DataPropertyName = "NhomHanghoaId";
            this.nhomHanghoaIdDataGridViewTextBoxColumn1.HeaderText = "Mã nhóm hàng hóa";
            this.nhomHanghoaIdDataGridViewTextBoxColumn1.Name = "nhomHanghoaIdDataGridViewTextBoxColumn1";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            // 
            // nhomHangHoaBindingSource
            // 
            this.nhomHangHoaBindingSource.DataSource = typeof(NhomHangHoa.Domain.NhomHangHoa);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(ghiChuLabel);
            this.groupBox5.Controls.Add(this.ghiChuTextBox);
            this.groupBox5.Controls.Add(nhomHanghoaIdLabel1);
            this.groupBox5.Controls.Add(this.nhomHanghoaIdTextBox1);
            this.groupBox5.Controls.Add(tenNhomHanghoaLabel);
            this.groupBox5.Controls.Add(this.tenNhomHanghoaTextBox);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(443, 149);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // ghiChuTextBox
            // 
            this.ghiChuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhomHangHoaBindingSource, "GhiChu", true));
            this.ghiChuTextBox.Location = new System.Drawing.Point(180, 116);
            this.ghiChuTextBox.Name = "ghiChuTextBox";
            this.ghiChuTextBox.Size = new System.Drawing.Size(185, 20);
            this.ghiChuTextBox.TabIndex = 6;
            // 
            // nhomHanghoaIdTextBox1
            // 
            this.nhomHanghoaIdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhomHangHoaBindingSource, "NhomHanghoaId", true));
            this.nhomHanghoaIdTextBox1.Location = new System.Drawing.Point(180, 62);
            this.nhomHanghoaIdTextBox1.Name = "nhomHanghoaIdTextBox1";
            this.nhomHanghoaIdTextBox1.Size = new System.Drawing.Size(185, 20);
            this.nhomHanghoaIdTextBox1.TabIndex = 8;
            // 
            // tenNhomHanghoaTextBox
            // 
            this.tenNhomHanghoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhomHangHoaBindingSource, "TenNhomHanghoa", true));
            this.tenNhomHanghoaTextBox.Location = new System.Drawing.Point(180, 88);
            this.tenNhomHanghoaTextBox.Name = "tenNhomHanghoaTextBox";
            this.tenNhomHanghoaTextBox.Size = new System.Drawing.Size(185, 20);
            this.tenNhomHanghoaTextBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1231, 529);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "frmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhomHangHoaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHangHoaBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox giaBanTextBox;
        private System.Windows.Forms.TextBox hanghoaIdTextBox;
        private System.Windows.Forms.TextBox motaTextBox;
        private System.Windows.Forms.TextBox nhomHanghoaIdTextBox;
        private System.Windows.Forms.TextBox soLuongTonKhoTextBox;
        private System.Windows.Forms.TextBox tenHanghoaTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView nhomHangHoaDataGridView;
        private System.Windows.Forms.BindingSource nhomHangHoaBindingSource;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ghiChuTextBox;
        private System.Windows.Forms.TextBox nhomHanghoaIdTextBox1;
        private System.Windows.Forms.TextBox tenNhomHanghoaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomHanghoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomHanghoaIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanghoaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHanghoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomHanghoaIdDataGridViewTextBoxColumn;
    }
}

