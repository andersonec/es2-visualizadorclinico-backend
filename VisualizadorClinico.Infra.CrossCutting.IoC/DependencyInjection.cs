using Autofac;
using VisualizadorClinico.Domain.Application.AppServices;
using VisualizadorClinico.Domain.Application.IAppServices;
using VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper;
using VisualizadorClinico.Infra.CrossCutting.Adapter.Mapper;
using VisualizadorClinico.Infra.CrossCutting.Validation.IValidations;
using VisualizadorClinico.Infra.CrossCutting.Validation.Validations;
using VisualizadorClinico.Infra.Data.IRepositories;
using VisualizadorClinico.Infra.Data.Repositories;

namespace VisualizadorClinico.Infra.CrossCutting.IoC
{
    public class DependencyInjection
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Dependency Injection - Domain.Application

            builder.RegisterType<UsuarioAppService>().As<IUsuarioAppService>();
            builder.RegisterType<AuthAppService>().As<IAuthAppService>();

            #endregion


            #region Dependency Injection - Mapper

            builder.RegisterType<UsuarioMapper>().As<IUsuarioMapper>();

            #endregion


            #region Dependency Injection - SQL Repositories

            builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();
            builder.RegisterType<AuthRepository>().As<IAuthRepository>();

            #endregion


            #region Dependency Injection - Validations

            builder.RegisterType<PersonValidations>().As<IPersonValidations>();

            #endregion
        }
    }
}
