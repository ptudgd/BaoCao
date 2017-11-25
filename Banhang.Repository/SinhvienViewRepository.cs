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
    public class SinhvienViewRepository : RepositoryBase
    {
        public string Maso { get; set; }

        public Sinhvien Execute()
        {
            Sinhvien data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM Sinhvien WHERE Maso = @Maso";
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@Maso", Value = this.Maso, SqlDbType = System.Data.SqlDbType.NVarChar });
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data = new Sinhvien();
                            data.Maso = Convert.ToString(reader["Maso"].vSafe());
                            data.Holot = Convert.ToString(reader["Holot"].vSafe());
                            data.Ten = Convert.ToString(reader["Ten"].vSafe());
                            data.Ngaysinh = (DateTime?)reader["Ngaysinh"].vSafe();
                            data.Gioitinh = Convert.ToBoolean(reader["Gioitinh"].vSafe());
                        }
                    }
                }
                conn.Close();
            }
            return data;
        }
    }
}
