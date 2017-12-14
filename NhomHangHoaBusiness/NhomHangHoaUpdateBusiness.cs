using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BaoCao.Library;
namespace NhomHangHoaBusiness
{
    public class NhomHangHoaUpdateBusiness : ConnectDatabase
    {
        public NhomHangHoa.Domain.NhomHangHoa item { get; set; }
        public void Execute()
        {
            
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE NhomHangHoa SET TenNhomHanghoa=N'" + item.TenNhomHanghoa + "',GhiChu=N'" + item.TenNhomHanghoa + "' WHERE NhomHanghoaId='" + item.NhomHanghoaId + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
