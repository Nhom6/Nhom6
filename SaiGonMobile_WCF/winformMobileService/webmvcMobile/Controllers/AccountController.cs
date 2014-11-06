using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webmvcMobile.MobileServiceReference;

namespace webmvcMobile.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        MobileServiceClient ms = new MobileServiceClient();
        public ActionResult Login(string account, string password)
        {
            var acc = ms.LogIn(account,password);
            if(acc !=null)
            {
                Session["User"] = acc.ID;
                ViewBag.IsLogin = "True";
            }
            else
            {
                ViewBag.IsLogin = "False";
            }
            return Redirect("/Home/Index");
        }
        public ActionResult Logout()
        {
            Session["User"] = null;
            return Redirect("~/Home/Index");
        }
        public ActionResult Register(string UserName, string Password, string Phone, string Address, string Name)
        {
            Account acc = ms.Register( UserName,  Password, Phone, Address, Name);
            return View(acc);
        }
    }
}
