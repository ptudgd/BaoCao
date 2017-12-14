using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

namespace NhomHangHoaRepository
{
    public class NhomHangHoaLoadRepository : ConnectDatabase
    {
        public string NhomHanghoaId { get; set; }
        public List<NhomHangHoa.Domain.NhomHangHoa> Execute()
        {
            var data = new List<NhomHangHoa.Domain.NhomHangHoa>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM NhomHangHoa WHERE NhomHanghoaId=@NhomHanghoaId";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        Value = NhomHanghoaId,
                        ParameterName = "@NhomHanghoaId",
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new NhomHangHoa.Domain.NhomHangHoa
                            {
                                TenNhomHanghoa = Convert.ToString(reader["TenNhomHanghoa"]),
                                NhomHanghoaId = Convert.ToString(reader["NhomHanghoaId"]),
                                GhiChu = Convert.ToString(reader["Ghichu"])
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
