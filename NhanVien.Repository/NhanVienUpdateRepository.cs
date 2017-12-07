using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
using System.Windows.Forms;
using NhanVien.Repository;
namespace NhanVien.Repository
{
    public class NhanVienUpdateRepository : ConnectDatabase
    {
        public NhanVien.Domain.NhanVien item { get; set; }
        public void Execute()
        {
            using(var cmd = new NhanVienDeleteRepository())
            {
                cmd.NhanvienId = item.NhanvienId;
                cmd.Execute();
            }
            using(var cmd = new NhanVienAddRepository())
            {
                cmd.item = item;
                if (cmd.Execute())
                {
                    MessageBox.Show("Sửa thành công!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            using(var cmd = new NhanVienListRepository())
            {
                cmd.Execute();
            }
        }
    }
}
