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
    public class NhomHanghoaListRepository : RepositoryBase
    {
        public List<NhomHanghoa> Execute()
        {
            var data = new List<NhomHanghoa>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM NhomHanghoa";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new NhomHanghoa
                            {
                                NhomHanghoaId = Convert.ToString(reader["NhomHanghoaId"].vSafe()),
                                TenNhomHanghoa = Convert.ToString(reader["TenNhomHanghoa"].vSafe()),
                                Ghichu = Convert.ToString(reader["Ghichu"].vSafe()),
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
