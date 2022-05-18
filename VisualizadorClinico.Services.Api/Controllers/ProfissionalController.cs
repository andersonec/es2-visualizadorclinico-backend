using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.Application.IAppServices;
using VisualizadorClinico.Domain.DTO;

namespace VisualizadorClinico.Services.Api.Controllers
{
    [ApiController]
    [Route("v1.0/[controller]")]
    public class ProfissionalController : ControllerBase
    {
        private readonly IPessoaAppService _pessoaAppService;
        private readonly IPacienteAppService _pacienteAppService;
        private readonly IConsultaAppService _consultaAppService;
        private readonly IProfissionalAppService _profissionalAppService;
        private readonly IHistoricoProfissionalAppService _historicoProfissionalAppService;
        private readonly IAgendaAppService _agendaAppService;

        public ProfissionalController(IPessoaAppService pessoaAppService, IPacienteAppService pacienteAppService, 
                                      IConsultaAppService consultaAppService, IProfissionalAppService profissionalAppService,
                                      IHistoricoProfissionalAppService historicoProfissionalAppService, IAgendaAppService agendaAppService)
        {
            _pessoaAppService = pessoaAppService;
            _pacienteAppService = pacienteAppService;
            _consultaAppService = consultaAppService;
            _profissionalAppService = profissionalAppService;
            _historicoProfissionalAppService = historicoProfissionalAppService;
            _agendaAppService = agendaAppService;
        }

        // Consultar dados de paciente
        [HttpGet("ConsultarCadastroPaciente/{registro_sus}")]
        public ActionResult<ConsultaPaciente> GetPatient(string registro_sus)
        {
            var paciente = _pacienteAppService.GetById(registro_sus);
            if (paciente == null)
                return NotFound("Erro na busca pelos dados do paciente.");

            var pessoa = _pessoaAppService.GetById(paciente.id_paciente);
            if (pessoa == null)
                return NotFound("Erro na busca pelos dados pessoais do paciente.");

            var prof = new ConsultaPaciente
            {
                pessoa = pessoa,
                paciente = paciente,
            };

            return Ok(prof);
        }


        // Realizar Consulta
        [HttpPost("RealizarConsulta")]
        public ActionResult AccomplishConsult(ConsultaDTO consulta, string registro_profissional, string registro_sus_paciente)
        {
            int id_profissional = _profissionalAppService.GetById(registro_profissional).id_usuario;
            int id_paciente = _pacienteAppService.GetById(registro_sus_paciente).id_paciente;

            var novaConsulta = _consultaAppService.Add(consulta, id_profissional, id_paciente);
            if (novaConsulta == null)
                return BadRequest("Erro ao salvar consulta");

            return Ok(novaConsulta);
        }


        // Consultar lista de consultas e exames realizados por ele mesmo.
        [HttpGet("ConsultarHistorico/{registro_profissional}")]
        public ActionResult ConsultarHistorico(string registro_profissional)
        {
            var profissional = _profissionalAppService.GetById(registro_profissional);
            if (profissional == null)
                return NotFound("Profissional não encontrado na base.");

            var historico = _historicoProfissionalAppService.GetAll(profissional.id_usuario);
            if (historico == null)
                return NotFound("Não foram encontrados procedimentos para o profissional.");

            return Ok(historico);
        }

        // Criar agenda de exames e consultas.
        [HttpPost("AdicionarNaAgenda")]
        public ActionResult AddAgenda(AgendaDTO agenda, string registro_profissional)
        {
            return Ok(_agendaAppService.Add(agenda, registro_profissional));
        }

        // Consultar Agenda
        [HttpGet("ConsultarAgenda/{registro_profissional}")]
        public ActionResult GetAgenda(string registro_profissional)
        {
            var agenda = _agendaAppService.GetAll(registro_profissional);

            if (agenda == null)
                return NotFound();

            return Ok(agenda);
        }

        // Atualizar Agenda
        [HttpPut("AtualizarAgenda")]
        public ActionResult UpdateAgenda(AgendaDTO agenda)
        {
            _agendaAppService.Update(agenda);

            if (agenda == null)
                return BadRequest();

            return Ok(agenda);
        }

        // Prescrever a Evolução do Paciente.
        // Solicitar Exames.
    }

    public class ConsultaPaciente
    {
        public PessoaDTO pessoa { get; set; } = new PessoaDTO();
        public PacienteDTO paciente { get; set; } = new PacienteDTO();
    }
}
