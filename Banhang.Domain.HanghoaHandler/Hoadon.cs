using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banhang.Domain.HanghoaHandler
{
    public class Hoadon
    {
        [DisplayName("Mã HĐ")]
        public string HoadonId { get; set; }

        [DisplayName("Nhân viên")]
        public string NhanvienId { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime? NgayHoadon { get; set; }

        [DisplayName("Tổng tiền")]
        public long Tongtien { get; set; }

        [DisplayName("Ghi chú")]
        public string Ghichu { get; set; }
    }
}
