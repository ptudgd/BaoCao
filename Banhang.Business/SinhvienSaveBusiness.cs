using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Banhang.Library;
using Banhang.Repository;
using Banhang.Domain;

namespace Banhang.Business
{
    public class SinhvienSaveBusiness : RepositoryBase
    {
        public Sinhvien item {get;set;}

        public void Execute()
        {
            Sinhvien check = null;
            using (var repo = new SinhvienViewRepository())
            {
                repo.Maso = this.item.Maso;
                check = repo.Execute();
            }
            if (check != null) //đã tồn tại
            {
                using (var repo = new SinhvienUpdateRepository())
                {
                    repo.item = this.item;
                    repo.Execute();
                }
            }
            else
            {
                using (var repo = new SinhvienInsertRepository())
                {
                    repo.item = this.item;
                    repo.Execute();
                }
            }
        }
    }
}
