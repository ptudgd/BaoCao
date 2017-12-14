using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
namespace DangNhapForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {        
                using(var cmd = new LoginRepository.LoginLoadRepository())
                {
                    cmd.username = this.txtUsername.Text;
                    cmd.password = this.txtPassword.Password;
                    if (cmd.Execute() == true)
                    {
                        this.Hide();
                        this.lblInfo.Visibility = Visibility.Hidden;
                        var f = new mainForm.mainForm();
                        f.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        this.lblInfo.Visibility = Visibility.Visible;                        
                        this.lblInfo.Content = "Tài khoản hoặc mật khẩu không đúng!";
                    }
                }
            }
            catch
            {
                this.lblInfo.Visibility = Visibility.Visible;
                this.lblInfo.Content = "Xảy ra lỗi không xác định!";
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
