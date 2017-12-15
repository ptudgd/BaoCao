using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginRepository;
namespace LoginForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cmd = new LoginLoadRepository())
                {
                    cmd.username = this.txtUsername.Text;
                    cmd.password = this.txtPassword.Text;
                    if (cmd.Execute())
                    {
                        this.lblInfo.Text = "";
                        this.Hide();
                        var f = new dashboard.Main();
                        f.ShowDialog();
                        Application.Exit();
                    }
                    else
                    {
                        this.lblInfo.Text = "Tài khoản hoặc mật khẩu không đúng!";
                    }
                }
            }
            catch
            {

                this.lblInfo.Text = "Không thể kết nối!";
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}
