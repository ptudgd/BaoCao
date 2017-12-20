using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao.Library
{
    public abstract class ConnectDatabase: IDisposable
    {
        public string ConnectionString;
        public ConnectDatabase()
        {
            ConnectionString = "Data Source=.;";
            ConnectionString += "Initial Catalog=QuanLySinhVien;";
            ConnectionString += "Integrated Security=True;";
            //ConnectionString = @"workstation id=QuanLyBanHang.mssql.somee.com;packet size=4096;user id=hoangduy;pwd=thelove123;data source=QuanLyBanHang.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang";
        }

        public void Dispose()
        {
            
        }
    }
}
