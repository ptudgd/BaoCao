using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang.Domain
{
    public class BanHang
    {
        [DisplayName("ID")]
        public int ID { get; set; }
        [DisplayName("Tên hàng hóa")]
        public string TenSanPham { get; set; }

        [DisplayName("Số lượng")]
        public int SoLuong { get; set; }
        [DisplayName("Giá bán")]
        public int Giaban { get; set; }
        [DisplayName("Thời gian")]
        public string NgayBan { get; set; }

        [DisplayName("Mã nhóm hàng hóa")]
        public string NhomHanghoaId { get; set; }

        [DisplayName("Mã hàng hóa")]
        public string HanghoaId { get; set; }
    }
}
