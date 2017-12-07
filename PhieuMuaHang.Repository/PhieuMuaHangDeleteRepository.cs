using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace PhieuMuaHang.Repository
{
    public class PhieuMuaHangDeleteRepository : ConnectDatabase
    {
        public string MaHD { get; set; }

        public void Execute()
        {
            using(var conn = new SqlConnection(this.ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM PhieuMuaHang WHERE MaHD ='" + MaHD+"'";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
