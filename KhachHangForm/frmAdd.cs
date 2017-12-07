using KhachHang.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachHangForm
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.khachhangIdTextBox.Text != "")
                {
                    using(var cmd = new KhachHangAddRepository())
                    {
                        cmd.KhachhangId = this.khachhangIdTextBox.Text;
                        cmd.Ho = this.hoTextBox.Text;
                        cmd.Tenlot = this.tenlotTextBox.Text;
                        cmd.Ten = this.tenTextBox.Text;
                        cmd.SDT = this.sDTTextBox.Text;
                        cmd.Email = this.emailTextBox.Text;
                        cmd.Gioitinh = this.gioitinhCheckBox.Checked;
                        cmd.Diachi = this.diachiTextBox.Text;
                        if (cmd.Execute())
                        {
                            this.Close();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Mã khách hàng không được bỏ trống!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi không xác định!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
