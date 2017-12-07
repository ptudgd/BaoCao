using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;


namespace HangHoa.Business
{
    public class HangHoaUpdateBusiness : ConnectDatabase
    {
        public HangHoa.Domain.HangHoa item { get; set; }
        public void Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE HangHoa SET TenHanghoa=N'" + item.TenHanghoa + "',GiaBan='" + item.GiaBan + "',Mota=N'" + item.Mota + "',SoLuongTonKho='" + item.SoLuongTonKho + "',NhomHanghoaId='" + item.NhomHanghoaId + "' WHERE HanghoaId='"+item.HanghoaId+"'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
