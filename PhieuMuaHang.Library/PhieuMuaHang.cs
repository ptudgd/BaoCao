using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhieuMuaHang.Domain
{
    public class PhieuMuaHang
    {

        [DisplayName("Mã HĐ")]
        public string MaHD { get; set; }

        [DisplayName("Tên khách hàng")]
        public string Khachhang { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime Ngaytao { get; set; }

        [DisplayName("Tổng tiền")]
        public int Tongtien { get; set; }

        [DisplayName("Ghi chú")]
        public string Ghichu { get; set; }

        [DisplayName("Số lượng mua trong 1 ngày")]
        public int SoLuongMua1N { get; set; }
    }
}
