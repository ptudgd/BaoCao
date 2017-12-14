using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhomHangHoaRepository;
using BaoCao.Repository;
using HangHoa.Business;
using NhomHangHoaBusiness;

namespace dashboard
{
    public partial class HangHoaControl : UserControl
    {
        public HangHoaControl()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using(var cmd = new NhomHangHoaListRepository())
            {
                this.nhomHangHoaBindingSource.DataSource = cmd.Execute();
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
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
                using (var cmd = new HangHoaListRepository())
                {
                    cmd.NhomHanghoaId = cur.NhomHanghoaId;
                    this.hangHoaBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            var listcur = this.nhomHangHoaBindingSource.DataSource as List<NhomHangHoa.Domain.NhomHangHoa>;
            if (listcur != null)
            {
                using (var cmd = new NhomHangHoaSaveBusiness())
                {
                    foreach (var item in listcur)
                    {
                        cmd.item = item;
                        cmd.Execute();
                    }
                }
                using (var cmd = new NhomHangHoaListRepository())
                {
                    this.nhomHangHoaBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cur = this.nhomHangHoaBindingSource.Current as NhomHangHoa.Domain.NhomHangHoa;
            if (cur != null && !string.IsNullOrWhiteSpace(cur.NhomHanghoaId) && cur.NhomHanghoaId != "")
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
        }
    }
}
