using Autofac;
using ProjectECommerce.Cache;
using ProjectECommerce.Core.Models;
using ProjectECommerce.Core.Repositories;
using ProjectECommerce.Core.Services;
using ProjectECommerce.Core.UnitOfWorks;
using ProjectECommerce.Message.Service;
using ProjectECommerce.Repository;
using ProjectECommerce.Repository.Repositories;
using ProjectECommerce.Repository.UnitOfWorks;
using ProjectECommerce.Service.Mapping;
using ProjectECommerce.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace ProjectECommerce.API.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<PublisherService>().As<IPublisherService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductServiceWithCaching>().As<IProductService>().InstancePerLifetimeScope();

            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));
            var coreAssembly = Assembly.GetAssembly(typeof(Product));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly, coreAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly, coreAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();


            //InstancePerLifetimeScope => scope
            //InstancePerDependency => transient
        }
    }
}
