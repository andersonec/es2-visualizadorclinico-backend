﻿using Microsoft.AspNetCore.Authorization;
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
    public class RecepcionistaController : ControllerBase
    {
        private readonly IPessoaAppService _pessoaAppService;
        private readonly IPacienteAppService _pacienteAppService;
        private readonly IEnderecoAppService _enderecoAppService;

        public RecepcionistaController(IPessoaAppService pessoaAppService, IPacienteAppService pacienteAppService, IEnderecoAppService enderecoAppService)
        {
            _pessoaAppService = pessoaAppService;
            _pacienteAppService = pacienteAppService;
            _enderecoAppService = enderecoAppService;
        }

        // Cadastrar paciente
        [HttpPost("CadastrarPaciente")]
        public ActionResult<NovoPacienteResult> NewPatient(NovoPaciente novoPaciente)
        {
            if (novoPaciente.pessoa == null)
                return BadRequest("Insira todos os dados pessoais do paciente.");

            if (novoPaciente.paciente == null)
                return BadRequest("Insira todos os dados do paciente");

            if (novoPaciente.endereco == null)
                return BadRequest("Insira todos os dados do endereço do paciente");


            var pessoa = _pessoaAppService.Add(novoPaciente.pessoa);
            if (pessoa == null)
            {
                return BadRequest("Erro ao adicionar pessoa");
            }

            var endereco = _enderecoAppService.Add(novoPaciente.endereco, pessoa.id_pessoa);
            if (endereco == null)
            {
                _pessoaAppService.Remove(pessoa);
                return BadRequest("Erro ao adicionar endereço");
            }

            var paciente = new PacienteDTO
            {
                id_paciente = pessoa.id_pessoa,
                data_cadastro = novoPaciente.paciente.data_cadastro,
                grupo = novoPaciente.paciente.grupo,
                registro_sus = novoPaciente.paciente.registro_sus,
                tipo_sanguineo = novoPaciente.paciente.tipo_sanguineo,
            };
            paciente = _pacienteAppService.Add(paciente);


            var newUser = new NovoPacienteResult
            {
                pessoa = pessoa,
                paciente = paciente,
                endereco = endereco,
            };

            return Ok(newUser);
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

            var endereco = _enderecoAppService.GetById(pessoa.id_pessoa);
            if (pessoa == null)
                return NotFound("Erro na busca pelo endereço do paciente.");

            var prof = new NovoPacienteResult
            {
                pessoa = pessoa,
                paciente = paciente,
                endereco=endereco,
            };

            return Ok(prof);
        }

        [HttpPut("AtualizarDadosPaciente")]
        public ActionResult UpdatePatient(NovoPacienteResult atualizarPaciente)
        {

            _pessoaAppService.Update(atualizarPaciente.pessoa);
            _pacienteAppService.Update(atualizarPaciente.paciente);
            _enderecoAppService.Update(atualizarPaciente.endereco);

            return Ok();
        }

        // Gerar senha de atendimento
    }

    public class NovoPaciente
    {
        public NovaPessoaDTO pessoa { get; set; } = new NovaPessoaDTO();
        public PacienteDTO paciente { get; set; } = new PacienteDTO();
        public EnderecoDTO endereco { get; set; } = new EnderecoDTO();
    }
    public class NovoPacienteResult
    {
        public PessoaDTO pessoa { get; set; } = new PessoaDTO();
        public PacienteDTO paciente { get; set; } = new PacienteDTO();
        public EnderecoDTO endereco { get; set; } = new EnderecoDTO();
    }
}
