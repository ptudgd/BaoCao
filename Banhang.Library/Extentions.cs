using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banhang.Library
{
    public static class Extentions
    {
        public static object vSafe(this object obj)
        {
            if (obj == DBNull.Value)
                return null;
            return obj;
        }
        public static object vToSqlValue(this object obj)
        {
            if (obj == null)
                return DBNull.Value;
            return obj;
        }
    }
}
