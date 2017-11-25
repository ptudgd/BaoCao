using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using NhaCungCap.Repository;
using System.Data.SqlClient;

namespace NhaCungCap.Repository
{
    public class NhaCungCapListRepository : ConnectDatabase
    {
        public List<NhaCungCap.Domain.NhaCungCap> Execute()
        {
            var data = new List<NhaCungCap.Domain.NhaCungCap>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM NhaCungCap";
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new NhaCungCap.Domain.NhaCungCap
                            {
                                NhacungcapId = Convert.ToString(reader["NhacungcapId"]),
                                Ten = Convert.ToString(reader["Ten"]),
                                HangHoaCungCap = Convert.ToString(reader["HangHoaCungCap"]),
                                SDT = Convert.ToString(reader["SDT"]),
                                Diachi = Convert.ToString(reader["Diachi"]),
                                NhomhanghoaId = Convert.ToString(reader["NhomhanghoaId"])
                            });
                        }
                        
                    }
                }
            }
            return data;
        }
    }
}
