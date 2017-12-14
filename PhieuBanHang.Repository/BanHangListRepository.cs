using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace PhieuBanHang.Repository
{
    class BanHangListRepository:ConnectDatabase
    {
        public BanHang.Domain.BanHang item { get; set; }
        public List<BanHang.Domain.BanHang> Execute()
        {
            var data = new List<BanHang.Domain.BanHang>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM BanHang WHERE ID='" + item.ID + "'";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new BanHang.Domain.BanHang
                            {
                                
                            });
                        }
                    }
                }
            }
            return data;
        }
    }
}
