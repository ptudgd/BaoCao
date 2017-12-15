using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace PhieuBanHang.Repository
{
    public class BanHangDeleteRepository:ConnectDatabase
    {
        public int ID { get; set; }
        public string HanghoaId { get; set; }
        public void Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM BanHang WHERE ID=@ID";
                    if (!string.IsNullOrWhiteSpace(HanghoaId))
                    {
                        cmd.CommandText = "DELETE FROM BanHang WHERE ID=@ID AND HanghoaId=@HanghoaId";
                        cmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@HanghoaId",
                            Value = HanghoaId,
                            SqlDbType = System.Data.SqlDbType.NVarChar
                        });
                    }
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@ID",
                        Value = ID,
                        SqlDbType = System.Data.SqlDbType.Int
                    });
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
