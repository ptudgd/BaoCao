using KhachHang.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachHangForm
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var listcur = this.khachHangBindingSource.DataSource as List<KhachHang.Domain.KhachHang>;
                if(listcur != null)
                {
                    using(var cmd = new KhachHangAddRepository())
                    {
                        foreach (var item in listcur)
                        {
                            cmd.item = item;
                            cmd.Execute();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi không xác định!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
