using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banhang.Domain.HanghoaHandler
{
    public class Hanghoa
    {
        public string recid
        {
            get { return HanghoaId; }
        }

        [DisplayName("Mã hàng")]
        public string HanghoaId { get; set; }

        [DisplayName("Tên hàng")]
        public string TenHanghoa { get; set; }

        [DisplayName("Giá bán")]
        public double GiaBan { get; set; }

        [DisplayName("Mô tả")]
        public string Mota { get; set; }

        [DisplayName("Số lượng")]
        public int SoLuongTonKho { get; set; }

        [DisplayName("Nhóm hàng")]
        public string NhomHanghoaId { get; set; }
    }
}
