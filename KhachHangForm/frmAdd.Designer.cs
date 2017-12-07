namespace KhachHangForm
{
    partial class frmAdd
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
            System.Windows.Forms.Label diachiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label gioitinhLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label khachhangIdLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label tenlotLabel;
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diachiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.gioitinhCheckBox = new System.Windows.Forms.CheckBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.khachhangIdTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.tenlotTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            diachiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            gioitinhLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            khachhangIdLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            tenlotLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diachiLabel.Location = new System.Drawing.Point(26, 129);
            diachiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(59, 16);
            diachiLabel.TabIndex = 1;
            diachiLabel.Text = "Địa chỉ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(26, 161);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(51, 16);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gioitinhLabel.Location = new System.Drawing.Point(26, 226);
            gioitinhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(68, 16);
            gioitinhLabel.TabIndex = 5;
            gioitinhLabel.Text = "Giới tính:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoLabel.Location = new System.Drawing.Point(26, 39);
            hoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(32, 16);
            hoLabel.TabIndex = 7;
            hoLabel.Text = "Họ:";
            // 
            // khachhangIdLabel
            // 
            khachhangIdLabel.AutoSize = true;
            khachhangIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            khachhangIdLabel.Location = new System.Drawing.Point(26, 9);
            khachhangIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            khachhangIdLabel.Name = "khachhangIdLabel";
            khachhangIdLabel.Size = new System.Drawing.Size(116, 16);
            khachhangIdLabel.TabIndex = 9;
            khachhangIdLabel.Text = "Mã khách hàng:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(26, 191);
            sDTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(103, 16);
            sDTLabel.TabIndex = 11;
            sDTLabel.Text = "Số điện thọai:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.Location = new System.Drawing.Point(26, 99);
            tenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(39, 16);
            tenLabel.TabIndex = 13;
            tenLabel.Text = "Tên:";
            // 
            // tenlotLabel
            // 
            tenlotLabel.AutoSize = true;
            tenlotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenlotLabel.Location = new System.Drawing.Point(26, 69);
            tenlotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tenlotLabel.Name = "tenlotLabel";
            tenlotLabel.Size = new System.Drawing.Size(60, 16);
            tenlotLabel.TabIndex = 15;
            tenlotLabel.Text = "Tên lót:";
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(KhachHang.Domain.KhachHang);
            // 
            // diachiTextBox
            // 
            this.diachiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Diachi", true));
            this.diachiTextBox.Location = new System.Drawing.Point(162, 125);
            this.diachiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.diachiTextBox.Name = "diachiTextBox";
            this.diachiTextBox.Size = new System.Drawing.Size(384, 22);
            this.diachiTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(162, 157);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(384, 22);
            this.emailTextBox.TabIndex = 6;
            // 
            // gioitinhCheckBox
            // 
            this.gioitinhCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.khachHangBindingSource, "Gioitinh", true));
            this.gioitinhCheckBox.Location = new System.Drawing.Point(160, 217);
            this.gioitinhCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.gioitinhCheckBox.Name = "gioitinhCheckBox";
            this.gioitinhCheckBox.Size = new System.Drawing.Size(386, 30);
            this.gioitinhCheckBox.TabIndex = 8;
            this.gioitinhCheckBox.Text = "Nam";
            this.gioitinhCheckBox.UseVisualStyleBackColor = true;
            // 
            // hoTextBox
            // 
            this.hoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Ho", true));
            this.hoTextBox.Location = new System.Drawing.Point(162, 35);
            this.hoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(384, 22);
            this.hoTextBox.TabIndex = 2;
            // 
            // khachhangIdTextBox
            // 
            this.khachhangIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "KhachhangId", true));
            this.khachhangIdTextBox.Location = new System.Drawing.Point(162, 5);
            this.khachhangIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.khachhangIdTextBox.Name = "khachhangIdTextBox";
            this.khachhangIdTextBox.Size = new System.Drawing.Size(384, 22);
            this.khachhangIdTextBox.TabIndex = 1;
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(162, 187);
            this.sDTTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(384, 22);
            this.sDTTextBox.TabIndex = 7;
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(162, 95);
            this.tenTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(384, 22);
            this.tenTextBox.TabIndex = 4;
            // 
            // tenlotTextBox
            // 
            this.tenlotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Tenlot", true));
            this.tenlotTextBox.Location = new System.Drawing.Point(162, 65);
            this.tenlotTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tenlotTextBox.Name = "tenlotTextBox";
            this.tenlotTextBox.Size = new System.Drawing.Size(384, 22);
            this.tenlotTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 66);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hủy bỏ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 66);
            this.button2.TabIndex = 9;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(576, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(diachiLabel);
            this.Controls.Add(this.diachiTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(gioitinhLabel);
            this.Controls.Add(this.gioitinhCheckBox);
            this.Controls.Add(hoLabel);
            this.Controls.Add(this.hoTextBox);
            this.Controls.Add(khachhangIdLabel);
            this.Controls.Add(this.khachhangIdTextBox);
            this.Controls.Add(sDTLabel);
            this.Controls.Add(this.sDTTextBox);
            this.Controls.Add(tenLabel);
            this.Controls.Add(this.tenTextBox);
            this.Controls.Add(tenlotLabel);
            this.Controls.Add(this.tenlotTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.TextBox diachiTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox gioitinhCheckBox;
        private System.Windows.Forms.TextBox hoTextBox;
        private System.Windows.Forms.TextBox khachhangIdTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox tenTextBox;
        private System.Windows.Forms.TextBox tenlotTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}