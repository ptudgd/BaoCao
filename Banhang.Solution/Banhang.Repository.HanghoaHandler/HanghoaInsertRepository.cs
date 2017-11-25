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
    public class HanghoaInsertRepository : RepositoryBase
    {
        public Hanghoa item { get; set; }

        public void Execute()
        {
            using (var conn = new SqlConnection(this.ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "INSERT INTO Hanghoa(HanghoaId, TenHanghoa, GiaBan, Mota, SoLuongTonKho, NhomHanghoaId) values(@HanghoaId, @TenHanghoa, @GiaBan, @Mota, @SoLuongTonKho, @NhomHanghoaId)";
                    cmd.Parameters.Add(new SqlParameter { 
                        ParameterName = "@HanghoaId", 
                        Value = item.HanghoaId.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.NVarChar 
                    });
                    cmd.Parameters.Add(new SqlParameter { 
                        ParameterName = "@TenHanghoa", 
                        Value = item.TenHanghoa.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.NVarChar 
                    });
                    cmd.Parameters.Add(new SqlParameter {
                        ParameterName = "@GiaBan",
                        Value = item.GiaBan.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.Float 
                    });
                    cmd.Parameters.Add(new SqlParameter {
                        ParameterName = "@Mota",
                        Value = item.Mota.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.NVarChar 
                    });
                    cmd.Parameters.Add(new SqlParameter { 
                        ParameterName = "@SoLuongTonKho", 
                        Value = item.SoLuongTonKho.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.Int 
                    });

                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@NhomHanghoaId",
                        Value = item.NhomHanghoaId.vToSqlValue(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
