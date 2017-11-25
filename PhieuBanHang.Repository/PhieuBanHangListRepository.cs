using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace PhieuBanHang.Repository
{
    public class PhieuBanHangListRepository : ConnectDatabase
    {
        public string datetimepicker1 { get; set; }
        public string datetimepicker2 { get; set; }

        public List<PhieuBanHang.Domain.PhieuBanHang> Execute()
        {
            var data = new List<PhieuBanHang.Domain.PhieuBanHang>();
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM PhieuBanHang WHERE Ngaytao BETWEEN '" + datetimepicker1 + "' AND '" + datetimepicker2 + "'";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new Domain.PhieuBanHang
                            {
                                MaHD = Convert.ToString(reader["MaHD"]),
                                Nhanvien = Convert.ToString(reader["Nhanvien"]),
                                Ngaytao = Convert.ToDateTime(reader["Ngaytao"]),
                                Tongtien = Convert.ToInt32(reader["Tongtien"]),
                                Ghichu = Convert.ToString(reader["Ghichu"]),
                                TongHangHoa1N = Convert.ToInt32(reader["TongHangHoa1N"])
                            });
                        }
                    }
                }
            }
            return data;
        }
    }
}
