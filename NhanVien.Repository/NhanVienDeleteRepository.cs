using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BaoCao.Library;
namespace NhanVien.Repository
{
    public class NhanVienDeleteRepository : ConnectDatabase
    {
        public string NhanvienId { get; set; }

        public void Execute()
        {
            using (var conn = new SqlConnection(this.ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM NhanVien WHERE NhanvienId ='" + NhanvienId + "'";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
