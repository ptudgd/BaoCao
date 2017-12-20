using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
namespace BanHangBusiness
{
    public class BanHangSubBusiness:ConnectDatabase
    {
        public string HanghoaId { get; set; }
        public int SoLuong { get; set; }
        public void Execute()
        {
            int data = 0;
            using(var cmd= new BanHangSoLuongBusiness())
            {
                cmd.HanghoaId = HanghoaId;
                data = cmd.Execute();
            }
            using(var cmd = new BanHangSubSoLuongBusiness())
            {
                cmd.HanghoaId = HanghoaId;
                cmd.SoLuong = data - SoLuong;
                cmd.Execute();
            }
        }
    }
}
