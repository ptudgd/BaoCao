using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace KhachHang.Repository
{
    public class KhachHangDeleteRepository : ConnectDatabase
    {
        public string KhachhangId { get; set; }
        public void Execute()
        {
            using (var conn = new SqlConnection(this.ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM KhachHang WHERE KhachhangId ='" + KhachhangId + "'";


                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
