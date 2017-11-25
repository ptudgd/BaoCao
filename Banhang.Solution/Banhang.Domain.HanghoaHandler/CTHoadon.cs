using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banhang.Domain.HanghoaHandler
{
    public class CTHoadon
    {
        [DisplayName("Mã số")]
        public string CTHoadonId { get; set; }

        [DisplayName("Mã HĐ")]
        public string HoadonId { get; set; }

        [DisplayName("Mã hàng")]
        public string HanghoaId { get; set; }

        [DisplayName("Tên hàng")]
        public string TenHanghoa { get; set; }

        [DisplayName("Số lượng")]
        public double Soluong { get; set; }

        [DisplayName("Đơn giá")]
        public double Dongia { get; set; }

        [DisplayName("Ghi chú")]
        public string Ghichu { get; set; }
    }
}
