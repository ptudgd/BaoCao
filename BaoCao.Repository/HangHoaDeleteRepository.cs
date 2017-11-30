﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace BaoCao.Repository
{
    public class HangHoaDeleteRepository : ConnectDatabase
    {
        public string hangHoaId { get; set; }

        public void Execute()
        {
            using(var conn = new SqlConnection(this.ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM HangHoa WHERE HanghoaId ='"+hangHoaId+"'";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
