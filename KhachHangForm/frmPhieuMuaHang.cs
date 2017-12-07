using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhieuMuaHang.Repository;
using PhieuMuaHang.Business;
namespace KhachHangForm
{
    public partial class frmPhieuMuaHang : Form
    {
        public frmPhieuMuaHang()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            string data1 = dateTimePicker1.Value.ToShortDateString();
            string data2 = dateTimePicker2.Value.ToShortDateString();
            using(var cmd = new PhieuMuaHangListRepository())
            {
                cmd.datetimepicker1 = data1;
                cmd.datetimepicker2 = data2;
                this.phieuMuaHangBindingSource.DataSource = cmd.Execute();
            }
        }

        private void frmPhieuMuaHang_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var listcur = this.phieuMuaHangBindingSource.DataSource as List<PhieuMuaHang.Domain.PhieuMuaHang>;
            if(listcur != null)
            {
               using(var cmd = new PhieuMuaHangSaveBusiness())
                {
                    foreach (var item in listcur)
                    {
                        cmd.item = item;
                        cmd.Execute();
                    }
                }
               using(var cmd = new PhieuMuaHangListRepository())
                {
                    cmd.datetimepicker1 = this.dateTimePicker1.Value.ToShortDateString();
                    cmd.datetimepicker2 = this.dateTimePicker2.Value.ToShortDateString();                    
                    this.phieuMuaHangBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cur = this.phieuMuaHangBindingSource.Current as PhieuMuaHang.Domain.PhieuMuaHang;
            if(cur!= null && !string.IsNullOrWhiteSpace(cur.MaHD))
            {
                using(var cmd = new PhieuMuaHangDeleteRepository())
                {
                    cmd.MaHD = cur.MaHD;
                    cmd.Execute();
                }
                using(var cmd = new PhieuMuaHangListRepository())
                {
                    cmd.datetimepicker1 = this.dateTimePicker1.Value.ToShortDateString();
                    cmd.datetimepicker2 = this.dateTimePicker2.Value.ToShortDateString();
                    this.phieuMuaHangBindingSource.DataSource = cmd.Execute();
                }
            }
        }
    }
}
