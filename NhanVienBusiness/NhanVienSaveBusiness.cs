using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
using NhanVien.Repository;

using NhanVien.Business;

namespace HangHoa.Business
{
    public class NhanVienSaveBusiness : ConnectDatabase
    {
        public NhanVien.Domain.NhanVien item { get; set; }
        public void Execute()
        {
            NhanVien.Domain.NhanVien check = null;
            using(var cmd = new NhanVienViewBusiness())
            {
                cmd.item = item;
                check = cmd.Execute();
            }
            if (check != null) // da co du lieu
            {
                using(var cmd = new NhanVienUpdateBusiness())
                {
                    cmd.item = item;
                    cmd.Execute();
                }
            }
            else
            {
                using(var cmd = new NhanVienAddRepository())
                {
                    cmd.item = item;
                    cmd.Execute();
                }
            }
            
            
            
        }
    }
}
