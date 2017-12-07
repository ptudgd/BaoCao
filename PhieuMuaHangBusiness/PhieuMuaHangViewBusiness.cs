using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

namespace PhieuMuaHang.Business
{
    public class PhieuMuaHangViewBusiness:ConnectDatabase
    {
        public PhieuMuaHang.Domain.PhieuMuaHang item { get; set; }
        public PhieuMuaHang.Domain.PhieuMuaHang Execute()
        {
            PhieuMuaHang.Domain.PhieuMuaHang data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM PhieuMuaHang WHERE MaHD='" + item.MaHD + "'";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data = new PhieuMuaHang.Domain.PhieuMuaHang
                            {
                                MaHD = Convert.ToString(reader["MaHD"]),
                                Khachhang = Convert.ToString(reader["Khachhang"]),
                                Ngaytao = Convert.ToDateTime(reader["Ngaytao"]),
                                Tongtien = Convert.ToInt32(reader["Tongtien"]),
                                Ghichu = Convert.ToString(reader["Ghichu"]),
                                SoLuongMua1N = Convert.ToInt32(reader["SoLuongMua1N"])
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
