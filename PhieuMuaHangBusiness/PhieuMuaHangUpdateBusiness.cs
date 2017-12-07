using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;


namespace PhieuMuaHang.Business
{
    public class PhieuMuaHangUpdateBusiness : ConnectDatabase
    {
        public PhieuMuaHang.Domain.PhieuMuaHang item { get; set; }
        public void Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE PhieuMuaHang SET Khachhang=N'" + item.Khachhang + "',Ngaytao=N'" + item.Ngaytao + "',Tongtien=N'" + item.Tongtien + "',Ghichu='" + item.Ghichu + "',SoLuongMua1N=N'" + item.SoLuongMua1N + "' WHERE MaHD='"+item.MaHD+"'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
