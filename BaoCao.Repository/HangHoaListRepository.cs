using BaoCao.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BaoCao.Repository
{
    public class HangHoaListRepository : ConnectDatabase
    {
        public string NhomHanghoaId { get; set; }
        public string HanghoaId { get; set; }
        public List<HangHoa.Domain.HangHoa> Execute()
        {
            var data = new List<HangHoa.Domain.HangHoa>(); 
            // không cần add cái thư viện HangHoa.Library vì cái namespace nằm riêng,
            // của thầy nó nằm chung trong 1 project Library gồm nhiều class
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM HangHoa";
                    if (!string.IsNullOrWhiteSpace(NhomHanghoaId))
                    {
                        cmd.CommandText = "SELECT * FROM HangHoa WHERE NhomHanghoaId='" + NhomHanghoaId + "'";
                    }
                    if (!string.IsNullOrWhiteSpace(HanghoaId))
                    {
                        cmd.CommandText = "SELECT * FROM HangHoa WHERE HanghoaId=@HanghoaId";
                        cmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@HanghoaId",
                            Value = HanghoaId,
                            SqlDbType = System.Data.SqlDbType.NVarChar
                        });
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new HangHoa.Domain.HangHoa
                            {
                                HanghoaId = Convert.ToString(reader["HanghoaId"]),
                                TenHanghoa = Convert.ToString(reader["TenHanghoa"]),
                                GiaBan = Convert.ToInt32(reader["GiaBan"]),
                                Mota = Convert.ToString(reader["Mota"]),
                                SoLuongTonKho = Convert.ToInt32(reader["SoLuongTonKho"]),
                                NhomHanghoaId = Convert.ToString(reader["NhomHanghoaId"])
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
