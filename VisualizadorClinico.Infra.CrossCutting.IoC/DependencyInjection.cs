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

            builder.RegisterType<AdministradorAppService>().As<IAdministradorAppService>();
            builder.RegisterType<AuthAppService>().As<IAuthAppService>();
            builder.RegisterType<CirurgiaAppService>().As<ICirurgiaAppService>();
            builder.RegisterType<ConsultaAppService>().As<IConsultaAppService>();
            builder.RegisterType<EnderecoAppService>().As<IEnderecoAppService>();
            builder.RegisterType<EnfermeiroAppService>().As<IEnfermeiroAppService>();
            builder.RegisterType<ExameAppService>().As<IExameAppService>();
            builder.RegisterType<HistoricoPacienteAppService>().As<IHistoricoPacienteAppService>();
            builder.RegisterType<HistoricoProfissionalAppService>().As<IHistoricoProfissionalAppService>();
            builder.RegisterType<PacienteAppService>().As<IPacienteAppService>();
            builder.RegisterType<PessoaAppService>().As<IPessoaAppService>();
            builder.RegisterType<ProcedimentoAppService>().As<IProcedimentoAppService>();
            builder.RegisterType<ProfissionalAppService>().As<IProfissionalAppService>();
            builder.RegisterType<UsuarioAppService>().As<IUsuarioAppService>();
            builder.RegisterType<AgendaAppService>().As<IAgendaAppService>();
            builder.RegisterType<EvolucaoAppService>().As<IEvolucaoAppService>();

            #endregion


            #region Dependency Injection - Mapper

            builder.RegisterType<AdministradorMapper>().As<IAdministradorMapper>();
            builder.RegisterType<CirurgiaMapper>().As<ICirurgiaMapper>();
            builder.RegisterType<ConsultaMapper>().As<IConsultaMapper>();
            builder.RegisterType<EnderecoMapper>().As<IEnderecoMapper>();
            builder.RegisterType<EnfermeiroMapper>().As<IEnfermeiroMapper>();
            builder.RegisterType<ExameMapper>().As<IExameMapper>();
            builder.RegisterType<HistoricoPacienteMapper>().As<IHistoricoPacienteMapper>();
            builder.RegisterType<HistoricoProfissionalMapper>().As<IHistoricoProfissionalMapper>();
            builder.RegisterType<PacienteMapper>().As<IPacienteMapper>();
            builder.RegisterType<PessoaMapper>().As<IPessoaMapper>();
            builder.RegisterType<ProcedimentoMapper>().As<IProcedimentoMapper>();
            builder.RegisterType<ProfissionalMapper>().As<IProfissionalMapper>();
            builder.RegisterType<UsuarioMapper>().As<IUsuarioMapper>();
            builder.RegisterType<AgendaMapper>().As<IAgendaMapper>();
            builder.RegisterType<EvolucaoMapper>().As<IEvolucaoMapper>();

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
            builder.RegisterType<AgendaRepository>().As<IAgendaRepository>();
            builder.RegisterType<EvolucaoRepository>().As<IEvolucaoRepository>();

            #endregion


            #region Dependency Injection - Validations

            builder.RegisterType<PersonValidations>().As<IPersonValidations>();

            #endregion
        }
    }
}
