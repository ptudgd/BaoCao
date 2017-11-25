using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Banhang.Domain.HanghoaHandler;
using Banhang.Library;

namespace Banhang.Repository.HanghoaHandler
{
    public class HanghoaListRepository : RepositoryBase
    {
        public string NhomHanghoaId { get; set; }
        public List<Hanghoa> Execute()
        {
            var data = new List<Hanghoa>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM Hanghoa";
                    
                    if (!string.IsNullOrWhiteSpace(this.NhomHanghoaId))
                    {
                        cmd.CommandText = "SELECT * FROM Hanghoa where NhomHanghoaId = @NhomHanghoaId";
                        cmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@NhomHanghoaId",
                            Value = this.NhomHanghoaId.vToSqlValue(),
                            SqlDbType = System.Data.SqlDbType.NVarChar
                        });
                    }
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new Hanghoa
                            {
                                HanghoaId = Convert.ToString(reader["HanghoaId"].vSafe()),
                                TenHanghoa = Convert.ToString(reader["TenHanghoa"].vSafe()),
                                GiaBan = Convert.ToDouble(reader["GiaBan"].vSafe()),
                                Mota = Convert.ToString(reader["Mota"].vSafe()),
                                SoLuongTonKho = Convert.ToInt32(reader["SoLuongTonKho"].vSafe()),
                                NhomHanghoaId = Convert.ToString(reader["NhomHanghoaId"].vSafe())
                            });
                        }
                    }
                }
                conn.Close();
            }
            return data;
        }
    }
}
