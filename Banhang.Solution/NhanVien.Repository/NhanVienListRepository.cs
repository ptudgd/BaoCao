using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace NhanVien.Repository
{
    public class NhanVienListRepository : ConnectDatabase
    {
        public List<NhanVien.Domain.NhanVien> Execute()
        {
            var data = new List<NhanVien.Domain.NhanVien>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM NhanVien";
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new NhanVien.Domain.NhanVien
                            {
                                NhanvienId = Convert.ToString(reader["NhanvienId"]),
                                Holot = Convert.ToString(reader["Holot"]),
                                Ten = Convert.ToString(reader["Ten"]),
                                Gioitinh = Convert.ToBoolean(reader["Gioitinh"]),
                                Ngaysinh = Convert.ToDateTime(reader["Ngaysinh"]),
                                NgayVaolam = Convert.ToDateTime(reader["NgayVaolam"])
                            });
                        }
                    }
                }
            }
            return data;
        }
    }
}
