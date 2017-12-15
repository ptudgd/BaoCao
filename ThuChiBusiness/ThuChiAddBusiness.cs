using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace ThuChiBusiness
{
    public class ThuChiAddBusiness:ConnectDatabase
    {
        public string Ngay { get; set; }
        public int Thu { get; set; }
        public int Chi { get; set; }
        public void Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "INSERT INTO ThuChi VALUES(@Ngay,@Thu,@Chi)";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Ngay",
                        Value = Ngay,
                        SqlDbType = System.Data.SqlDbType.Date
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Thu",
                        Value = Thu,
                        SqlDbType = System.Data.SqlDbType.Int
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Chi",
                        Value = Chi,
                        SqlDbType = System.Data.SqlDbType.Int
                    });
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
