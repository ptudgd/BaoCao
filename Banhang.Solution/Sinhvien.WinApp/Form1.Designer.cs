namespace Sinhvien.WinApp
{
    partial class Form1
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
            System.Windows.Forms.Label gioitinhLabel;
            System.Windows.Forms.Label holotLabel;
            System.Windows.Forms.Label masoLabel;
            System.Windows.Forms.Label ngaysinhLabel;
            System.Windows.Forms.Label ngaysinhStringLabel;
            System.Windows.Forms.Label tenLabel;
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhvienDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gioitinhCheckBox = new System.Windows.Forms.CheckBox();
            this.holotTextBox = new System.Windows.Forms.TextBox();
            this.masoTextBox = new System.Windows.Forms.TextBox();
            this.ngaysinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ngaysinhStringLabel1 = new System.Windows.Forms.Label();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            gioitinhLabel = new System.Windows.Forms.Label();
            holotLabel = new System.Windows.Forms.Label();
            masoLabel = new System.Windows.Forms.Label();
            ngaysinhLabel = new System.Windows.Forms.Label();
            ngaysinhStringLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataSource = typeof(Banhang.Domain.Sinhvien);
            // 
            // sinhvienDataGridView
            // 
            this.sinhvienDataGridView.AutoGenerateColumns = false;
            this.sinhvienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sinhvienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.sinhvienDataGridView.DataSource = this.sinhvienBindingSource;
            this.sinhvienDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sinhvienDataGridView.Location = new System.Drawing.Point(0, 180);
            this.sinhvienDataGridView.Name = "sinhvienDataGridView";
            this.sinhvienDataGridView.Size = new System.Drawing.Size(619, 290);
            this.sinhvienDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Maso";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã số";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Holot";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ lót";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ten";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ngaysinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NgaysinhString";
            this.dataGridViewTextBoxColumn5.HeaderText = "NgaysinhString";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Gioitinh";
            this.dataGridViewTextBoxColumn6.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(gioitinhLabel);
            this.groupBox1.Controls.Add(this.gioitinhCheckBox);
            this.groupBox1.Controls.Add(holotLabel);
            this.groupBox1.Controls.Add(this.holotTextBox);
            this.groupBox1.Controls.Add(masoLabel);
            this.groupBox1.Controls.Add(this.masoTextBox);
            this.groupBox1.Controls.Add(ngaysinhLabel);
            this.groupBox1.Controls.Add(this.ngaysinhDateTimePicker);
            this.groupBox1.Controls.Add(ngaysinhStringLabel);
            this.groupBox1.Controls.Add(this.ngaysinhStringLabel1);
            this.groupBox1.Controls.Add(tenLabel);
            this.groupBox1.Controls.Add(this.tenTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Location = new System.Drawing.Point(21, 22);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(50, 13);
            gioitinhLabel.TabIndex = 0;
            gioitinhLabel.Text = "Giới tính:";
            // 
            // gioitinhCheckBox
            // 
            this.gioitinhCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sinhvienBindingSource, "Gioitinh", true));
            this.gioitinhCheckBox.Location = new System.Drawing.Point(111, 17);
            this.gioitinhCheckBox.Name = "gioitinhCheckBox";
            this.gioitinhCheckBox.Size = new System.Drawing.Size(200, 24);
            this.gioitinhCheckBox.TabIndex = 1;
            this.gioitinhCheckBox.Text = "checkBox1";
            this.gioitinhCheckBox.UseVisualStyleBackColor = true;
            // 
            // holotLabel
            // 
            holotLabel.AutoSize = true;
            holotLabel.Location = new System.Drawing.Point(21, 50);
            holotLabel.Name = "holotLabel";
            holotLabel.Size = new System.Drawing.Size(38, 13);
            holotLabel.TabIndex = 2;
            holotLabel.Text = "Họ lót:";
            // 
            // holotTextBox
            // 
            this.holotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "Holot", true));
            this.holotTextBox.Location = new System.Drawing.Point(111, 47);
            this.holotTextBox.Name = "holotTextBox";
            this.holotTextBox.Size = new System.Drawing.Size(200, 20);
            this.holotTextBox.TabIndex = 3;
            // 
            // masoLabel
            // 
            masoLabel.AutoSize = true;
            masoLabel.Location = new System.Drawing.Point(21, 76);
            masoLabel.Name = "masoLabel";
            masoLabel.Size = new System.Drawing.Size(39, 13);
            masoLabel.TabIndex = 4;
            masoLabel.Text = "Mã số:";
            // 
            // masoTextBox
            // 
            this.masoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "Maso", true));
            this.masoTextBox.Location = new System.Drawing.Point(111, 73);
            this.masoTextBox.Name = "masoTextBox";
            this.masoTextBox.Size = new System.Drawing.Size(200, 20);
            this.masoTextBox.TabIndex = 5;
            // 
            // ngaysinhLabel
            // 
            ngaysinhLabel.AutoSize = true;
            ngaysinhLabel.Location = new System.Drawing.Point(21, 103);
            ngaysinhLabel.Name = "ngaysinhLabel";
            ngaysinhLabel.Size = new System.Drawing.Size(57, 13);
            ngaysinhLabel.TabIndex = 6;
            ngaysinhLabel.Text = "Ngày sinh:";
            // 
            // ngaysinhDateTimePicker
            // 
            this.ngaysinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sinhvienBindingSource, "Ngaysinh", true));
            this.ngaysinhDateTimePicker.Location = new System.Drawing.Point(111, 99);
            this.ngaysinhDateTimePicker.Name = "ngaysinhDateTimePicker";
            this.ngaysinhDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngaysinhDateTimePicker.TabIndex = 7;
            // 
            // ngaysinhStringLabel
            // 
            ngaysinhStringLabel.AutoSize = true;
            ngaysinhStringLabel.Location = new System.Drawing.Point(21, 122);
            ngaysinhStringLabel.Name = "ngaysinhStringLabel";
            ngaysinhStringLabel.Size = new System.Drawing.Size(84, 13);
            ngaysinhStringLabel.TabIndex = 8;
            ngaysinhStringLabel.Text = "Ngaysinh String:";
            // 
            // ngaysinhStringLabel1
            // 
            this.ngaysinhStringLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "NgaysinhString", true));
            this.ngaysinhStringLabel1.Location = new System.Drawing.Point(111, 122);
            this.ngaysinhStringLabel1.Name = "ngaysinhStringLabel1";
            this.ngaysinhStringLabel1.Size = new System.Drawing.Size(200, 23);
            this.ngaysinhStringLabel1.TabIndex = 9;
            this.ngaysinhStringLabel1.Text = "label1";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(21, 151);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(29, 13);
            tenLabel.TabIndex = 10;
            tenLabel.Text = "Tên:";
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(111, 148);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 470);
            this.Controls.Add(this.sinhvienDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private System.Windows.Forms.DataGridView sinhvienDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox gioitinhCheckBox;
        private System.Windows.Forms.TextBox holotTextBox;
        private System.Windows.Forms.TextBox masoTextBox;
        private System.Windows.Forms.DateTimePicker ngaysinhDateTimePicker;
        private System.Windows.Forms.Label ngaysinhStringLabel1;
        private System.Windows.Forms.TextBox tenTextBox;
    }
}

