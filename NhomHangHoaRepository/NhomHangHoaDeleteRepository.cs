using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

namespace NhomHangHoaRepository
{
    public class NhomHangHoaDeleteRepository : ConnectDatabase
    {
        public string NhomHanghoaId { get; set; }
        public void Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM NhomHangHoa WHERE NhomHanghoaId='" + NhomHanghoaId + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
