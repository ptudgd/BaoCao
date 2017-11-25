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
    public class HoadonSearchRepository : RepositoryBase
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public List<Hoadon> Execute()
        {
            var data = new List<Hoadon>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = @"SELECT * FROM Hoadon 
                                        WHERE (@From <= NgayHoadon AND NgayHoadon <= @To) 
                                        OR NgayHoadon is null
                                        OR @From is null
                                        OR @To is null
                                      ";
                    if (this.From != null)
                    {
                        this.From = this.From.Value.Date;
                    }
                    if (this.To != null)
                    {
                        this.To = this.To.Value.Date.AddDays(1);
                    }
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@From",
                        Value = this.From.vToSqlValue(),
                        SqlDbType = System.Data.SqlDbType.Date
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@To",
                        Value = this.To.vToSqlValue(),
                        SqlDbType = System.Data.SqlDbType.Date
                    });
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new Hoadon
                            {
                                HoadonId = Convert.ToString(reader["HoadonId"].vSafe()),
                                NhanvienId = Convert.ToString(reader["NhanvienId"].vSafe()),
                                NgayHoadon = Convert.ToDateTime(reader["NgayHoadon"].vSafe()),
                                Tongtien = Convert.ToInt64(reader["Tongtien"].vSafe()),
                                Ghichu = Convert.ToString(reader["Ghichu"].vSafe()),
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
