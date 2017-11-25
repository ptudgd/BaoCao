using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Banhang.Domain;
using Banhang.Library;

namespace Banhang.Repository
{
    public class SinhvienUpdateRepository : RepositoryBase
    {
        public Sinhvien item { get; set; }

        public void Execute()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Sinhvien SET Holot = @Holot, Ten = @Ten, Ngaysinh = @Ngaysinh, Gioitinh = @Gioitinh WHERE Maso = @Maso";
                    cmd.Parameters.Add(new SqlParameter { 
                        ParameterName = "@Maso", 
                        Value = item.Maso.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.NVarChar 
                    });
                    cmd.Parameters.Add(new SqlParameter { 
                        ParameterName = "@Holot", 
                        Value = item.Holot.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.NVarChar 
                    });
                    cmd.Parameters.Add(new SqlParameter { 
                        ParameterName = "@Ten", 
                        Value = item.Ten.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.NVarChar 
                    });
                    cmd.Parameters.Add(new SqlParameter { 
                        ParameterName = "@Ngaysinh", 
                        Value = item.Ngaysinh.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.DateTime 
                    });
                    cmd.Parameters.Add(new SqlParameter { 
                        ParameterName = "@Gioitinh", 
                        Value = item.Gioitinh.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.Bit 
                    });

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
