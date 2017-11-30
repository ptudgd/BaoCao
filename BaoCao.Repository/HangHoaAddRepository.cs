using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace BaoCao.Repository
{
    public class HangHoaAddRepository : ConnectDatabase
    {
        
        public string HanghoaId { get; set; }

        
        public string TenHanghoa { get; set; }

        
        public int GiaBan { get; set; }

        
        public string Mota { get; set; }

        
        public int SoLuongTonKho { get; set; }

        
        public string NhomHanghoaId { get; set; }

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
        public void Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();                    
                    if (check(HanghoaId))
                    {
                        cmd.CommandText = "INSERT INTO HangHoa VALUES('" + HanghoaId + "',N'" + TenHanghoa + "','" + GiaBan + "',N'" + Mota + "','" + SoLuongTonKho + "','" + NhomHanghoaId + "')";
                        cmd.ExecuteNonQuery();
                        
                    }
                }
                conn.Close();
            }
        }
    }
}
