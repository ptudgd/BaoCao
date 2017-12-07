using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
using KhachHang.Repository;


using KhachHangBusiness;

namespace KhachHang.Business
{
    public class KhachHangSaveBusiness : ConnectDatabase
    {
        public KhachHang.Domain.KhachHang item { get; set; }
        public void Execute()
        {
            KhachHang.Domain.KhachHang check = null;
            using(var cmd = new KhachHangViewBusiness())
            {
                cmd.item = item;
                check = cmd.Execute();
            }
            if (check != null) // da co du lieu
            {
                using(var cmd = new KhachHangUpdateBusiness())
                {
                    cmd.item = item;
                    cmd.Execute();
                }
            }
            else
            {
                using(var cmd = new KhachHangAddRepository())
                {
                    cmd.item = item;
                    cmd.Execute();
                }
            }
        }
    }
}
