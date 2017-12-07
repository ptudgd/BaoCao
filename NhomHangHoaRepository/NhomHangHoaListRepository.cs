using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace NhomHangHoaRepository
{
    public class NhomHangHoaListRepository : ConnectDatabase
    {
       public List<NhomHangHoa.Domain.NhomHangHoa> Execute()
        {
            var data = new List<NhomHangHoa.Domain.NhomHangHoa>();
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM NhomHanghoa";
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new NhomHangHoa.Domain.NhomHangHoa
                            {
                                NhomHanghoaId = Convert.ToString(reader["NhomHanghoaId"]),
                                TenNhomHanghoa = Convert.ToString(reader["TenNhomHanghoa"]),
                                GhiChu = Convert.ToString(reader["GhiChu"])
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
