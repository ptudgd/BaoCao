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
            f.ShowDialog();
        }
        
        
        private void btnDel_Click(object sender, EventArgs e)
        {
            var cur = this.khachHangBindingSource.Current as KhachHang.Domain.KhachHang;
            if(cur != null && !string.IsNullOrWhiteSpace(cur.KhachhangId))
            {
                
                using(var cmd = new KhachHangDeleteRepository())
                {
                    cmd.KhachhangId = cur.KhachhangId;
                    cmd.Execute();
                }
                using(var cmd = new KhachHangListRepository())
                {
                    this.khachHangBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
