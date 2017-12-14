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
        public string date1 { get; set; }
        public string date2 { get; set; }
        public List<ThuChi.Domain.ThuChi> Execute()
        {
            List<ThuChi.Domain.ThuChi> data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    if (!string.IsNullOrWhiteSpace(date1) && !string.IsNullOrWhiteSpace(date2))
                    {
                        cmd.CommandText = "SELECT * FROM ThuChi WHERE Ngay BETWEEN " + date1 + " AND " + date2 ;
                        
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM ThuChi";
                    }
                    using(var reader = cmd.ExecuteReader())
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
