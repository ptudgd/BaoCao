using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

namespace PhieuBanHangSaveBusiness
{
    public class BanHangViewBusiness:ConnectDatabase
    {
        public int ID { get; set; }
        public string HanghoaId { get; set; }
        public List<BanHang.Domain.BanHang> Execute()
        {
            var data = new List<BanHang.Domain.BanHang>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM BanHang WHERE ID=@ID";
                    if (!string.IsNullOrWhiteSpace(HanghoaId))
                    {
                        cmd.CommandText = "SELECT * FROM BanHang WHERE ID=@ID AND HanghoaId=@HanghoaId";
                        cmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@HanghoaId",
                            Value = HanghoaId,
                            SqlDbType = System.Data.SqlDbType.NVarChar
                        });
                    }
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@ID",
                        Value = ID,
                        SqlDbType = System.Data.SqlDbType.Int
                    });
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new BanHang.Domain.BanHang
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                HanghoaId = Convert.ToString(reader["HanghoaID"]),
                                NhomHanghoaId = Convert.ToString(reader["NhomHanghoaID"]),
                                SoLuong = Convert.ToInt32(reader["SoLuong"]),
                                Giaban = Convert.ToInt32(reader["Giaban"]),
                                NgayBan = Convert.ToString(reader["NgayBan"]),
                                TenSanPham = Convert.ToString(reader["TenSanPham"])

                            });
                        }
                    }
                }
            }
            return data;
        }
    }
}
