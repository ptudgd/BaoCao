using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

using PhieuBanHang.Repository;

namespace PhieuBanHangSaveBusiness
{
    public class PhieuBanHangSaveBusiness:ConnectDatabase
    {
        
        public BanHang.Domain.BanHang item { get; set; }
        public void Execute()
        {
            List< BanHang.Domain.BanHang> check = null;
            using(var cmd = new BanHangViewBusiness())
            {
                cmd.ID = item.ID;
                check = cmd.Execute();
            }
            if(check == null)
            {
                using(var cmd = new BanHangAddRepository())
                {                    
                    cmd.item = item;
                    cmd.Execute();
                }
                
            }
        }
    }
}
