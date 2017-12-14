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
using HangHoa.Domain;
using BaoCao.Repository;
using HangHoa.Business;
using NhomHangHoaRepository;
using NhomHangHoaBusiness;

namespace HangHoaForm
{
    public partial class frmHangHoa : Form
    {
        
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            try
            {
                using (var cmd = new NhomHangHoaListRepository())
                {
                    this.nhomHangHoaBindingSource.DataSource = cmd.Execute();
                }
                
            }
            catch
            {
                MessageBox.Show("Tải dữ liệu thất bại. Xin thử lại sau!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CursorChanged(object sender, EventArgs e)
        {

        }

        

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var cur = this.hangHoaBindingSource.Current as HangHoa.Domain.HangHoa;
                if (cur != null && !string.IsNullOrWhiteSpace(cur.HanghoaId))
                {
                    using (var cmd = new HangHoaDeleteRepository())
                    {
                        cmd.hangHoaId = cur.HanghoaId;
                        cmd.Execute();
                    }
                    using (var cmd = new HangHoaListRepository())
                    {
                        this.hangHoaBindingSource.DataSource = cmd.Execute();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không xác định, vui lòng thử lại!", "THÔNG BÁO!", MessageBoxButtons.OK);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            var cur = this.hangHoaBindingSource.Current as HangHoa.Domain.HangHoa;
            if (cur != null && !string.IsNullOrWhiteSpace(cur.HanghoaId))
            {
                var listcur = this.hangHoaBindingSource.DataSource as List<HangHoa.Domain.HangHoa>;
                using (var cmd = new HangHoaSaveBusiness())
                {
                    foreach (var item in listcur)
                    {
                        cmd.item = item;
                        cmd.Execute();
                    }
                }
                using(var cmd = new HangHoaListRepository())
                {
                    cmd.NhomHanghoaId = cur.NhomHanghoaId;
                    this.hangHoaBindingSource.DataSource = cmd.Execute();
                }
            }
                
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var listcur = this.hangHoaBindingSource.DataSource as List<HangHoa.Domain.HangHoa>;

                if (listcur != null)
                {
                    using (var cmd = new HangHoaAddRepository())
                    {
                        foreach (var item in listcur)
                        {
                            cmd.item = item;
                            cmd.Execute();
                        }
                    }
                    using (var cmd = new HangHoaListRepository())
                    {
                        cmd.Execute();
                    }
                }
            }
            catch
            {

            }
        }

        private void nhomHangHoaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nhomHangHoaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var cur = this.nhomHangHoaBindingSource.Current as NhomHangHoa.Domain.NhomHangHoa;
            if (cur != null && !string.IsNullOrWhiteSpace(cur.NhomHanghoaId))
            {
                using (var cmd = new HangHoaListRepository())
                {
                    cmd.NhomHanghoaId = cur.NhomHanghoaId;
                    this.hangHoaBindingSource.DataSource = cmd.Execute();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listcur = this.nhomHangHoaBindingSource.DataSource as List<NhomHangHoa.Domain.NhomHangHoa>;
            if(listcur != null)
            {
                using(var cmd = new NhomHangHoaSaveBusiness())
                {
                    foreach (var item in listcur)
                    {
                        cmd.item = item;
                        cmd.Execute();
                    }
                }
                using(var cmd = new NhomHangHoaListRepository())
                {
                    this.nhomHangHoaBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cur = this.nhomHangHoaBindingSource.Current as NhomHangHoa.Domain.NhomHangHoa;
            if(cur != null && !string.IsNullOrWhiteSpace(cur.NhomHanghoaId) && cur.NhomHanghoaId != "")
            {
                using (var cmd = new NhomHangHoaDeleteRepository())
                {
                    cmd.NhomHanghoaId = cur.NhomHanghoaId;
                    cmd.Execute();
                }
                using (var cmd = new NhomHangHoaListRepository())
                {
                    this.nhomHangHoaBindingSource.DataSource = cmd.Execute();
                }
            }
            else
            {
                MessageBox.Show("Mã nhóm hàng hóa không tồn tại!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {

        }
    }
}
