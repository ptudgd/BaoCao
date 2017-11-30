﻿using System;
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
            
            using(var cmd = new HangHoaListRepository())
            {
                hangHoaBindingSource.DataSource = cmd.Execute();
            }
        }

        private void dataGridView1_CursorChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var cur = this.hangHoaBindingSource.Current as HangHoa.Domain.HangHoa;
            if(cur != null && !string.IsNullOrWhiteSpace(cur.HanghoaId))
            {
                using(var cmd = new HangHoaDeleteRepository())
                {
                    cmd.hangHoaId = cur.HanghoaId;
                    cmd.Execute();
                }
                using(var cmd = new HangHoaListRepository())
                {
                    this.hangHoaBindingSource.DataSource = cmd.Execute();
                }
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
                using (var cmd = new HangHoaDeleteRepository())
                {
                    cmd.hangHoaId = cur.HanghoaId;
                    cmd.Execute();
                }
                using (var cmd = new HangHoaAddRepository())
                {
                    cmd.HanghoaId = this.hanghoaIdTextBox.Text;
                    cmd.GiaBan = Convert.ToInt32(this.giaBanTextBox.Text);
                    cmd.TenHanghoa = this.tenHanghoaTextBox.Text;
                    cmd.Mota = this.motaTextBox.Text;
                    cmd.SoLuongTonKho = Convert.ToInt32(this.soLuongTonKhoTextBox.Text);
                    cmd.NhomHanghoaId = this.nhomHanghoaIdTextBox.Text;
                    cmd.Execute();
                }
                using (var cmd = new HangHoaListRepository())
                {
                    this.hangHoaBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new frmAdd();
            if(f.ShowDialog() != DialogResult.OK)
            {
                using(var cmd = new HangHoaListRepository())
                {
                    this.hangHoaBindingSource.DataSource = cmd.Execute();
                }
            }

        }
    }
}
