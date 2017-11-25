using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banhang.Domain
{
    public class Product
    {
        public string recid
        {
            get
            {
                return Maso;
            }
            set
            {
                Maso = value;
            }
        }

        [DisplayName("Mã số")]
        public string Maso { get; set; }

        [DisplayName("Tên hàng hóa")]
        public string Ten { get; set; }

        [DisplayName("Giá bán")]
        public double Giaban { get; set; }

        [DisplayName("Nhóm hàng hóa")]
        public string Nhom { get; set; }
    }
}
