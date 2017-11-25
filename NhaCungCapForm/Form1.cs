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
    }
}
