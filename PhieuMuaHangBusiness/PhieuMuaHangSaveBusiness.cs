using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;

using PhieuMuaHang.Repository;

namespace PhieuMuaHang.Business
{
    public class PhieuMuaHangSaveBusiness : ConnectDatabase
    {
        public PhieuMuaHang.Domain.PhieuMuaHang item { get; set; }
        public void Execute()
        {
            PhieuMuaHang.Domain.PhieuMuaHang check = null;
            using(var cmd = new PhieuMuaHangViewBusiness())
            {
                cmd.item = item;
                check = cmd.Execute();
            }
            if (check != null) // da co du lieu
            {
                using(var cmd = new PhieuMuaHangUpdateBusiness())
                {
                    cmd.item = item;
                    cmd.Execute();
                }
            }
            else
            {
                using(var cmd = new PhieuMuaHangAddRepository())
                {
                    cmd.item = item;
                    cmd.Execute();
                }
            }
        }
    }
}
