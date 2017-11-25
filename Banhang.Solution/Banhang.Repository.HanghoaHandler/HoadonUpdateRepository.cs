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
    public class HoadonUpdateRepository : RepositoryBase
    {
        public Hoadon item { get; set; }

        public void Execute()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Hoadon SET NhanvienId = @NhanvienId, NgayHoadon = @NgayHoadon, Tongtien = @Tongtien, Ghichu = @Ghichu WHERE HoadonId = @HoadonId";
                    cmd.Parameters.Add(new SqlParameter {
                        ParameterName = "@HoadonId",
                        Value = item.HoadonId.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.NVarChar 
                    });
                    cmd.Parameters.Add(new SqlParameter {
                        ParameterName = "@NhanvienId",
                        Value = item.NhanvienId.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.NVarChar 
                    });
                    cmd.Parameters.Add(new SqlParameter {
                        ParameterName = "@NgayHoadon",
                        Value = item.NgayHoadon.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.DateTime 
                    });
                    cmd.Parameters.Add(new SqlParameter {
                        ParameterName = "@Tongtien",
                        Value = item.Tongtien.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.BigInt 
                    });
                    cmd.Parameters.Add(new SqlParameter {
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
