using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace NhanVien.Repository
{
    public class NhanVienSearchRepository : ConnectDatabase
    {
        public string Ten { get; set; }
        public List<NhanVien.Domain.NhanVien> Execute()
        {
            var data = new List<NhanVien.Domain.NhanVien>();
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM NhanVien WHERE Ten LIKE @Ten OR Holot LIKE @Ten";

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
                            data.Add(new Domain.NhanVien
                            {
                                NhanvienId = Convert.ToString(reader["NhanvienId"]),
                                Ten = Convert.ToString(reader["Ten"]),
                                Gioitinh = Convert.ToBoolean(reader["Gioitinh"]),
                                Holot = Convert.ToString(reader["Holot"]),
                                NgayVaolam = Convert.ToDateTime(reader["NgayVaolam"]),
                                Ngaysinh = Convert.ToDateTime(reader["Ngaysinh"])
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
