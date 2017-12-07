using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

namespace KhachHangBusiness
{
    public class KhachHangViewBusiness:ConnectDatabase
    {
        public KhachHang.Domain.KhachHang item { get; set; }
        public KhachHang.Domain.KhachHang Execute()
        {
            KhachHang.Domain.KhachHang data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM KhachHang WHERE KhachhangId='" + item.KhachhangId + "'";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data = new KhachHang.Domain.KhachHang
                            {
                                KhachhangId = Convert.ToString(reader["KhachhangId"]),
                                Ho = Convert.ToString(reader["Ho"]),
                                Tenlot = Convert.ToString(reader["Tenlot"]),
                                Ten = Convert.ToString(reader["Ten"]),
                                Gioitinh = Convert.ToBoolean(reader["Gioitinh"]),
                                SDT = Convert.ToString(reader["SDT"]),
                                Diachi = Convert.ToString(reader["Diachi"])
                            };
                        }
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
