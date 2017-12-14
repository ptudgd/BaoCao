using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

namespace PhieuBanHang.Repository
{
    public class BanHangAddRepository : ConnectDatabase
    {
        public BanHang.Domain.BanHang item { get; set; }
        public void Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "INSERT INTO BanHang VALUES(@ID,@TenSanPham,@SoLuong,@Giaban,@NgayBan,@NhomHanghoaId,@HanghoaId)";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@ID",
                        Value = item.ID,
                        SqlDbType = System.Data.SqlDbType.Int
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@TenSanPham",
                        Value = item.TenSanPham,
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@SoLuong",
                        Value = item.SoLuong,
                        SqlDbType = System.Data.SqlDbType.Int
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Giaban",
                        Value = item.Giaban,
                        SqlDbType = System.Data.SqlDbType.Int
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@NgayBan",
                        Value = item.NgayBan,
                        SqlDbType = System.Data.SqlDbType.DateTime
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@NhomHanghoaId",
                        Value = item.NhomHanghoaId,
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@HanghoaId",
                        Value = item.HanghoaId,
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
