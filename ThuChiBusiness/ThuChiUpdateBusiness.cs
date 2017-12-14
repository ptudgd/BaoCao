using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;


namespace ThuChi.Business
{
    public class ThuChiUpdateBusiness : ConnectDatabase
    {
        public ThuChi.Domain.ThuChi item { get; set; }
        public void Execute()
        {
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE ThuChi SET Thu='" + item.Thu + "',Chi='" + item.Chi + "' WHERE Ngay='"+item.Ngay+"'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
