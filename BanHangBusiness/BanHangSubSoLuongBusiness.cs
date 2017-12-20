using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace BanHangBusiness
{
    public class BanHangSubSoLuongBusiness:ConnectDatabase
    {
        public string HanghoaId { get; set; }
        public int SoLuong { get; set; }
        public void Execute()
        {            
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE HangHoa SET SoLuongTonKho=@SoLuong WHERE HanghoaId=@HanghoaId";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@HanghoaId",
                        Value = HanghoaId,
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@SoLuong",
                        Value = SoLuong,
                        SqlDbType = System.Data.SqlDbType.Int
                    });
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            
        }
    }
}
