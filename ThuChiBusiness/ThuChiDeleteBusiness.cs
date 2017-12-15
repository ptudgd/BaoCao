using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

namespace ThuChiBusiness
{
    public class ThuChiDeleteBusiness:ConnectDatabase
    {
        public string Ngay { get; set; }
        public void Execute()
        {
            
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM ThuChi WHERE Ngay=@Ngay";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Ngay",
                        Value = Ngay,
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            
        }
    }
}
