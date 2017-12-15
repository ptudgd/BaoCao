using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHangBusiness;
using PhieuBanHang.Repository;

namespace dashboard
{
    public partial class DanhSachBanHang : UserControl
    {
        public DanhSachBanHang()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            using(var cmd = new BanHangBusiness.BanHangListRepository())
            {
                this.banHangBindingSource.DataSource = cmd.Execute();
            }
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            var listcur = this.banHangBindingSource.DataSource as List<BanHang.Domain.BanHang>;
            if(listcur != null)
            {
                using(var cmd = new BanHangUpdateBusiness())
                {
                    foreach (var item in listcur)
                    {
                        cmd.item = item;
                        cmd.Execute();
                    }
                }
                using(var cmd = new BanHangListRepository())
                {
                    this.banHangBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            var cur = this.banHangBindingSource.Current as BanHang.Domain.BanHang;
            if(cur != null && !string.IsNullOrWhiteSpace(cur.ID.ToString()) && !string.IsNullOrWhiteSpace(cur.NgayBan))
            {
                using (var cmd = new BanHangDeleteRepository())
                {
                    cmd.ID = cur.ID;
                    cmd.HanghoaId = cur.HanghoaId;
                    cmd.Execute();
                }
                using(var cmd = new BanHangListRepository())
                {
                    this.banHangBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            using(var cmd = new BanHangListRepository())
            {
                cmd.data1 = this.Datepicker1.Value.ToShortDateString();
                cmd.data2 = this.Datepicker2.Value.ToShortDateString();
                this.banHangBindingSource.DataSource = cmd.Execute();
            }
        }
    }
}
