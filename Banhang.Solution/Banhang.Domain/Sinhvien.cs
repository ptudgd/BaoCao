using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banhang.Domain
{
    public class Sinhvien
    {
        [DisplayName("Mã số")]
        public string Maso { get; set; }

        [DisplayName("Họ lót")]
        public string Holot { get; set; }

        [DisplayName("Tên")]
        public string Ten { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime? Ngaysinh { get; set; }
        public string NgaysinhString
        {
            get
            {
                if (Ngaysinh == null)
                    return "";
                return Ngaysinh.Value.ToString("dd-MM-yyyy");
            }
        }

        [DisplayName("Giới tính")]
        public bool? Gioitinh { get; set; }
    }
}
