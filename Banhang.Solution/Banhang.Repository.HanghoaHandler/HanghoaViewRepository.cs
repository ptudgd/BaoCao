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
    public class HanghoaViewRepository : RepositoryBase
    {
        public string HanghoaId { get; set; }

        public Hanghoa Execute()
        {
            Hanghoa data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM Hanghoa WHERE HanghoaId = @HanghoaId";
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@HanghoaId", Value = this.HanghoaId, SqlDbType = System.Data.SqlDbType.NVarChar });
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data = new Hanghoa
                            {
                                HanghoaId = Convert.ToString(reader["HanghoaId"].vSafe()),
                                TenHanghoa = Convert.ToString(reader["TenHanghoa"].vSafe()),
                                GiaBan = Convert.ToDouble(reader["GiaBan"].vSafe()),
                                Mota = Convert.ToString(reader["Mota"].vSafe()),
                                SoLuongTonKho = Convert.ToInt32(reader["SoLuongTonKho"].vSafe()),
                                NhomHanghoaId = Convert.ToString(reader["NhomHanghoaId"].vSafe())
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
