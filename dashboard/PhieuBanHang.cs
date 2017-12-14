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
namespace dashboard
{
    public partial class PhieuBanHang : UserControl
    {
        public PhieuBanHang()
        {
            InitializeComponent();
            this.txtGiaBan.Hide();
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
        
        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new BanHang.Domain.BanHang();
                data.HanghoaId = this.cbbHangHoa.SelectedValue.ToString();
                data.NhomHanghoaId = this.cbbNhomHangHoa.SelectedValue.ToString();
                data.TenSanPham = this.cbbHangHoa.Text;
                data.NgayBan = DateTime.Now.ToString();
                data.SoLuong = Convert.ToInt32(this.txtSoLuong.Text);
                data.Giaban = Convert.ToInt32(this.txtGiaBan.Text);
                this.banHangBindingSource.Add(data);
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
    }
}
