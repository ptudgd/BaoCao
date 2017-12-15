using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;


namespace ThuChiBusiness
{
    public class ThuChiUpdateBusiness : ConnectDatabase
    {
        public string Ngay { get; set; }
        public int Thu { get; set; }
        public int Chi { get; set; }
        public void Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE ThuChi SET Thu='" + Thu + "',Chi='" + Chi + "' WHERE Ngay='"+Ngay+"'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
