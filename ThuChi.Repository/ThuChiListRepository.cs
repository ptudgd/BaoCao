using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BaoCao.Library;
namespace ThuChi.Repository
{
    public class ThuChiListRepository : ConnectDatabase
    {
        public string datetimepicker1 { get; set; }
        public string datetimepicker2 { get; set; }

        public List<ThuChi.Domain.ThuChi> Execute()
        {
            var data = new List<ThuChi.Domain.ThuChi>();
            using(var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM ThuChi WHERE Ngay BETWEEN '" + datetimepicker1 + "' AND '" + datetimepicker2 + "'";
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
                }
            }
            return data;
        }
    }
}
