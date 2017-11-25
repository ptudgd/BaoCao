using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhieuBanHang.Domain
{
    public class PhieuBanHang
    {
        [DisplayName("Mã HĐ")]
        public string MaHD { get; set; }

        [DisplayName("Nhân viên")]
        public string Nhanvien { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime Ngaytao { get; set; }

        [DisplayName("Tổng tiền")]
        public int Tongtien { get; set; }

        [DisplayName("Ghi chú")]
        public string Ghichu { get; set; }

        [DisplayName("Tổng hàng bán trong một ngày")]
        public int TongHangHoa1N { get; set; }
    }
}
