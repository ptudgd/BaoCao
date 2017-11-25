using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachHang.Domain
{
    public class KhachHang
    {
        [DisplayName("Mã khách hàng")]
        public string KhachhangId { get; set; }

        [DisplayName("Họ")]
        public string Ho { get; set; }

        [DisplayName("Tên lót")]
        public string Tenlot { get; set; }

        [DisplayName("Tên")]
        public string Ten { get; set; }

        [DisplayName("Giới tính")]
        public bool Gioitinh{get;set;}       

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Số điện thọai")]
        public string SDT { get; set; }

        [DisplayName("Địa chỉ")]
        public string Diachi { get; set; }
    }
}
