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
    public class HoadonViewRepository : RepositoryBase
    {
        public string HoadonId { get; set; }

        public Hoadon Execute()
        {
            Hoadon data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM Hoadon WHERE HoadonId = @HoadonId";
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@HoadonId", Value = this.HoadonId, SqlDbType = System.Data.SqlDbType.NVarChar });
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data = new Hoadon
                            {
                                HoadonId = Convert.ToString(reader["HoadonId"].vSafe()),
                                NhanvienId = Convert.ToString(reader["NhanvienId"].vSafe()),
                                NgayHoadon = Convert.ToDateTime(reader["NgayHoadon"].vSafe()),
                                Tongtien = Convert.ToInt64(reader["Tongtien"].vSafe()),
                                Ghichu = Convert.ToString(reader["Ghichu"].vSafe())
                            };
                        }
                    }
                }
                conn.Close();
            }
            return data;
        }
    }
}
