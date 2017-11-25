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
            ConnectionString = @"Data Source=.;Initial Catalog=QuanlySinhvien;Integrated Security=True";
        }

        public void Dispose()
        {
            
        }
    }
}
