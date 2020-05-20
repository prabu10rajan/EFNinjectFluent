using FluentValidation;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BussinessLayer.Validation.FluentValidation
{
    public class ProductFluentValidator : AbstractValidator<Product>
    {
        public ProductFluentValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.CategoryID).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryID == 1);
            RuleFor(p => p.ProductName).Must(StartWithT).WithMessage("Product name should start with T");
        }

        // Custom rules can be defined as delegate in Must method.
        private bool StartWithT(string arg)
        {
            return arg.StartsWith("T");
        }
    }
}
