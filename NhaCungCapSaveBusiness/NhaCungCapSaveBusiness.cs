using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.Library;
using System.Data.SqlClient;
using NhaCungCap.Business;
using NhaCungCap.Repository;

namespace NhaCungCap.Business
{
    public class NhaCungCapSaveBusiness : ConnectDatabase
    {
        public NhaCungCap.Domain.NhaCungCap item { get; set; }
        public void Execute()
        {
            NhaCungCap.Domain.NhaCungCap check = null;
            using (var cmd = new NhaCungCapViewBusiness())
            {
                cmd.item = item;
                check = cmd.Execute();
            }
            if (check != null) // da co du lieu
            {
                using (var cmd = new NhaCungCapUpdateBusiness())
                {
                    cmd.item = item;
                    cmd.Execute();
                }
            }
            else
            {
                using (var cmd = new NhaCungCapAddRepository())
                {
                    cmd.item = item;
                    cmd.Execute();
                }
            }
        }
    }
}
