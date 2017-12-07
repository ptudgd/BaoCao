using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Windows.Forms;

namespace NhaCungCap.Repository
{
    public class NhaCungCapAddRepository : ConnectDatabase
    {
        
        public NhaCungCap.Domain.NhaCungCap item { get; set; }
        private bool check(string a)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT NhacungcapId FROM NhaCungCap WHERE NhacungcapId='" + a + "'";
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return false;
                        }
                    }
                }
                conn.Close();
            }
            return true;
        }
        public bool  Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    if (check(item.NhacungcapId))
                    {
                        cmd.CommandText = "INSERT INTO NhaCungCap VALUES(N'" + item.NhacungcapId + "',N'" + item.Ten + "',N'" + item.HangHoaCungCap + "',N'" + item.NhomhanghoaId + "','" + item.SDT + "',N'" + item.Diachi +"')";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }
                    MessageBox.Show("Mã nhà cung đã bị trùng!","THÔNG BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    conn.Close();
                    return false;
                    
                }
            }
        }
    }
}
