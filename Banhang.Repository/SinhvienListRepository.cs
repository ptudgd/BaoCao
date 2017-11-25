using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Banhang.Domain;
using Banhang.Library;

namespace Banhang.Repository
{
    public class SinhvienListRepository : RepositoryBase
    {
        public List<Sinhvien> Execute()
        {
            var data = new List<Sinhvien>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM Sinhvien";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new Sinhvien
                            {
                                Maso = Convert.ToString(reader["Maso"].vSafe()),
                                Holot = Convert.ToString(reader["Holot"].vSafe()),
                                Ten = Convert.ToString(reader["Ten"].vSafe()),
                                Ngaysinh = (DateTime?)reader["Ngaysinh"].vSafe(),
                                Gioitinh = Convert.ToBoolean(reader["Gioitinh"].vSafe())
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
