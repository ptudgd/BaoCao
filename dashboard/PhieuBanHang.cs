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
using System.Globalization;
using DevExpress.XtraReports.UI;

using PhieuBanHangSaveBusiness;
using BanHangBusiness;
using PhieuBanHang.Repository;
using ThuChiBusiness;

namespace dashboard
{
    
    public partial class PhieuBanHang : UserControl
    {
        public PhieuBanHang()
        {
            InitializeComponent();
            this.txtGiaBan.Hide();
        }
        private int getRand(int len)
        {
            Random rand = new Random();

            string s = "";
            for (int i = 0; i < len; i++)
            {
                int num = rand.Next(0, 26);
                s += num.ToString();
            }

            return Convert.ToInt32(s);
        }
        private void PhieuBanHang_Load(object sender, EventArgs e)
        {
            using(var cmd = new NhomHangHoaListRepository())
            {
                var data = cmd.Execute();
                this.cbbNhomHangHoa.DataSource = data;
                this.cbbNhomHangHoa.DisplayMember = "TenNhomHanghoa";
                this.cbbNhomHangHoa.ValueMember = "NhomHanghoaId";
            }
        }
        public int rand = 0;
        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (rand == 0)
                {
                    rand = getRand(2);
                }
                var data = new BanHang.Domain.BanHang();
                data.HanghoaId = this.cbbHangHoa.SelectedValue.ToString();
                data.NhomHanghoaId = this.cbbNhomHangHoa.SelectedValue.ToString();
                data.TenSanPham = this.cbbHangHoa.Text;
                data.NgayBan = DateTime.Now.ToString();
                data.SoLuong = Convert.ToInt32(this.txtSoLuong.Text);
                data.Giaban = Convert.ToInt32(this.txtSoLuong.Text) * Convert.ToInt32(this.txtGiaBan.Text);
                data.ID = rand;

                using (var cmd = new BanHangAddRepository())
                {
                    cmd.item = data;
                    cmd.Execute();
                }
                using(var cmd = new BanHangSubBusiness())
                {
                    cmd.HanghoaId = data.HanghoaId;
                    cmd.SoLuong = data.SoLuong;
                    cmd.Execute();
                }
                using (var cmd = new BanHangViewBusiness())
                {
                    cmd.ID = data.ID;
                    this.banHangBindingSource.DataSource = cmd.Execute();
                }
                this.txtSoLuong.Text = "";
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!", "CÓ LỖI XẢY RA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbbNhomHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var cmd = new HangHoaListRepository())
            {
                cmd.NhomHanghoaId = this.cbbNhomHangHoa.SelectedValue.ToString();
                this.cbbHangHoa.DataSource = cmd.Execute();
                this.cbbHangHoa.DisplayMember = "TenHanghoa";
                this.cbbHangHoa.ValueMember = "HanghoaId";
                
            }
            
        }

        private void cbbHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var cmd = new HangHoaListRepository())
            {
                cmd.HanghoaId = this.cbbHangHoa.SelectedValue.ToString();
                var data = cmd.Execute();
                this.txtGiaBan.Text = data[0].GiaBan.ToString();
                
                this.txtSoLuong.Text = "";
                this.txtSoLuong.HintText = "Số lượng tồn kho là " + data[0].SoLuongTonKho.ToString();
            }
        }
        
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            var listcur = this.banHangBindingSource.DataSource as List<BanHang.Domain.BanHang>;
            if(listcur != null)
            {
                using(var cmd = new ThuChiAddBusiness())
                {
                    foreach (var item in listcur)
                    {
                        cmd.Thu = item.Giaban;
                        cmd.Ngay = item.NgayBan;
                        cmd.Chi = item.Giaban-10000;
                        cmd.Execute();
                    }
                }
                using(var cmd = new BanHangViewBusiness())
                {
                    cmd.ID = listcur[0].ID;
                    var rp = new InHoaDonPhieuBanHang();
                    rp.DataSource = cmd.Execute();
                    rp.ShowPreviewDialog();
                }
            }
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            var listcur = this.banHangBindingSource.DataSource as List<BanHang.Domain.BanHang>;
            if(listcur!= null)
            {
                using(var cmd = new BanHangDeleteRepository())
                {
                    cmd.ID = listcur[0].ID;
                    cmd.Execute();
                }
                this.banHangBindingSource.DataSource = null;
            }
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            var cur = this.banHangBindingSource.Current as BanHang.Domain.BanHang;
            if(cur != null && !string.IsNullOrWhiteSpace(cur.HanghoaId) && !string.IsNullOrWhiteSpace(cur.ID.ToString()))
            {
                using(var cmd = new BanHangDeleteRepository())
                {
                    cmd.ID = cur.ID;
                    cmd.HanghoaId = cur.HanghoaId;
                    cmd.Execute();
                }
                using(var cmd = new BanHangViewBusiness())
                {
                    cmd.ID = cur.ID;
                    this.banHangBindingSource.DataSource = cmd.Execute();
                }
            }
            
        }
    }
}
