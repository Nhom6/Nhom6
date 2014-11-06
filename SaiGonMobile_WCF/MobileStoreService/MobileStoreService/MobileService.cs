using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MobileStoreService;

namespace MobileStoreService
{
    public class MobileService : IMobileService 
    {
        MobileDBEntities db = new MobileDBEntities();
        //SERVICE FOR WINFORM
        //PRODUCT
        public List<Product> GetAll() 
        {
            return db.Products.ToList();
        }
        public Product GetByID(string id)
        {
            Product product = db.Products.Find(id);
            return product;
        }
        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            db.Entry(product).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteProduct(string id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
        }
        public bool CheckIDProduct(string id)
        {
            foreach(var item in db.Products)
            {
                if (item.ID == id)
                    return true;
            }
            return true;
        }
        //ACCOUNT
        public List<Account> GetAllAccount()
        {
            return db.Accounts.ToList();
        }
        public Account GetAccountByID(string id)
        {
            Account account = db.Accounts.Find(id);
            return account;
        }
        public void EditAccount(Account account)
        {
            db.Entry(account).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteAccount(string id)
        {
            Account account = db.Accounts.Find(id);
            db.Accounts.Remove(account);
            db.SaveChanges();
        }
        //CATEGORY
        public List<Category> GetAllCategory()
        {
            return db.Categories.ToList();
        }
        public List<Category> GetAllCategory1()
        {
            return db.Categories.ToList();
        }
        public Category GetCategoryByID(int id)
        {
            Category category = db.Categories.Find(id);
            return category;
        }
        public void AddCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }
        public void UpdateCategory(Category category)
        {
            db.Entry(category).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteCategory(int id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
        }
        //ORDER
        public void AddOrder(Order order)
        {
           db.Orders.Add(order);
           db.SaveChanges();
             
        }
        public List<Order> GetAllOrder()
        {
            return db.Orders.ToList();
        }
        public Order GetOrderByID(Guid id)
        {
            Order order = db.Orders.Find(id);
            return order;
        }
        public void UpdateOrder(Order order)
        {
            db.Entry(order).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteOrder(Guid id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
        }

        public void UpdateStorage(string productID, int quantityOrder)
        {
                var pro = (from pr in db.StorageShops where pr.ProductID == productID select pr).SingleOrDefault();
                int q = pro.Quantity - quantityOrder;
                pro.Quantity = q;
                pro.ProductID = productID;
                pro.DateUpdate = DateTime.Now;
                db.SaveChanges();
        }
        public void UpdateStatus(Order order)
        {
            db.Entry(order).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
        public void UpdateQuantityInStorage(OrderDetail odt)
        {
            var sto = (from s in db.StorageShops select s).ToList();
            foreach(var item in sto)
            {
                if(item.ProductID == odt.ProductID)
                {
                    item.Quantity += odt.Quantity;
                }
                db.Entry(item).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }
            
        }
        //ORDERDETAIL
        public List<OrderDetail> DetailOrder (Guid id)
        {
            return db.OrderDetails.Where(p => p.OrderID == id).ToList();
        }
        public void AddOrderDetail(OrderDetail odt)
        {
            db.OrderDetails.Add(odt);
            db.SaveChanges();
        }
        public List<OrderDetail> GetOrderDetail()
        {
            return db.OrderDetails.ToList();
        }
        //STORAGE 
        public List<StorageShop> GetAllStorage ()
        {
            return db.StorageShops.ToList();
        }
        public void AddQuantityNewProduct(StorageShop sto)
        {
            db.StorageShops.Add(sto);
            db.SaveChanges();
        }
        public StorageShop GetStoByID(string id)
        {
            return db.StorageShops.Find(id);
        }
        public void UpdateQuantityProduct(StorageShop sto)
        {
            db.Entry(sto).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
        //REPORT
        public List<Order> ReportOrderInDay(DateTime day)
        {
            var orderinday = (from order in db.Orders where order.DateCreate.Value.Day == day.Day select order).ToList();
            return orderinday;
        }
        public int ReportSumPro(DateTime day)
        {
            int sumpro = 0;
            var orderinday = (from order in db.Orders where order.DateCreate.Value.Day == day.Day select order).ToList();
            var orderdetail = (from odt in db.OrderDetails select odt).ToList();
            foreach(var item in orderinday)
            {
                foreach(var itemodt in orderdetail)
                {
                    if(item.ID == itemodt.OrderID)
                    {
                        sumpro += itemodt.Quantity;
                    }
                }
            }
            return sumpro;
        }
        public double ReportSumMoney(DateTime day)
        {
            double summoney = 0;
            var orderinday = (from order in db.Orders where order.DateCreate.Value.Day == day.Day select order).ToList();
            var orderdetail = (from odt in db.OrderDetails select odt).ToList();
            foreach (var item in orderinday)
            {
                foreach (var itemodt in orderdetail)
                {
                    if (item.ID == itemodt.OrderID)
                    {
                        summoney += itemodt.Quantity*itemodt.UnitPrice;
                    }
                }
            }
            return summoney;
        }
        //LogIn WINFORM
        public bool Check_Login(string account, string password)
        {
            try
            {

                var acc = (from account1 in db.Accounts
                           where account1.ID.Equals(account)
                           select new
                           {
                               account = account1.ID,
                               password = account1.Password
                           }).Single();
                if (password.Equals(password))
                {
                    return true;
                }
                return false;

            }
            catch
            {
                return false;
            }
        }

        //**************************************************************************
        //**************************************************************************


        //INTERFACE SERVICE FORM MVC
        
        //Product By Category
        public List<Product> GetProductByCategory(int id)
        {
            var productbycategory = (from product in db.Products
                                    where product.CategoryID == id
                                    select product).ToList();
            return productbycategory;
        }
        //Detail in Product
        public List<Product> GetDetailById(string id)
        {
            var detailinproduct = (from product in db.Products
                                  where product.ID == id
                                  select product).ToList();
            return detailinproduct;
        }
       
        //LogIn MVC
        public Account LogIn(string account, string password)
        {
            var acc = (from account1 in db.Accounts
                       where account1.ID == account && account1.Password == password
                       select account1).SingleOrDefault();
            return acc;
        }
        //Register MVC
        public Account Register(string UserName, string Password, string Phone, string Address, string Name)
        {
            Account account = new Account();
            account.ID = UserName;
            account.Password = Password;
            account.Phone = Phone;
            account.Address = Address;
            account.Name = Name;
            account.UserTypeID = 1;
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

        //Search Product
        public List<Product> SearchBasic(int? page, string txtSearch)
        {
            var search = (from pr in db.Products
                          where pr.ProductName.Contains(txtSearch.ToString())
                          select pr).ToList();
            return search;
        }
    }
}
