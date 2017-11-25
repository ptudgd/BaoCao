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
    public class NhomHanghoaViewRepository : RepositoryBase
    {
        public string NhomHanghoaId { get; set; }

        public NhomHanghoa Execute()
        {
            NhomHanghoa data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM NhomHanghoa WHERE NhomHanghoaId = @NhomHanghoaId";
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@NhomHanghoaId", Value = this.NhomHanghoaId, SqlDbType = System.Data.SqlDbType.NVarChar });
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data = new NhomHanghoa();
                            data.NhomHanghoaId = Convert.ToString(reader["NhomHanghoaId"].vSafe());
                            data.TenNhomHanghoa = Convert.ToString(reader["TenNhomHanghoa"].vSafe());
                            data.Ghichu = Convert.ToString(reader["Ghichu"].vSafe());
                        }
                    }
                }
                conn.Close();
            }
            return data;
        }
    }
}
