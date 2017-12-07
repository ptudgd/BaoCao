using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NhanVien.Repository
{
    public class NhanVienAddRepository : ConnectDatabase
    {
        
        public NhanVien.Domain.NhanVien item { get; set; }

        private bool check(string a)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT NhanvienId FROM NhanVien WHERE NhanvienId='"+a+"'";
                    using(var reader = cmd.ExecuteReader())
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
        public bool Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();                    
                    if (check(item.NhanvienId))
                    {
                        cmd.CommandText = "INSERT INTO NhanVien VALUES('" + item.NhanvienId + "',N'" + item.Holot + "','" + item.Ten + "',N'" + item.Ngaysinh + "','" + item.NgayVaolam + "','" + item.Gioitinh + "')";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }
                    MessageBox.Show("Mã hàng hóa bị trùng!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return false;
                }
                
            }
        }
    }
}
