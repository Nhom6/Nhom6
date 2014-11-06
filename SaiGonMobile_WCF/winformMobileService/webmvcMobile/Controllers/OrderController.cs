using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webmvcMobile.MobileServiceReference;
using webmvcMobile.Models;

namespace webmvcMobile.Controllers
{
    public class OrderController : Controller
    {
        MobileServiceClient ms = new MobileServiceClient();
        
        public ActionResult CheckOut(double TotalPrice)
        {
            Session["User"] = "anhkha";
            if (Session["User"] != null && Session["Cart"] != null)
            {
                Cart cart = (Cart)Session["Cart"];
                string customer = Session["User"].ToString();
                var customerInfo = ms.GetAccountByID("anhkha");
                ViewBag.TotalPrice = TotalPrice;
                if (TotalPrice > 0)
                {
                    Order ord = new Order();
                    ord.ID = Guid.NewGuid();
                    ord.UserID = customerInfo.ID;
                    ord.Name = customerInfo.Name;
                    ord.Phone = customerInfo.Phone;
                    ord.RecipientAddress = customerInfo.Address;
                    ord.TotalPrice = TotalPrice;
                    ord.Status = "DangCho";
                    ord.DateCreate = DateTime.UtcNow;
                   
                    ms.AddOrder(ord);
                    //ms.SaveChanges();
                    
                    cart.AddOrderDetail(ord);
                  
                    foreach (var product in cart.ListItems)
                    {
                        ms.UpdateStorage(product.ProductID, product.Quantity);
                    }

                    Session["Cart"] = null;
                    return View(customerInfo);
                }
                else
                {
                    return Redirect("/Order/Fail");
                }
            }
            return Redirect("/Order/Fail");
        }
        public ActionResult Fail()
        {
            return View();
        }
    }
}
