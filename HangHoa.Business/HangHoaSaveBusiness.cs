using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
using BaoCao.Repository;
using System.Windows.Forms;

namespace HangHoa.Business
{
    public class HangHoaSaveBusiness : ConnectDatabase
    {
        public HangHoa.Domain.HangHoa item { get; set; }
        public void Execute()
        {
            HangHoa.Domain.HangHoa check = null;
            using(var cmd = new HangHoaViewBusiness())
            {
                cmd.item = item;
                check = cmd.Execute();
            }
            if (check != null) // da co du lieu
            {
                using(var cmd = new HangHoaUpdateBusiness())
                {
                    cmd.item = item;
                    cmd.Execute();
                }
            }
            else
            {
                using(var cmd = new HangHoaAddRepository())
                {
                    cmd.item = item;
                    cmd.Execute();
                }
            }       
        }
    }
}
