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
    public class CTHoadonListRepository : RepositoryBase
    {
        public string HoadonId { get; set; }
        public List<CTHoadon> Execute()
        {
            var data = new List<CTHoadon>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM CTHoadon WHERE @HoadonId = HoadonId";

                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@HoadonId",
                        Value = this.HoadonId,
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new CTHoadon
                            {
                                CTHoadonId = Convert.ToString(reader["CTHoadonId"].vSafe()),
                                HoadonId = Convert.ToString(reader["HoadonId"].vSafe()),
                                HanghoaId = Convert.ToString(reader["HanghoaId"].vSafe()),
                                TenHanghoa = Convert.ToString(reader["TenHanghoa"].vSafe()),
                                Soluong = Convert.ToInt64(reader["Soluong"].vSafe()),
                                Dongia = Convert.ToInt64(reader["Dongia"].vSafe()),
                                Ghichu = Convert.ToString(reader["Ghichu"].vSafe())
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
