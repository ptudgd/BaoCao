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
    public class CTHoadonSaveBusiness : RepositoryBase
    {
        public CTHoadon item {get;set;}

        public void Execute()
        {
            CTHoadon check = null;
            using (var repo = new CTHoadonViewRepository())
            {
                repo.CTHoadonId = this.item.CTHoadonId;
                check = repo.Execute();
            }
            if (check != null) //đã tồn tại
            {
                using (var repo = new CTHoadonUpdateRepository())
                {
                    repo.item = this.item;
                    repo.Execute();
                }
            }
            else
            {
                using (var repo = new CTHoadonInsertRepository())
                {
                    repo.item = this.item;
                    repo.Execute();
                }
            }
        }
    }
}
