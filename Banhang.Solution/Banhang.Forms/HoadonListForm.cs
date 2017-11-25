using Banhang.Repository.HanghoaHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banhang.Forms
{
    public partial class HoadonListForm : Form
    {
        public HoadonListForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (var cmd = new HoadonSearchRepository())
            {
                cmd.From = this.FromDateTimePicker.Value;
                cmd.To = this.ToDateTimePicker.Value;
                this.hoadonBindingSource.DataSource = cmd.Execute();
            }
        }

        private void Editutton_Click(object sender, EventArgs e)
        {
            var cur = this.hoadonBindingSource.Current as Banhang.Domain.HanghoaHandler.Hoadon;
            if (cur != null)
            {
                using (var f = new HoadonForm(cur.HoadonId))
                {
                    f.ShowDialog(this);
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            using (var f = new HoadonForm(null))
            {
                f.ShowDialog(this);
            }
        }

        private void HoadonListForm_Load(object sender, EventArgs e)
        {
            this.FromDateTimePicker.Value = DateTime.Now.Date;
            this.ToDateTimePicker.Value = DateTime.Now.Date;
        }
    }
}
