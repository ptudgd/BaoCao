using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BaoCao.Library;
namespace HangHoa.Business
{
    public class HangHoaViewBusiness : ConnectDatabase
    {
        public HangHoa.Domain.HangHoa item { get; set; }
        public HangHoa.Domain.HangHoa Execute()
        {
            HangHoa.Domain.HangHoa data = null;
            using(var conn = new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM HangHoa WHERE HanghoaId='" + item.HanghoaId + "'";
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data = new HangHoa.Domain.HangHoa
                            {
                                HanghoaId = Convert.ToString(reader["HanghoaId"]),
                                TenHanghoa = Convert.ToString(reader["TenHanghoa"]),
                                GiaBan = Convert.ToInt32(reader["GiaBan"]),
                                Mota = Convert.ToString(reader["Mota"]),
                                SoLuongTonKho = Convert.ToInt32(reader["SoLuongTonKho"]),
                                NhomHanghoaId = Convert.ToString(reader["NhomHanghoaId"])
                            };
                        }
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
