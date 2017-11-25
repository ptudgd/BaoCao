using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Banhang.Repository;
using Banhang.Domain;
using Banhang.Business;

namespace Banhang.MainApp
{
    public partial class SinhvienListForm : System.Windows.Forms.Form
    {
        public SinhvienListForm()
        {
            InitializeComponent();
        }

        private void LoaDataButton_Click(object sender, EventArgs e)
        {
            using (var cmd = new SinhvienListRepository())
            {
                this.sinhvienBindingSource.DataSource = cmd.Execute();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var curRow = this.sinhvienBindingSource.Current as Sinhvien;
            if (curRow != null)
            {
                using (var biz = new SinhvienSaveBusiness())
                {
                    biz.item = curRow;
                    biz.Execute();
                }

                this.LoaDataButton_Click(null, null);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var curRow = this.sinhvienBindingSource.Current as Sinhvien;
            if (curRow != null)
            {
                using (var cmd = new SinhvienDeleteRepository())
                {
                    cmd.Maso = curRow.Maso;
                    cmd.Execute();
                }

                this.LoaDataButton_Click(null, null);
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ProductListForm())
            {
                form.ShowDialog(this);
            }
        }
    }
}
