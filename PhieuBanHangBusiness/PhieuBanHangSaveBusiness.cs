using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace PhieuBanHangSaveBusiness111
{
    public class PhieuBanHangSaveBusiness : ConnectDatabase
    {
        public BanHang.Domain.BanHang item { get; set; }

        public BanHang.Domain.BanHang Execute()
        {
            var data = new BanHang.Domain.BanHang();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM BanHang";
                    
                    conn.Close();
                }
            }
            return data;
        }
    }
}
