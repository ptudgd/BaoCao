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
    public class NhomHanghoaUpdateRepository : RepositoryBase
    {
        public NhomHanghoa item { get; set; }

        public void Execute()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE NhomHanghoa SET "
                    + "TenNhomHanghoa = @TenNhomHanghoa, Ghichu = @Ghichu " 
                    + "WHERE NhomHanghoaId = @NhomHanghoaId";
                    cmd.Parameters.Add(new SqlParameter {
                        ParameterName = "@NhomHanghoaId",
                        Value = item.NhomHanghoaId.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.NVarChar 
                    });
                    cmd.Parameters.Add(new SqlParameter { 
                        ParameterName = "@TenNhomHanghoa", 
                        Value = item.TenNhomHanghoa.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.NVarChar 
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
