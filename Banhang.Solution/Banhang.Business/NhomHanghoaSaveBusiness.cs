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
    public class NhomHanghoaSaveBusiness : RepositoryBase
    {
        public NhomHanghoa item {get;set;}

        public void Execute()
        {
            NhomHanghoa check = null;
            using (var repo = new NhomHanghoaViewRepository())
            {
                repo.NhomHanghoaId = this.item.NhomHanghoaId;
                check = repo.Execute();
            }
            if (check != null) //đã tồn tại
            {
                using (var repo = new NhomHanghoaUpdateRepository())
                {
                    repo.item = this.item;
                    repo.Execute();
                }
            }
            else
            {
                using (var repo = new NhomHanghoaInsertRepository())
                {
                    repo.item = this.item;
                    repo.Execute();
                }
            }
        }
    }
}
