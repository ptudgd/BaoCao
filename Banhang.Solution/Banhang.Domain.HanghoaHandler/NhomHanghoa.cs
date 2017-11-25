using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banhang.Domain.HanghoaHandler
{
    public class NhomHanghoa
    {
        [DisplayName("Mã nhóm")]
        public string NhomHanghoaId { get; set; }

        [DisplayName("Tên nhóm")]
        public string TenNhomHanghoa { get; set; }

        [DisplayName("Ghi chú")]
        public string Ghichu { get; set; }

        public string DisplayString
        {
            get
            {
                return this.ToString();
            }
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", this.NhomHanghoaId, this.TenNhomHanghoa, this.Ghichu);
        }
    }
}
