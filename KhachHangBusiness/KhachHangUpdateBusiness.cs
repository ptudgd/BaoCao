using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;


namespace KhachHang.Business
{
    public class KhachHangUpdateBusiness : ConnectDatabase
    {
        public KhachHang.Domain.KhachHang item { get; set; }
        public void Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE KhachHang SET Ho=N'" + item.Ho + "',Tenlot=N'" + item.Tenlot + "',Ten=N'" + item.Ten + "',Gioitinh='" + item.Gioitinh + "',Email=N'" + item.Email + "' WHERE KhachhangId='"+item.KhachhangId+"'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
