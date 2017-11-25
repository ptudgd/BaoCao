using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaCungCap.Domain
{
    public class NhaCungCap
    {
        [DisplayName("Mã nhà cung cấp")]
        public string NhacungcapId { get; set; }


        [DisplayName("Tên nhà cung cấp")]
        public string Ten { get; set; }

        [DisplayName("Mặt hàng cung cấp")]
        public string HangHoaCungCap { get; set; }

        [DisplayName("Số điện thoại")]
        public string SDT { get; set; }

        [DisplayName("Địa chỉ")]
        public string Diachi { get; set; }

        [DisplayName("Nhóm hàng hóa")]
        public string NhomhanghoaId { get; set; }
    }
}
