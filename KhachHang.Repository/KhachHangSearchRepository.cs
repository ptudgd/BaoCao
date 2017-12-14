using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
namespace KhachHang.Repository
{
    public class KhachHangSearchRepository:ConnectDatabase
    {
        public string Ten { get; set; }
        public List<KhachHang.Domain.KhachHang> Execute()
        {
            var data = new List<KhachHang.Domain.KhachHang>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM KhachHang WHERE Ten LIKE @Ten";

                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Ten",
                        Value = "%" + Ten + "%",
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new Domain.KhachHang
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

                        reader.Close();
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
