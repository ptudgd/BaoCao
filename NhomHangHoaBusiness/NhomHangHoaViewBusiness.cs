using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace NhomHangHoaBusiness
{
    public class NhomHangHoaViewBusiness : ConnectDatabase
    {
        public string NhomHanghoaId { get; set; }
        public NhomHangHoa.Domain.NhomHangHoa Execute()
        {
            NhomHangHoa.Domain.NhomHangHoa data = null;
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM NhomHangHoa WHERE NhomHanghoaId='" + NhomHanghoaId + "'";
                    using (var reader = cmd.ExecuteReader())
                    {
                       
                        if (reader.Read())
                        {
                            data = new NhomHangHoa.Domain.NhomHangHoa();
                            data.NhomHanghoaId = Convert.ToString(reader["NhomHanghoaId"]);
                            data.TenNhomHanghoa = Convert.ToString(reader["TenNhomHanghoa"]);
                            data.GhiChu = Convert.ToString(reader["GhiChu"]);
                        }
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
