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

namespace NhanVienForm
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=.;Initial Catalog=QuanlySinhvien;Integrated Security=True";
            var data = new List<NhanVien.Domain.NhanVien>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM Nhanvien";
                    cmd.CommandType = System.Data.CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        data.Add(new NhanVien.Domain.NhanVien
                        {
                            NhanvienId = Convert.ToString(reader["NhanvienId"]),
                            Holot = Convert.ToString(reader["Holot"]),
                            Ten = Convert.ToString(reader["Ten"]),
                            Ngaysinh = Convert.ToDateTime(reader["Ngaysinh"]),
                            NgayVaolam = Convert.ToDateTime(reader["NgayVaolam"])
                        });
                    }
                    nhanVienBindingSource.DataSource = data;
                    reader.Close();
                    conn.Close();
                }
            }
        }

        private void ngaysinhLabel_Click(object sender, EventArgs e)
        {

        }

        private void ngayVaolamLabel_Click(object sender, EventArgs e)
        {

        }

        private void nhanvienIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void tenLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void holotLabel_Click(object sender, EventArgs e)
        {

        }

        private void holotTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhanVienBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ngaysinhTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ngayVaolamTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhanvienIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tenTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new PhieuBanHangForm.frmPhieuBanHang();
            f.Show();
        }
    }
}
