using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Banhang.Library;
using Banhang.Repository;
using Banhang.Domain;
using Banhang.Domain.HanghoaHandler;
using Banhang.Repository.HanghoaHandler;

namespace Banhang.Business
{
    public class HoadonSaveBusiness : RepositoryBase
    {
        public Hoadon item {get;set;}

        public void Execute()
        {
            Hoadon check = null;
            using (var repo = new HoadonViewRepository())
            {
                repo.HoadonId = this.item.HoadonId;
                check = repo.Execute();
            }
            if (check != null) //đã tồn tại
            {
                using (var repo = new HoadonUpdateRepository())
                {
                    repo.item = this.item;
                    repo.Execute();
                }
            }
            else
            {
                using (var repo = new HoadonInsertRepository())
                {
                    repo.item = this.item;
                    repo.Execute();
                }
            }
        }
    }
}
