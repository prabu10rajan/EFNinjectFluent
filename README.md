# EFNinjectFluent
Study Project.

Overview :-

ASP.Net project to exercise concepts like Ninject IoC, Fluent Validation, Aspect Oriented Programming and generics to reduce coding replication at core level. 
Implemented Model First approch of Entity Framework, MVC for WebUI, Web API.

Objective :-

1. Modular programming - 
Common functionalities that could be used among different projects are defined in Common.Core project.
Aspect oriented programming in FluentValidatorAspect.cs using Postsharp package. Here OnMethodBoundaryAspect is used, which is similar to OnActionExecution custom filters.
Segregation of classes to provide high flexibility for code migration.

2. Generic programming -
EFEntityRepositoryBase.cs represents the generic class which takes in entity class and dbcontext to define the CRUD operations. This reduces the code replication for every new entity and dbcontext created. Thereby allowing us to create only required special methods for every new entity class created. 
FluentValidator.cs represents the execution point of fluent validators created for any model.

3. Ninject IoC -
Abstraction is injected in different projects using Ninject containers.
ResolverModule.cs resolves at Business level.
NinjectControllerFactory.cs resolves dependency of controller instance creation for MVC.
NinjectWebCommon.cs resolves dependency of api controller instance creation at WebAPI level by configuring Ninject at Global configuration as Dependency Resolver.

4. Test Console -
Console app to test the DB operations at code level before implementing at Web UI.


Need to implement the remaining CRUD operations apart from GET at MVC and WebAPI. Setup MvcWebUI or WebApi as startup project

Test urls - 
http://localhost:xxxxx/Product/Index and 
http://localhost:xxxxx/api/products
