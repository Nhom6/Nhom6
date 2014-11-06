using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webmvcMobile.MobileServiceReference;

namespace webmvcMobile.Models
{
    public class Cart
    {
        MobileServiceClient ms = new MobileServiceClient();
        
        public class Item
        {
            public string ProductID { get; set; }
            public string ProductName { get; set; }
            public double UnitPrice { get; set; }
            public int Quantity { get; set; }
            public string ImageUrl { get; set; }
        }
        public List<Item> ListItem = new List<Item>();
        public IEnumerable<Item> ListItems
        {
            get { return ListItem; }
        }

        public void AddItem(string productID, string productName, double unitPrice, int quantity, string imageUrl)
        {
            Item item = ListItem.Where(p => p.ProductID == productID).FirstOrDefault();
            if (item == null)
            {
                ListItem.Add(new Item { ProductID = productID, ProductName = productName, UnitPrice = unitPrice, Quantity = quantity, ImageUrl = imageUrl });
            }
            else
            {
                item.Quantity += quantity;
            }
        }
        public void UpdateItem(string productID, int quantity)
        {
            Item item = ListItem.Where(i => i.ProductID == productID).FirstOrDefault();
            item.Quantity = quantity;
        }
        public void RemoveItem(string productID)
        {
            ListItem.RemoveAll(i => i.ProductID == productID);
        }
        public double TotalPrice()
        {
            return ListItem.Sum(i => i.Quantity * i.UnitPrice);
        }
        public void AddOrderDetail(Order ord)
        {
            var listitem = ListItems.ToList();
            foreach (var item in listitem)
            {
                var detail = new OrderDetail
                {
                    OrderID = ord.ID,
                    ProductID = item.ProductID,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice
                };
                ms.AddOrderDetail(detail);
            }
          
        }
    }
}