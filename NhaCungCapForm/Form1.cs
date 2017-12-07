using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NhaCungCap.Repository;
using NhaCungCap.Business;

namespace NhaCungCapForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            using(var cmd = new NhaCungCapListRepository())
            {
                this.nhaCungCapBindingSource.DataSource = cmd.Execute();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var cur = this.nhaCungCapBindingSource.Current as NhaCungCap.Domain.NhaCungCap;
            if(cur != null && !string.IsNullOrWhiteSpace(cur.NhacungcapId))
            {
                using(var cmd = new NhaCungCapDeleteRepository())
                {
                    cmd.NhacungcapId = cur.NhacungcapId;
                    cmd.Execute();
                }
                using(var cmd = new NhaCungCapListRepository())
                {
                    this.nhaCungCapBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var listcur = this.nhaCungCapBindingSource.DataSource as List<NhaCungCap.Domain.NhaCungCap>;
            if(listcur != null)
            {
                using(var cmd = new NhaCungCapSaveBusiness())
                {
                    foreach (var item in listcur)
                    {
                        cmd.item = item;
                        cmd.Execute();
                    }
                }
                using(var cmd = new NhaCungCapListRepository())
                {
                    this.nhaCungCapBindingSource.DataSource =  cmd.Execute();
                }
            }
        }
    }
}
