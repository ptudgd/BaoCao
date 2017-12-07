using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Windows.Forms;

namespace PhieuMuaHang.Repository
{
    public class PhieuMuaHangAddRepository : ConnectDatabase
    {
        public PhieuMuaHang.Domain.PhieuMuaHang item { get; set; }
        private bool check(string a)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT MaHD FROM PhieuMuaHang WHERE MaHD='" + a + "'";
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
                    if (check(item.MaHD))
                    {
                        cmd.CommandText = "INSERT INTO PhieuMuaHang VALUES(N'" + item.MaHD + "',N'" + item.Khachhang + "',N'" + item.Ngaytao + "',N'" + item.Tongtien + "','" + item.Ghichu + "',N'" + item.SoLuongMua1N +  "')";
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
