using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhomHangHoa.Domain
{
    public class NhomHangHoa
    {
        

        [DisplayName("Tên nhóm hàng hóa")]
        public string TenNhomHanghoa { get; set; }

        [DisplayName("Mã nhóm hàng hóa")]
        public string NhomHanghoaId { get; set; }
        [DisplayName("Ghi chú")]
        public string GhiChu { get; set; }
    }
}
