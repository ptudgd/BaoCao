using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhanVien.Repository;
using HangHoa.Business;

namespace dashboard
{
    public partial class NhanVienControl : UserControl
    {
        public NhanVienControl()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using(var cmd = new NhanVienListRepository())
            {
                this.nhanVienBindingSource.DataSource = cmd.Execute();
            }
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            using (var cmd = new NhanVienSearchRepository())
            {
                cmd.Ten = this.txtSearchStaff.Text;
                this.nhanVienBindingSource.DataSource = cmd.Execute();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var listcur = this.nhanVienBindingSource.DataSource as List<NhanVien.Domain.NhanVien>;
            if (listcur != null)
            {
                using (var cmd = new NhanVienSaveBusiness())
                {
                    foreach (var item in listcur)
                    {
                        cmd.item = item;
                        cmd.Execute();
                    }
                }
                using (var cmd = new NhanVienListRepository())
                {
                    this.nhanVienBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cur = this.nhanVienBindingSource.Current as NhanVien.Domain.NhanVien;
            if (cur != null && !string.IsNullOrWhiteSpace(cur.NhanvienId))
            {
                using (var cmd = new NhanVienDeleteRepository())
                {
                    cmd.NhanvienId = cur.NhanvienId;
                    cmd.Execute();
                }
                using (var cmd = new NhanVienListRepository())
                {
                    this.nhanVienBindingSource.DataSource = cmd.Execute();
                }
            }
        }
    }
}
