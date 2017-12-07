using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BaoCao.Library;
namespace NhanVien.Business
{
    public class NhanVienViewBusiness : ConnectDatabase
    {
        public NhanVien.Domain.NhanVien item { get; set; }
        public NhanVien.Domain.NhanVien Execute()
        {
            NhanVien.Domain.NhanVien data  = null;
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM NhanVien WHERE NhanvienId='" + item.NhanvienId + "'";
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data = new NhanVien.Domain.NhanVien
                            {
                                NhanvienId = Convert.ToString(reader["NhanvienId"]),
                                Ten = Convert.ToString(reader["Ten"]),
                                Holot = Convert.ToString(reader["Holot"]),
                                Gioitinh = Convert.ToBoolean(reader["Gioitinh"]),
                                Ngaysinh = Convert.ToDateTime(reader["Ngaysinh"]),
                                NgayVaolam = Convert.ToDateTime(reader["NgayVaolam"])
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
