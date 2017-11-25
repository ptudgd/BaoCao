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
    public class HoadonDeleteRepository : RepositoryBase
    {
        public string HoadonId { get; set; }

        public void Execute()
        {
            using (var conn = new SqlConnection(this.ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM Hoadon WHERE HoadonId = @HoadonId";
                    cmd.Parameters.Add(new SqlParameter {
                        ParameterName = "@HoadonId",
                        Value = this.HoadonId, 
                        SqlDbType = System.Data.SqlDbType.NVarChar 
                    });

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
