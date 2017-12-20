using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace BanHangBusiness
{
    public class BanHangSoLuongBusiness : ConnectDatabase
    {
        public string HanghoaId { get; set; }
        
        public int Execute()
        {
            int data = 0;
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT SoLuongTonKho FROM HangHoa WHERE HanghoaId=@HanghoaId";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@HanghoaId",
                        Value = HanghoaId,
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    using(var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data = Convert.ToInt32(reader["SoLuongTonKho"]);
                        }
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
