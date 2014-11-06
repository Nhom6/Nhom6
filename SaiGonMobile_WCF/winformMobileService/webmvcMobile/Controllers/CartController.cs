using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webmvcMobile.MobileServiceReference;
using webmvcMobile.Models;

namespace webmvcMobile.Controllers
{
    public class CartController : Controller
    {
        MobileServiceClient ms = new MobileServiceClient();
        
        private Cart GetCartItem()
        {
            Cart scart = (Cart)Session["Cart"];
            if (scart == null)
            {
                scart = new Cart();
                Session["Cart"] = scart;
            }
            return scart;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddToCart(string productID)
        {
            //ms.AddItemToCart(productID);
            int quantity = 1;
            List<Product> pro = ms.GetAll().ToList(); 
            foreach (var pr in pro)
            {
                if (productID == pr.ID)
                {
                    GetCartItem().AddItem(pr.ID, pr.ProductName, pr.UnitPrice, quantity, pr.ImageUrl);
                }

            }
            return Redirect("~/Cart/MyCart");
        }
        //xoa san pham trong gio hang
        public ActionResult DeleteItemInCart(string productID)
        {
            GetCartItem().RemoveItem(productID);
            return Redirect("/Cart/MyCart");
        }
        public ActionResult UpdateQuantityForProduct(string productID, int quantity)
        {
            GetCartItem().UpdateItem(productID, quantity);
            return Redirect("MyCart");
        }
        public ActionResult MyCart()
        {
            Cart item = new Cart();
            item = GetCartItem();
            return View(item);
        }
    }
}
