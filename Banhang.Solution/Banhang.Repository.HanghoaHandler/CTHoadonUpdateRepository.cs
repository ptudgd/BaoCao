using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Banhang.Domain.HanghoaHandler;
using Banhang.Library;

namespace Banhang.Repository.HanghoaHandler
{
    public class CTHoadonUpdateRepository : RepositoryBase
    {
        public CTHoadon item { get; set; }

        public void Execute()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE CTHoadon SET HanghoaId = @HanghoaId, TenHanghoa = @TenHanghoa, Soluong = @Soluong, Dongia = @Dongia , Ghichu = @Ghichu  WHERE CTHoadonId = @CTHoadonId";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@CTHoadonId",
                        Value = item.CTHoadonId.vToSqlValue(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@HoadonId",
                        Value = item.HoadonId.vToSqlValue(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@HanghoaId",
                        Value = item.HanghoaId.vToSqlValue(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@TenHanghoa",
                        Value = item.TenHanghoa.vToSqlValue(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Soluong",
                        Value = item.Soluong.vToSqlValue(),
                        SqlDbType = System.Data.SqlDbType.BigInt
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Dongia",
                        Value = item.Dongia.vToSqlValue(),
                        SqlDbType = System.Data.SqlDbType.BigInt
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Ghichu",
                        Value = item.Ghichu.vToSqlValue(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });


                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
