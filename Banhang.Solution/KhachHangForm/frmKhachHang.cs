using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhachHang.Repository;
namespace KhachHangForm
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using(var cmd = new KhachHangListRepository())
            {
                this.khachHangBindingSource.DataSource = cmd.Execute();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new PhieuMuaHangForm.frmPhieuMuaHang();
            f.Show();
        }
    }
}
