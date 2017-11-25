namespace Banhang.MainApp
{
    partial class ProductListForm
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
            System.Windows.Forms.Label giabanLabel;
            System.Windows.Forms.Label masoLabel;
            System.Windows.Forms.Label nhomLabel;
            System.Windows.Forms.Label tenLabel;
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giabanTextBox = new System.Windows.Forms.TextBox();
            this.masoTextBox = new System.Windows.Forms.TextBox();
            this.nhomTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            giabanLabel = new System.Windows.Forms.Label();
            masoLabel = new System.Windows.Forms.Label();
            nhomLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productDataGridView.Location = new System.Drawing.Point(0, 223);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(542, 220);
            this.productDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Maso";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã số";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ten";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên hàng hóa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Giaban";
            this.dataGridViewTextBoxColumn3.HeaderText = "Giá bán";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nhom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nhóm hàng hóa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Banhang.Domain.Product);
            // 
            // giabanLabel
            // 
            giabanLabel.AutoSize = true;
            giabanLabel.Location = new System.Drawing.Point(26, 54);
            giabanLabel.Name = "giabanLabel";
            giabanLabel.Size = new System.Drawing.Size(47, 13);
            giabanLabel.TabIndex = 2;
            giabanLabel.Text = "Giá bán:";
            // 
            // giabanTextBox
            // 
            this.giabanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Giaban", true));
            this.giabanTextBox.Location = new System.Drawing.Point(118, 51);
            this.giabanTextBox.Name = "giabanTextBox";
            this.giabanTextBox.Size = new System.Drawing.Size(100, 20);
            this.giabanTextBox.TabIndex = 3;
            // 
            // masoLabel
            // 
            masoLabel.AutoSize = true;
            masoLabel.Location = new System.Drawing.Point(26, 80);
            masoLabel.Name = "masoLabel";
            masoLabel.Size = new System.Drawing.Size(39, 13);
            masoLabel.TabIndex = 4;
            masoLabel.Text = "Mã số:";
            // 
            // masoTextBox
            // 
            this.masoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Maso", true));
            this.masoTextBox.Location = new System.Drawing.Point(118, 77);
            this.masoTextBox.Name = "masoTextBox";
            this.masoTextBox.Size = new System.Drawing.Size(100, 20);
            this.masoTextBox.TabIndex = 5;
            // 
            // nhomLabel
            // 
            nhomLabel.AutoSize = true;
            nhomLabel.Location = new System.Drawing.Point(26, 106);
            nhomLabel.Name = "nhomLabel";
            nhomLabel.Size = new System.Drawing.Size(86, 13);
            nhomLabel.TabIndex = 6;
            nhomLabel.Text = "Nhóm hàng hóa:";
            // 
            // nhomTextBox
            // 
            this.nhomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Nhom", true));
            this.nhomTextBox.Location = new System.Drawing.Point(118, 103);
            this.nhomTextBox.Name = "nhomTextBox";
            this.nhomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nhomTextBox.TabIndex = 7;
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(26, 132);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(77, 13);
            tenLabel.TabIndex = 8;
            tenLabel.Text = "Tên hàng hóa:";
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(118, 129);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(giabanLabel);
            this.Controls.Add(this.giabanTextBox);
            this.Controls.Add(masoLabel);
            this.Controls.Add(this.masoTextBox);
            this.Controls.Add(nhomLabel);
            this.Controls.Add(this.nhomTextBox);
            this.Controls.Add(tenLabel);
            this.Controls.Add(this.tenTextBox);
            this.Controls.Add(this.productDataGridView);
            this.Name = "ProductListForm";
            this.Text = "ProductListForm";
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox giabanTextBox;
        private System.Windows.Forms.TextBox masoTextBox;
        private System.Windows.Forms.TextBox nhomTextBox;
        private System.Windows.Forms.TextBox tenTextBox;
        private System.Windows.Forms.Button button1;
    }
}