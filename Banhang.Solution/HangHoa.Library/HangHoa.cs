using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangHoa.Domain
{
    public class HangHoa
    {
        [DisplayName("Mã hàng hóa")]
        public string HanghoaId { get; set; }

        [DisplayName("Tên hàng hóa")]
        public string TenHanghoa { get; set; }

        [DisplayName("Giá bán")]
        public int GiaBan { get; set; }

        [DisplayName("Mô tả")]
        public string Mota { get; set; }

        [DisplayName("Số lượng tồn kho")]
        public int SoLuongTonKho { get; set; }

        [DisplayName("Mã nhóm hàng hóa")]
        public string NhomHanghoaId { get; set; }
        
    }
}
