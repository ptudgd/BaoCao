using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

namespace NhomHangHoaBusiness
{
    public class NhomHangHoaAddBusiness : ConnectDatabase
    {
        public NhomHangHoa.Domain.NhomHangHoa item { get; set; }
        public void Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "INSERT INTO NhomHangHoa VALUES('" + item.NhomHanghoaId + "',N'" + item.TenNhomHanghoa + "',N'" + item.GhiChu + "')";

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
