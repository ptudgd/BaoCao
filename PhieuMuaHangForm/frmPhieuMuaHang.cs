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

namespace PhieuMuaHangForm
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
    }
}
