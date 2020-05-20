using Common.Core.DataAccess.EntityFramework;
using Project.DataAccess.Concrete.EntityFramework.Context;
using Project.DataAccess.Interface;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Concrete.EntityFramework
{
    public class EFProductDAL : EFEntityRepositoryBase<Product, DevDBContext>, IProductDAL
    {
        //Implementing special Methods related to Products in EF.
        private EFEntityRepositoryBase<Product, DevDBContext> _repo;

        public List<Product> GetAll()
        {
            return _repo.GetList();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _repo.GetList(p => p.CategoryID == categoryId);
        }

        public Product GetByProductId(int productId)
        {
            return _repo.Get(p=>p.ProductID == productId);
        }
    }
}
