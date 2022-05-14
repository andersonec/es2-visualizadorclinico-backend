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

            builder.RegisterType<AdministradorRepository>().As<IAdministradorRepository>();
            builder.RegisterType<AuthRepository>().As<IAuthRepository>();
            builder.RegisterType<CirurgiaRepository>().As<ICirurgiaRepository>();
            builder.RegisterType<ConsultaRepository>().As<IConsultaRepository>();
            builder.RegisterType<EnderecoRepository>().As<IEnderecoRepository>();
            builder.RegisterType<EnfermeiroRepository>().As<IEnfermeiroRepository>();
            builder.RegisterType<ExameRepository>().As<IExameRepository>();
            builder.RegisterType<HistoricoPacienteRepository>().As<IHistoricoPacienteRepository>();
            builder.RegisterType<HistoricoProfissionalRepository>().As<IHistoricoProfissionalRepository>();
            builder.RegisterType<PacienteRepository>().As<IPacienteRepository>();
            builder.RegisterType<PessoaRepository>().As<IPessoaRepository>();
            builder.RegisterType<ProcedimentoRepository>().As<IProcedimentoRepository>();
            builder.RegisterType<ProfissionalRepository>().As<IProfissionalRepository>();
            builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();

            #endregion


            #region Dependency Injection - Validations

            builder.RegisterType<PersonValidations>().As<IPersonValidations>();

            #endregion
        }
    }
}
