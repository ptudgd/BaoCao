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
    public class SinhvienInsertRepository : RepositoryBase
    {
        public Sinhvien item { get; set; }

        public void Execute()
        {
            using (var conn = new SqlConnection(this.ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "INSERT INTO SINHVIEN(Maso, Holot, Ten, Ngaysinh, Gioitinh) values(@Maso, @Holot, @Ten, @Ngaysinh, @Gioitinh)";
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
