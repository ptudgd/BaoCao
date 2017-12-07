using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Windows.Forms;

namespace KhachHang.Repository
{
    public class KhachHangAddRepository : ConnectDatabase
    {
        public KhachHang.Domain.KhachHang item { get; set; }
        private bool check(string a)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT KhachhangId FROM KhachHang WHERE KhachhangId='" + a + "'";
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
                    if (check(item.KhachhangId))
                    {
                        cmd.CommandText = "INSERT INTO KhachHang VALUES(N'" + item.KhachhangId + "',N'" + item.Ho + "',N'" + item.Tenlot + "',N'" + item.Ten + "','" + item.Gioitinh + "',N'" + item.Email + "',N'" + item.SDT + "',N'" + item.Diachi + "')";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }
                    MessageBox.Show("Mã khách hàng đã bị trùng!","THÔNG BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    conn.Close();
                    return false;
                    
                }
            }
        }
    }
}
