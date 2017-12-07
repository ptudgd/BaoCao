using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;


namespace NhaCungCap.Business
{
    public class NhaCungCapUpdateBusiness : ConnectDatabase
    {
        public NhaCungCap.Domain.NhaCungCap item { get; set; }
        public void Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE NhaCungCap SET Ten=N'" + item.Ten + "',HangHoaCungCap=N'" + item.HangHoaCungCap + "',NhomHanghoaId=N'" + item.NhomhanghoaId + "',SDT='" + item.SDT + "',Diachi=N'" + item.Diachi + "' WHERE NhacungcapId='"+item.NhacungcapId+"'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
