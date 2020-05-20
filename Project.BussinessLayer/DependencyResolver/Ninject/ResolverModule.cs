using Common.Core.DataAccess.EntityFramework;
using Ninject.Modules;
using Project.BussinessLayer.Concrete;
using Project.BussinessLayer.Interface;
using Project.DataAccess.Concrete.EntityFramework;
using Project.DataAccess.Concrete.EntityFramework.Context;
using Project.DataAccess.Interface;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessLayer.DependencyResolver.Ninject
{
    public class ResolverModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductManager>().To<ProductManager>();
            // In case of framework change, only code required is below.
            Bind<IProductDAL>().To<EFProductDAL>();
        }
    }
}
