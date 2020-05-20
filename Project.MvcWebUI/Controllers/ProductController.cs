using Project.BussinessLayer.Concrete;
using Project.BussinessLayer.Interface;
using Project.BussinessLayer.Validation.FluentValidation;
using Project.DataAccess.Concrete.EntityFramework;
using Project.Entities.Concrete;
using Project.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductManager _productManager;

        public ProductController(IProductManager productManager)
        {
            // This will throw no parameterless constructor error. We need to setup Ninject for Mvc in the Core Project.
            // We have to override GetControllerInstance in DefaultControllerFactory with the NinjectControllerFactory.
            // Overriden ControllerFactory must be set in the Global.asax
            // So everytime controller instance is about to be created, the GetControllerInstance will get the reference for NinjectModule through INinjectModule from the constructor of NinjectControllerFactory.
            // We have binded the IProductManager interface with ProductManager in ResolverModule.cs
            _productManager = productManager;
        }

        // GET: Product
        public ActionResult Index()
        {
            //IProductManager productManager = new ProductManager(new EFProductDAL());
            var model = new ProductModel()
            {
                //Products = productManager.GetAll()
                Products = _productManager.GetAll()
            };
            return View(model);
        }

        /* This method will throw error as Fluent Validator will limit the entry the entered Product. */
        public string Add()
        {
            Product product = new Product { ProductName = "Onion" };
            _productManager.Add(product);
            return "Added";
        }
    }
}