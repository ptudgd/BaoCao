using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace NhaCungCap.Repository
{
    public class NhaCungCapDeleteRepository : ConnectDatabase
    {
        public string NhacungcapId { get; set; }
        public void Execute()
        {
            using (var conn = new SqlConnection(this.ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM NhaCungCap WHERE NhacungcapId ='" + NhacungcapId + "'";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
