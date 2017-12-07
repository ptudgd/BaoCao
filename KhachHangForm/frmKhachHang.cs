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
using KhachHang.Business;

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
        
        
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var cur = this.khachHangBindingSource.Current as KhachHang.Domain.KhachHang;
                if (cur != null && !string.IsNullOrWhiteSpace(cur.KhachhangId))
                {

                    using (var cmd = new KhachHangDeleteRepository())
                    {
                        cmd.KhachhangId = cur.KhachhangId;
                        cmd.Execute();
                    }
                    using (var cmd = new KhachHangListRepository())
                    {
                        this.khachHangBindingSource.DataSource = cmd.Execute();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi không xác định!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var listcur = this.khachHangBindingSource.DataSource as List<KhachHang.Domain.KhachHang>;
            if(listcur != null)
            {
                using(var cmd = new KhachHangSaveBusiness())
                {
                    foreach (var item in listcur)
                    {
                        cmd.item = item;
                        cmd.Execute();
                    }
                }
                using (var cmd = new KhachHangListRepository())
                {
                    this.khachHangBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                var f = new frmAdd();
                if (f.ShowDialog() != DialogResult.OK)
                {
                    using (var cmd = new KhachHangListRepository())
                    {
                        this.khachHangBindingSource.DataSource = cmd.Execute();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi không xác định!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnPhieuMuaHang_Click(object sender, EventArgs e)
        {
            var f = new frmPhieuMuaHang();
            f.ShowDialog();
        }
    }
}
