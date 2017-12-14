using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhachHang.Repository;
using KhachHang.Business;
using NhanVien.Repository;

namespace dashboard
{
    public partial class KhachHangControl : UserControl
    {
        public KhachHangControl()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using(var cmd = new KhachHang.Repository.KhachHangListRepository())
            {
                this.khachHangBindingSource.DataSource = cmd.Execute();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var listcur = this.khachHangBindingSource.DataSource as List<KhachHang.Domain.KhachHang>;
            if (listcur != null)
            {
                using (var cmd = new KhachHangSaveBusiness())
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

        private void button3_Click(object sender, EventArgs e)
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

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            using (var cmd = new KhachHangSearchRepository())
            {
                cmd.Ten = this.txtSearchCustomer.Text;
                this.khachHangBindingSource.DataSource = cmd.Execute();
            }
        }
    }
}
