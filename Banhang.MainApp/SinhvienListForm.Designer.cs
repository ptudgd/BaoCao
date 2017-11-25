namespace Banhang.MainApp
{
    partial class SinhvienListForm
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
            this.LoaDataButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.gioitinhCheckBox = new System.Windows.Forms.CheckBox();
            this.holotTextBox = new System.Windows.Forms.TextBox();
            this.masoTextBox = new System.Windows.Forms.TextBox();
            this.ngaysinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ngaysinhStringTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gioitinhLabel = new System.Windows.Forms.Label();
            holotLabel = new System.Windows.Forms.Label();
            masoLabel = new System.Windows.Forms.Label();
            ngaysinhLabel = new System.Windows.Forms.Label();
            ngaysinhStringLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Location = new System.Drawing.Point(14, 32);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(50, 13);
            gioitinhLabel.TabIndex = 4;
            gioitinhLabel.Text = "Giới tính:";
            // 
            // holotLabel
            // 
            holotLabel.AutoSize = true;
            holotLabel.Location = new System.Drawing.Point(14, 60);
            holotLabel.Name = "holotLabel";
            holotLabel.Size = new System.Drawing.Size(38, 13);
            holotLabel.TabIndex = 6;
            holotLabel.Text = "Họ lót:";
            // 
            // masoLabel
            // 
            masoLabel.AutoSize = true;
            masoLabel.Location = new System.Drawing.Point(14, 86);
            masoLabel.Name = "masoLabel";
            masoLabel.Size = new System.Drawing.Size(39, 13);
            masoLabel.TabIndex = 8;
            masoLabel.Text = "Mã số:";
            // 
            // ngaysinhLabel
            // 
            ngaysinhLabel.AutoSize = true;
            ngaysinhLabel.Location = new System.Drawing.Point(14, 113);
            ngaysinhLabel.Name = "ngaysinhLabel";
            ngaysinhLabel.Size = new System.Drawing.Size(57, 13);
            ngaysinhLabel.TabIndex = 10;
            ngaysinhLabel.Text = "Ngày sinh:";
            // 
            // ngaysinhStringLabel
            // 
            ngaysinhStringLabel.AutoSize = true;
            ngaysinhStringLabel.Location = new System.Drawing.Point(14, 138);
            ngaysinhStringLabel.Name = "ngaysinhStringLabel";
            ngaysinhStringLabel.Size = new System.Drawing.Size(84, 13);
            ngaysinhStringLabel.TabIndex = 12;
            ngaysinhStringLabel.Text = "Ngaysinh String:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(14, 164);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(29, 13);
            tenLabel.TabIndex = 14;
            tenLabel.Text = "Tên:";
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
            this.sinhvienDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sinhvienDataGridView.Location = new System.Drawing.Point(0, 186);
            this.sinhvienDataGridView.Name = "sinhvienDataGridView";
            this.sinhvienDataGridView.Size = new System.Drawing.Size(658, 214);
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
            // LoaDataButton
            // 
            this.LoaDataButton.Location = new System.Drawing.Point(399, 60);
            this.LoaDataButton.Name = "LoaDataButton";
            this.LoaDataButton.Size = new System.Drawing.Size(75, 23);
            this.LoaDataButton.TabIndex = 2;
            this.LoaDataButton.Text = "Load Data";
            this.LoaDataButton.UseVisualStyleBackColor = true;
            this.LoaDataButton.Click += new System.EventHandler(this.LoaDataButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(483, 103);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(552, 50);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // gioitinhCheckBox
            // 
            this.gioitinhCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sinhvienBindingSource, "Gioitinh", true));
            this.gioitinhCheckBox.Location = new System.Drawing.Point(104, 27);
            this.gioitinhCheckBox.Name = "gioitinhCheckBox";
            this.gioitinhCheckBox.Size = new System.Drawing.Size(200, 24);
            this.gioitinhCheckBox.TabIndex = 5;
            this.gioitinhCheckBox.Text = "checkBox1";
            this.gioitinhCheckBox.UseVisualStyleBackColor = true;
            // 
            // holotTextBox
            // 
            this.holotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "Holot", true));
            this.holotTextBox.Location = new System.Drawing.Point(104, 57);
            this.holotTextBox.Name = "holotTextBox";
            this.holotTextBox.Size = new System.Drawing.Size(200, 20);
            this.holotTextBox.TabIndex = 7;
            // 
            // masoTextBox
            // 
            this.masoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "Maso", true));
            this.masoTextBox.Location = new System.Drawing.Point(104, 83);
            this.masoTextBox.Name = "masoTextBox";
            this.masoTextBox.Size = new System.Drawing.Size(200, 20);
            this.masoTextBox.TabIndex = 9;
            // 
            // ngaysinhDateTimePicker
            // 
            this.ngaysinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sinhvienBindingSource, "Ngaysinh", true));
            this.ngaysinhDateTimePicker.Location = new System.Drawing.Point(104, 109);
            this.ngaysinhDateTimePicker.Name = "ngaysinhDateTimePicker";
            this.ngaysinhDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngaysinhDateTimePicker.TabIndex = 11;
            // 
            // ngaysinhStringTextBox
            // 
            this.ngaysinhStringTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "NgaysinhString", true));
            this.ngaysinhStringTextBox.Location = new System.Drawing.Point(104, 135);
            this.ngaysinhStringTextBox.Name = "ngaysinhStringTextBox";
            this.ngaysinhStringTextBox.Size = new System.Drawing.Size(200, 20);
            this.ngaysinhStringTextBox.TabIndex = 13;
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(104, 161);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenTextBox.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // SinhvienListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 400);
            this.Controls.Add(gioitinhLabel);
            this.Controls.Add(this.gioitinhCheckBox);
            this.Controls.Add(holotLabel);
            this.Controls.Add(this.holotTextBox);
            this.Controls.Add(masoLabel);
            this.Controls.Add(this.masoTextBox);
            this.Controls.Add(ngaysinhLabel);
            this.Controls.Add(this.ngaysinhDateTimePicker);
            this.Controls.Add(ngaysinhStringLabel);
            this.Controls.Add(this.ngaysinhStringTextBox);
            this.Controls.Add(tenLabel);
            this.Controls.Add(this.tenTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoaDataButton);
            this.Controls.Add(this.sinhvienDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SinhvienListForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button LoaDataButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.CheckBox gioitinhCheckBox;
        private System.Windows.Forms.TextBox holotTextBox;
        private System.Windows.Forms.TextBox masoTextBox;
        private System.Windows.Forms.DateTimePicker ngaysinhDateTimePicker;
        private System.Windows.Forms.TextBox ngaysinhStringTextBox;
        private System.Windows.Forms.TextBox tenTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
    }
}

