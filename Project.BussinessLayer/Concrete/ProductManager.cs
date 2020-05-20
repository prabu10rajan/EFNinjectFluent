using Common.Core;
using Common.Core.Validation.FluentValidation;
////using Common.Core.Validation.Postsharp;
using Project.BussinessLayer.Interface;
using Project.BussinessLayer.Validation.FluentValidation;
using Project.DataAccess.Concrete.EntityFramework;
using Project.DataAccess.Interface;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessLayer.Concrete
{
    //Instead of calling the ProducalDAL, implement dependency injection.
    public class ProductManager : IProductManager
    {
        private IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        ////[FluentValidatorAspect(typeof(ProductFluentValidator))]
        public void Add(Product product)
        {
            //Implementing Fluent Validation in Business Layer
            FluentValidator.FluentValidate(new ProductFluentValidator(), product);
            _productDAL.Add(product);
        }

        public void Delete(Product product)
        {
            _productDAL.Delete(product);
        }

        public void Update(Product product)
        {
            _productDAL.Update(product);
        }

        //Special Methods implemented in IProductDAL
        public List<Product> GetAll()
        {
            return _productDAL.GetList();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _productDAL.GetAllByCategory(categoryId);
        }

        public Product GetByProductId(int productId)
        {
            return _productDAL.GetByProductId(productId);
        }
    }
}
