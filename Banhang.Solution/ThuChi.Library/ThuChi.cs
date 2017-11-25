using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuChi.Domain
{
    public class ThuChi
    {
        [DisplayName("Ngày")]
        public DateTime Ngay { get; set; }

        [DisplayName("Thu")]
        public int Thu { get; set; }

        [DisplayName("Chi")]
        public int Chi { get; set; }

    }
}
