using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaoCao.Repository;
using System.Data.SqlClient;

namespace HangHoaForm
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void txtHangHoaId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            using (var cmd = new HangHoaLoadNhomHangHoaRepository())
            {
                var data = cmd.Execute();
                foreach(var value in data)
                {
                    this.cbbNhomHangHoa.Items.Add(value.TenNhomHanghoa);                    
                    this.cbbNhomHangHoa.ValueMember = value.NhomHanghoaId;
                }
                this.cbbNhomHangHoa.SelectedIndex = 0;
            }
        }

        private void cbbNhomHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
