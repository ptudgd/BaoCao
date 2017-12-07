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
        
        public string KhachhangId { get; set; }

        
        public string Ho { get; set; }

        
        public string Tenlot { get; set; }

        
        public string Ten { get; set; }

        
        public bool Gioitinh { get; set; }

        
        public string Email { get; set; }

        
        public string SDT { get; set; }

        
        public string Diachi { get; set; }
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
                    if (check(KhachhangId))
                    {
                        cmd.CommandText = "INSERT INTO KhachHang VALUES(N'" + KhachhangId + "',N'" + Ho + "',N'" + Tenlot + "',N'" + Ten + "','" + Gioitinh + "',N'" + Email + "',N'" + SDT + "',N'" + Diachi + "')";
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
