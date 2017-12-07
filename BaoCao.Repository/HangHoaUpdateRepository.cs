using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaoCao.Repository
{
    public class HangHoaUpdateRepository : ConnectDatabase
    {
        public HangHoa.Domain.HangHoa item { get; set; }
        public void Execute()
        {
            using(var cmd = new HangHoaDeleteRepository())
            {
                cmd.hangHoaId = item.HanghoaId;
                cmd.Execute();
            }
            using(var cmd = new HangHoaAddRepository())
            {
                cmd.item = item;
                if (cmd.Execute())
                {
                    MessageBox.Show("Sửa thành công!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            using(var cmd = new HangHoaListRepository())
            {
                cmd.Execute();
            }
        }
    }
}
