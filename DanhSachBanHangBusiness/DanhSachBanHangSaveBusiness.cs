using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
using PhieuBanHangSaveBusiness;

namespace DanhSachBanHangBusiness
{
    public class DanhSachBanHangSaveBusiness:ConnectDatabase
    {
        public BanHang.Domain.BanHang item { get; set; }    
        public void Execute()
        {
            using(var cmd = new BanHangViewBusiness())
            {
                cmd.ID = item.ID;
                cmd.HanghoaId = item.HanghoaId;
            }
        }
    }
}
