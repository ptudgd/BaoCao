using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace PhieuMuaHang.Repository
{
    public class PhieuMuaHangListRepository : ConnectDatabase
    {
        public string datetimepicker1 { get; set; }
        public string datetimepicker2 { get; set; }
        public List<PhieuMuaHang.Domain.PhieuMuaHang> Execute()
        {
            
            var data = new List<PhieuMuaHang.Domain.PhieuMuaHang>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM PhieuMuaHang WHERE Ngaytao BETWEEN '" + datetimepicker1 + "' AND '" + datetimepicker2 + "'";
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new PhieuMuaHang.Domain.PhieuMuaHang
                            {
                                MaHD = Convert.ToString(reader["MaHD"]),
                                Khachhang = Convert.ToString(reader["Khachhang"]),
                                Ngaytao = Convert.ToDateTime(reader["Ngaytao"]),
                                Tongtien = Convert.ToInt32(reader["Tongtien"]),
                                Ghichu = Convert.ToString(reader["Ghichu"]),
                                SoLuongMua1N = Convert.ToInt32(reader["SoLuongMua1N"])
                            });
                        }
                    }
                }
            }
            return data;
        }
    }
}
