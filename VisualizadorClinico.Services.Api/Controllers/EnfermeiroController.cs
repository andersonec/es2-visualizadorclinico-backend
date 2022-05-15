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
    public class EnfermeiroController : ControllerBase
    {
        private readonly IPessoaAppService _pessoaAppService;
        private readonly IPacienteAppService _pacienteAppService;

        public EnfermeiroController(IPessoaAppService pessoaAppService, IPacienteAppService pacienteAppService)
        {
            _pessoaAppService = pessoaAppService;
            _pacienteAppService = pacienteAppService;
        }

        // Consultar dados de paciente
        [HttpGet("ConsultarCadastroPaciente/{registro_sus}")]
        public ActionResult<NovoPacienteResult> GetPatient(string registro_sus)
        {
            var paciente = _pacienteAppService.GetById(registro_sus);
            if (paciente == null)
                return NotFound("Erro na busca pelos dados do paciente.");

            var pessoa = _pessoaAppService.GetById(paciente.id_paciente);
            if (pessoa == null)
                return NotFound("Erro na busca pelos dados pessoais do paciente.");

            var prof = new NovoPacienteResult
            {
                pessoa = pessoa,
                paciente = paciente,
            };

            return Ok(prof);
        }

        // Adicionar dados relevantes na triagem
        [HttpPut("AtualizarDadosPaciente")]
        public ActionResult UpdatePatient(NovoPacienteResult atualizarPaciente)
        {

            _pessoaAppService.Update(atualizarPaciente.pessoa);
            _pacienteAppService.Update(atualizarPaciente.paciente);

            return Ok();
        }
    }
}
