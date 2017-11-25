using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Banhang.Domain;
using Banhang.Library;

namespace Banhang.Repository.HanghoaHandler
{
    public class NhomHanghoaDeleteRepository : RepositoryBase
    {
        public string NhomHanghoaId { get; set; }

        public void Execute()
        {
            using (var conn = new SqlConnection(this.ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM NhomHanghoa WHERE NhomHanghoaId = @NhomHanghoaId";
                    cmd.Parameters.Add(new SqlParameter {
                        ParameterName = "@NhomHanghoaId",
                        Value = this.NhomHanghoaId.vToSqlValue(), 
                        SqlDbType = System.Data.SqlDbType.NVarChar 
                    });

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
