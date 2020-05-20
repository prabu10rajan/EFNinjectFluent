using Project.BussinessLayer.Interface;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductManager _productManager;

        /* Will face the same error as of MVC controller without Ninject. Hence making changes in NinjectWevCommon.cs*/
        public ProductsController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public List<Product> Get()
        {
            return _productManager.GetAll();
        }
    }
}
