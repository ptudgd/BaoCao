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
using ThuChi.Repository;
namespace ThuChiForm
{
    public partial class frmThuChi : Form
    {
        public frmThuChi()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string data1 = dateTimePicker1.Value.ToShortDateString();
            string data2 = dateTimePicker2.Value.ToShortDateString();
            using(var cmd = new ThuChiListRepository())
            {
                cmd.datetimepicker1 = data1;
                cmd.datetimepicker2 = data2;
                this.thuChiBindingSource.DataSource = cmd.Execute();
            }
        }
    }
}
