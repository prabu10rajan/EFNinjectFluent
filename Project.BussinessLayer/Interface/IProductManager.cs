using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessLayer.Interface
{
    public interface IProductManager
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<Product> GetAll();
        List<Product> GetAllByCategory(int categoryId);
        Product GetByProductId(int productId);        
    }
}
