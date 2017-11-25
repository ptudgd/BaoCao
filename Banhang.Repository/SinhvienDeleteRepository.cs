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
    public class SinhvienDeleteRepository : RepositoryBase
    {
        public string Maso { get; set; }

        public void Execute()
        {
            using (SqlConnection conn = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM SINHVIEN WHERE Maso = @Maso";
                    cmd.Parameters.Add(new SqlParameter { 
                        ParameterName = "@Maso", 
                        Value = this.Maso, 
                        SqlDbType = System.Data.SqlDbType.NVarChar 
                    });

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
