using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MobileStoreService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMobileService" in both code and config file together.
    [ServiceContract]
    public interface IMobileService
    {
        //INTERFACE SERVICE FOR WINFORM
        //Interface Product
        [OperationContract]
        List<Product> GetAll();
        [OperationContract]
        Product GetByID(string id);
        [OperationContract]
        void AddProduct(Product product);
        [OperationContract]
        void UpdateProduct(Product product);
        [OperationContract]
        void DeleteProduct(string id);
        [OperationContract]
        bool CheckIDProduct(string id);
        //Interface Account
        [OperationContract]
        List<Account> GetAllAccount();
        [OperationContract]
        Account GetAccountByID(string id);
        [OperationContract]
        void EditAccount(Account account);
        [OperationContract]
        void DeleteAccount(string id);
        //Interface Category
        [OperationContract]
        List<Category> GetAllCategory();
        [OperationContract]
        List<Category> GetAllCategory1();
        [OperationContract]
        Category GetCategoryByID(int id);
        [OperationContract]
        void AddCategory(Category category);
        [OperationContract]
        void UpdateCategory(Category category);
        [OperationContract]
        void DeleteCategory(int id);
        //Interface Order
        [OperationContract]
        void AddOrder(Order order);
        [OperationContract]
        List<Order> GetAllOrder();
        [OperationContract]
        Order GetOrderByID(Guid id);
        [OperationContract]
        void UpdateOrder(Order order);
        [OperationContract]
        void DeleteOrder(Guid id);
        [OperationContract]
        List<OrderDetail> DetailOrder(Guid id);
        [OperationContract]
        void UpdateStorage(string productID, int quantity);
        [OperationContract]
        void UpdateStatus(Order order);
        [OperationContract]
        void UpdateQuantityInStorage(OrderDetail odt);
        //Interface LogIn WINFORM
        [OperationContract]
        bool Check_Login(string account, string password);
        //Interface OrderDetail
        [OperationContract]
        void AddOrderDetail(OrderDetail odt);
        [OperationContract]
        List<OrderDetail> GetOrderDetail();
        //Interface Storage
        [OperationContract]
        List<StorageShop> GetAllStorage();
        [OperationContract]
        void AddQuantityNewProduct(StorageShop sto);
        [OperationContract]
        StorageShop GetStoByID(string id);
        [OperationContract]
        void UpdateQuantityProduct(StorageShop sto);
        //Interface Report
        [OperationContract]
        List<Order> ReportOrderInDay(DateTime day);
        [OperationContract]
        int ReportSumPro(DateTime day);
        [OperationContract]
        double ReportSumMoney(DateTime day);
        //**************************************************************************
        //**************************************************************************

        //INTERFACE SERVICE FOR MVC
        //Interface Login MVC
        [OperationContract]
        Account LogIn(string account, string password);
        [OperationContract]
        //Interface Register MVC 
        Account Register(string UserName, string Password, string Phone, string Address, string Name);
        //Interface Product by Category
        [OperationContract]
        List<Product> GetProductByCategory(int id);
        //Interface Detail in Product
        [OperationContract]
        List<Product> GetDetailById(string id);

        [OperationContract]
        List<Product> SearchBasic(int? page, string txtSearch);
    }
}
