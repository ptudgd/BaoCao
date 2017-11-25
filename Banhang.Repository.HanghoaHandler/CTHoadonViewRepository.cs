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
    public class CTHoadonViewRepository : RepositoryBase
    {
        public string CTHoadonId { get; set; }

        public CTHoadon Execute()
        {
            CTHoadon data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM CTHoadon WHERE CTHoadonId = @CTHoadonId";
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@CTHoadonId", Value = this.CTHoadonId, SqlDbType = System.Data.SqlDbType.NVarChar });
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data = new CTHoadon
                            {
                                CTHoadonId = Convert.ToString(reader["CTHoadonId"].vSafe()),
                                HoadonId = Convert.ToString(reader["HoadonId"].vSafe()),
                                HanghoaId = Convert.ToString(reader["HanghoaId"].vSafe()),
                                TenHanghoa = Convert.ToString(reader["TenHanghoa"].vSafe()),
                                Soluong = Convert.ToInt64(reader["Soluong"].vSafe()),
                                Dongia = Convert.ToInt64(reader["Dongia"].vSafe()),
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
