//using Common.Core.Validation.FluentValidation;
//using FluentValidation;
//using PostSharp.Aspects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Common.Core.Validation.Postsharp
//{

//    public class FluentValidatorAspect : OnMethodBoundaryAspect
//    {
//        Type _validatorType;

//        public FluentValidatorAspect(Type validatorType)
//        {
//            _validatorType = validatorType;
//        }

//        public override void OnEntry(MethodExecutionArgs args)
//        {
//            var validator = (IValidator)Activator.CreateInstance(_validatorType);

//            // Takes the first generic argument from the IValidator passed(here Product from 'ProductFluentValidator : AbstractValidator<Product>')
//            var entityType = _validatorType.BaseType.GetGenericArguments()[0];

//            // Checks whether Validator entity is same as entity from calling statement.
//            // Product from 'ProductFluentValidator : AbstractValidator<Product>' 
//            // and 
//            // 'FluentValidator.FluentValidate(new ProductFluentValidator(), product);' 
//            // or 'public void Add(Product product)' after the filter '[FluentValidatorAspect(typeof(ProductFluentValidator))]' 
//            var entities = args.Arguments.Where(t => t.GetType() == entityType);

//            //In case we include more entities in 'ProductFluentValidator : AbstractValidator<Product, Category, Supplier>'
//            foreach (var entity in entities)
//            {
//                FluentValidator.FluentValidate(validator, entity);
//            }
//        }
//    }
//}
