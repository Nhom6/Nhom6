using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using webmvcMobile.MobileServiceReference;

namespace webmvcMobile.Controllers
{
    public class HomeController : Controller
    {
        
        MobileServiceClient ms = new MobileServiceClient();
        public ActionResult Index(int ? page)
        {
            int pageSize = 9;
            int pageNum = 1;
            var listpro = ms.GetAll();
            return View(listpro.ToPagedList(pageNum,pageSize));
        }
        public ActionResult Category()
        {
            var listcategory = ms.GetAllCategory();
            return View(listcategory);
        }
        public ActionResult Category1()
        {
            var listcategory = ms.GetAllCategory();
            return View(listcategory);
        }
        public ActionResult Product_Category(int ?page,int cat)
        {
            int pageSize = 6;
            int pageNum = 1;
            var listproductbycategory = ms.GetProductByCategory(cat);
            return View(listproductbycategory.ToPagedList(pageNum,pageSize));
        }
        public ActionResult Product_Detail(string id)
        {
            var detailinproduct = ms.GetDetailById(id);
            return View(detailinproduct);
        }
        public ActionResult SearchBasic(int? page, string txtSearch)
        {
            if (ViewBag.KeyWord == null)
            {
                if (txtSearch != null)
                {
                    ViewBag.KeyWord = txtSearch;
                }
                else
                    ViewBag.KeyWord = "";
            }
            string searchName = ViewBag.KeyWord;
            int pageSize = 1;
            int pageNum = (page ?? 1);
            return View(ms.SearchBasic(pageSize, searchName).ToPagedList(pageNum, pageSize));
        }


    }
}
