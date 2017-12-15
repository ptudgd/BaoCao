using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

namespace ThuChiChart
{
    public class ThuChiChartListRepository:ConnectDatabase
    {
        
        public string Ngay { get; set; }
        public List<ThuChi.Domain.ThuChi> Execute()
        {
            var data = new List<ThuChi.Domain.ThuChi>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM ThuChi WHERE CONVERT(date,Ngay)=@Ngay";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Ngay",
                        Value = Ngay,
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new ThuChi.Domain.ThuChi
                            {
                                Ngay = Convert.ToDateTime(reader["Ngay"]),
                                Thu = Convert.ToInt32(reader["Thu"]),
                                Chi = Convert.ToInt32(reader["Chi"])
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
