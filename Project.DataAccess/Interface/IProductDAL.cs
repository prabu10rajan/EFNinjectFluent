using Common.Core.DataAccess;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Interface
{
    public interface IProductDAL : IEntityRepository<Product>
    {
        // Special additional methods related to Products.
        // Additionally this class can access the common methods in IEntityRepository irrespective of Entity.
        // If in future we want to migrate from EF to other frameworks, we just need to change from IEntityRepository to the respective implementation.
        // There wont be necessary code changes from UI till this layer in such cases.
        List<Product> GetAll();
        List<Product> GetAllByCategory(int categoryId);
        Product GetByProductId(int productId);
    }
}
