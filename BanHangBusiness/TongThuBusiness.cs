using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

namespace BanHangBusiness
{
    public class TongThuBusiness : ConnectDatabase
    {
        public BanHang.Domain.BanHang item { get; set; }
        public BanHang.Domain.BanHang Execute()
        {
            BanHang.Domain.BanHang data = null;
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT SUM(SoLuong),SUM(Giaban) FROM BanHang WHERE CONVERT(date,NgayBan) = @NgayBan";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@NgayBan",
                        Value = item.NgayBan,
                        SqlDbType = System.Data.SqlDbType.DateTime
                    });
                    using(var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data.SoLuong = Convert.ToInt32(reader["SoLuong"]);
                            data.Giaban = Convert.ToInt32(reader["Giaban"]);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
