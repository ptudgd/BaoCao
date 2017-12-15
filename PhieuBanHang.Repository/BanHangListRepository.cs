using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace PhieuBanHang.Repository
{
    class BanHangListRepository:ConnectDatabase
    {
        public string data1 { get; set; }
        public string data2 { get; set; }
        public List<BanHang.Domain.BanHang> Execute()
        {
            var data = new List<BanHang.Domain.BanHang>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM BanHang WHERE CONVERT(datetime,NgayBan) BEETWEN '" + data1 + "' AND '" + data2 + "'";
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new BanHang.Domain.BanHang
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                TenSanPham = Convert.ToString(reader["TenSanPham"]),
                                SoLuong = Convert.ToInt32(reader["SoLuong"]),
                                Giaban = Convert.ToInt32(reader["Giaban"]),
                                NgayBan = Convert.ToString(reader["NgayBan"]),
                                NhomHanghoaId = Convert.ToString(reader["NhomHanghoaId"]),
                                HanghoaId = Convert.ToString(reader["HanghoaId"])
                            });
                        }
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
