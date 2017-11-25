using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace KhachHang.Repository
{
    public class KhachHangListRepository : ConnectDatabase
    {
        public List<KhachHang.Domain.KhachHang> Execute()
        {
            var data = new List<KhachHang.Domain.KhachHang>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM KhachHang";
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new KhachHang.Domain.KhachHang
                            {
                                KhachhangId = Convert.ToString(reader["KhachhangId"]),
                                Ho = Convert.ToString(reader["Ho"]),
                                Tenlot = Convert.ToString(reader["Tenlot"]),
                                Ten = Convert.ToString(reader["Ten"]),
                                Gioitinh = Convert.ToBoolean(reader["Gioitinh"]),
                                Email = Convert.ToString(reader["Email"]),
                                SDT = Convert.ToString(reader["SDT"]),
                                Diachi = Convert.ToString(reader["Diachi"])

                            });
                        }
                    }
                }
            }
            return data;
        }
    }
}
