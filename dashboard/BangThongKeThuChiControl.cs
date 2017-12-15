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
using ThuChiBusiness;


namespace dashboard
{
    public partial class BangThongKeThuChiControl : UserControl
    {
        public BangThongKeThuChiControl()
        {
            InitializeComponent();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            
            using(var cmd = new ThuChiListBusiness())
            {
                cmd.Ngay = this.Datepicker1.Value.ToShortDateString();
                var data = cmd.Execute();
                var tmp = new ThuChi.Domain.ThuChi();
                
                foreach (var item in data)
                {
                    tmp.Thu += item.Thu;
                    tmp.Chi += item.Chi;
                    tmp.Ngay = item.Ngay;
                }
                this.thuChiBindingSource.DataSource = tmp;
            }
            
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            var cur = this.thuChiBindingSource.Current as ThuChi.Domain.ThuChi;
            if(cur!= null && !string.IsNullOrWhiteSpace(cur.Ngay.ToString()))
            {
                using(var cmd = new ThuChiDeleteBusiness())
                {
                    cmd.Ngay = cur.Ngay.ToShortDateString();
                    cmd.Execute();
                }
                using(var cmd = new ThuChiListBusiness())
                {
                    cmd.Ngay = cur.Ngay.ToShortDateString();
                    this.thuChiBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            var cur = this.thuChiBindingSource.Current as ThuChi.Domain.ThuChi;
            if(cur != null && !string.IsNullOrWhiteSpace(cur.Ngay.ToString()))
            {
                using(var cmd = new ThuChiUpdateBusiness())
                {
                    cmd.Ngay = cur.Ngay.ToShortDateString();
                }
                using(var cmd = new ThuChiListBusiness())
                {
                    cmd.Ngay = cur.Ngay.ToShortDateString();
                    this.thuChiBindingSource.DataSource = cmd.Execute();
                }
            }
        }
    }
}
