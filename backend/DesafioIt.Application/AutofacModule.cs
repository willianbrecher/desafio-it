using Autofac;
using AutoMapper;
using DesafioIt.Domain.Enums;
using DesafioIt.Domain.Repositories;
using DesafioIt.EntityFramework;
using DesafioIt.EntityFramework.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using AutoMapAttribute = DesafioIt.Domain.Attributes.AutoMapAttribute;

namespace DesafioIt.Application
{
    public class AutofacModule : Autofac.Module
    {
        private readonly IConfiguration Configuration;

        public AutofacModule(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            var applicationAssembly = AppDomain.CurrentDomain.Load($"DesafioIt.Application");
            var domainAssembly = AppDomain.CurrentDomain.Load($"DesafioIt.Domain");
            var efAssembly = AppDomain.CurrentDomain.Load($"DesafioIt.Entityframework");

            #region MediatR

            builder.RegisterType<Mediator>()
                .As<IMediator>()
                .InstancePerLifetimeScope();

            var openHandlersTypes = new[] { typeof(IRequestHandler<,>), typeof(INotificationHandler<>) };
            foreach (var openHandlerType in openHandlersTypes)
                builder
                    .RegisterAssemblyTypes(applicationAssembly)
                    .AsClosedTypesOf(openHandlerType)
                    .InstancePerDependency();

            #endregion

            #region AutoMapper

            Assembly[] assemblies = new System.Reflection.Assembly[3] { domainAssembly, applicationAssembly, efAssembly };

            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                var autoMapAttribute = typeof(AutoMapAttribute);
                foreach (var type in assemblies.SelectMany(assembly => assembly.GetTypes()))
                {
                    var autoMapAttributes = type.GetCustomAttributes(autoMapAttribute, false);
                    if (!autoMapAttributes.Any()) continue;
                    foreach (AutoMapAttribute attribute in autoMapAttributes)
                    {
                        switch (attribute.Direction)
                        {
                            case AutoMapperDirections.To:
                                _ = cfg.CreateMap(type, attribute.T);
                                break;
                            case AutoMapperDirections.From:
                                _ = cfg.CreateMap(attribute.T, type);
                                break;
                            case AutoMapperDirections.Both:
                                _ = cfg.CreateMap(type, attribute.T);
                                _ = cfg.CreateMap(attribute.T, type);
                                break;
                        }
                    }
                }
            });

            builder.Register(c => mapperConfiguration.CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
            #endregion

            #region Repositories

            builder.RegisterType<DishRepository>().As<IDishRepository>().InstancePerLifetimeScope();
            
            #endregion

            #region EF
            DbContextOptionsBuilder<DesafioItContext> optionsBuilder = new();

            optionsBuilder.UseNpgsql(Configuration["ConnectionStrings:SQLDatabase"], x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName, "application"));

            builder.Register(x =>
            {
                return new DesafioItContext(optionsBuilder.Options);
            }).As<DbContext>().InstancePerDependency();
            #endregion
        }
    }
}