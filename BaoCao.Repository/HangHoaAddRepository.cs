using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaoCao.Repository
{
    public class HangHoaAddRepository : ConnectDatabase
    {
        
        public HangHoa.Domain.HangHoa item { get; set; }

        private bool check(string a)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT HanghoaId FROM Hanghoa WHERE HanghoaId='"+a+"'";
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
                    if (check(item.HanghoaId))
                    {
                        cmd.CommandText = "INSERT INTO HangHoa VALUES('" + item.HanghoaId + "',N'" + item.TenHanghoa + "','" + item.GiaBan + "',N'" + item.Mota + "','" + item.SoLuongTonKho + "','" + item.NhomHanghoaId + "')";
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
