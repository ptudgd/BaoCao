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
    public class HanghoaSaveBusiness : RepositoryBase
    {
        public Hanghoa item {get;set;}

        public void Execute()
        {
            Hanghoa check = null;
            using (var repo = new HanghoaViewRepository())
            {
                repo.HanghoaId = this.item.HanghoaId;
                check = repo.Execute();
            }
            if (check != null) //đã tồn tại
            {
                using (var repo = new HanghoaUpdateRepository())
                {
                    repo.item = this.item;
                    repo.Execute();
                }
            }
            else
            {
                using (var repo = new HanghoaInsertRepository())
                {
                    repo.item = this.item;
                    repo.Execute();
                }
            }
        }
    }
}
