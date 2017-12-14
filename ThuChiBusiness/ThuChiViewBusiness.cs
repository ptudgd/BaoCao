using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

namespace ThuChiBusiness
{
    public class ThuChiViewBusiness:ConnectDatabase
    {
        public ThuChi.Domain.ThuChi item { get; set; }
        public ThuChi.Domain.ThuChi Execute()
        {
            ThuChi.Domain.ThuChi data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM ThuChi WHERE ThuChiId='" + item.Ngay + "'";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data = new ThuChi.Domain.ThuChi
                            {
                                Ngay = Convert.ToDateTime(reader["Ngay"]),
                                Thu = Convert.ToInt32(reader["Thu"]),
                                Chi = Convert.ToInt32(reader["Chi"])                                
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
