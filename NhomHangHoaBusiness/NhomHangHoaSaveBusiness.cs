using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BaoCao.Library;
namespace NhomHangHoaBusiness
{
    
    public class NhomHangHoaSaveBusiness: ConnectDatabase
    {
        public NhomHangHoa.Domain.NhomHangHoa item { get; set; }
        public void Execute()
        {
            NhomHangHoa.Domain.NhomHangHoa check = null;
            using(var cmd = new NhomHangHoaViewBusiness())
            {
                cmd.NhomHanghoaId = item.NhomHanghoaId;
                check = cmd.Execute();
            }
            if(check != null)
            {
                using(var cmd = new NhomHangHoaUpdateBusiness())
                {
                    cmd.item = item;
                    cmd.Execute();
                }
            }
            else
            {
                using(var cmd = new NhomHangHoaAddBusiness())
                {
                    cmd.item = item;
                    cmd.Execute();
                }
            }
        }
    }
}
