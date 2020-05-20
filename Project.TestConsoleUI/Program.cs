using Project.BussinessLayer.Concrete;
using Project.BussinessLayer.Interface;
using Project.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.TestConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Console app to test the crud operations from DAL before creating the Web UI */
            IProductManager productManager = new ProductManager(new EFProductDAL());
            foreach(var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            Console.ReadLine();
        }
    }
}
