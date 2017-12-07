using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (var cmd = new LoginRepository.LoginLoadRepository())
                {
                    
                    cmd.username = this.txtUser.Text;
                    cmd.password = this.txtPass.Text;
                    if (cmd.Execute())
                    {
                        this.Hide();
                        var f = new mainForm();
                        if (f.ShowDialog() != DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi không xác định!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
