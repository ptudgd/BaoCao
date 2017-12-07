using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;


namespace NhanVien.Business
{
    public class NhanVienUpdateBusiness : ConnectDatabase
    {
        public NhanVien.Domain.NhanVien item { get; set; }
        public void Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE NhanVien SET Holot=N'" + item.Holot + "',Ten=N'" + item.Ten + "',Ngaysinh='" + item.Ngaysinh + "',NgayVaolam='" + item.NgayVaolam + "',GioiTinh='" + item.Gioitinh + "' WHERE NhanvienId='"+item.NhanvienId+"'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
