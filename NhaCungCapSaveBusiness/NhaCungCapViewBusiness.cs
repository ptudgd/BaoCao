using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

namespace NhaCungCap.Business
{
    public class NhaCungCapViewBusiness:ConnectDatabase
    {
        public NhaCungCap.Domain.NhaCungCap item { get; set; }
        public NhaCungCap.Domain.NhaCungCap Execute()
        {
            NhaCungCap.Domain.NhaCungCap data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM NhaCungCap WHERE NhacungcapId='" + item.NhacungcapId + "'";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data = new NhaCungCap.Domain.NhaCungCap
                            {
                                NhacungcapId = Convert.ToString(reader["NhacungcapId"]),
                                Ten = Convert.ToString(reader["Ten"]),
                                HangHoaCungCap = Convert.ToString(reader["HangHoaCungCap"]),
                                NhomhanghoaId = Convert.ToString(reader["NhomhanghoaId"]),
                                SDT = Convert.ToString(reader["SDT"]),
                                Diachi = Convert.ToString(reader["Diachi"])
                                
                            };
                        }
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
