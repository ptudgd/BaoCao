using Banhang.Domain;
using Banhang.Domain.HanghoaHandler;
using Banhang.Repository.HanghoaHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banhang.Web.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public ActionResult ListProduct()
        {
            return View();
        }
        public ActionResult GetListProduct()
        {
            var listData = new List<Product>();
            listData.Add(new Product { Maso = "sp01", Ten = "Nước pepsi", Giaban = 10000 });
            listData.Add(new Product { Maso = "sp02", Ten = "Nước Coca", Giaban = 15000 });
            listData.Add(new Product { Maso = "sp03", Ten = "7 Up", Giaban = 15000 });
            return Json(listData, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ListProductW2UI()
        {
            return View();
        }

        public ActionResult GetListProductDb()
        {
            var listData = new List<Hanghoa>();
            using (var cmd = new HanghoaListRepository())
            {
                listData = cmd.Execute(); 
            }
            return Json(listData, JsonRequestBehavior.AllowGet);
        }
	}
}