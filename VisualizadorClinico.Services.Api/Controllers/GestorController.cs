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
    public class GestorController : ControllerBase
    {
        private readonly IPessoaAppService _pessoaAppService;
        private readonly IUsuarioAppService _usuarioAppService;
        private readonly IProfissionalAppService _profissionalAppService;
        private readonly IEnderecoAppService _enderecoAppService;

        public GestorController(IPessoaAppService pessoaAppService, IUsuarioAppService usuarioAppService, IProfissionalAppService profissionalAppService, IEnderecoAppService enderecoAppService)
        {
            _pessoaAppService = pessoaAppService;
            _usuarioAppService = usuarioAppService;
            _profissionalAppService = profissionalAppService;
            _enderecoAppService = enderecoAppService;
        }

        // Cadastrar Novos Profissionais.
        [HttpPost("CadastrarProfissional")]
        public ActionResult<NovoProfissionalResult> NewUser(NovoProfissional novoProfissional)
        {
            if (novoProfissional.pessoa == null)
                return BadRequest("Insira todos os dados de usuário.");

            if (novoProfissional.usuario == null)
                return BadRequest("Insira todos os dados de usuário");

            if (novoProfissional.profissional == null)
                return BadRequest("Insira todos os dados do profissional");

            if (novoProfissional.endereco == null)
                return BadRequest("Insira todos os dados do endereço do profissional");

            var pessoa = _pessoaAppService.Add(novoProfissional.pessoa);
            if (pessoa == null)
            {
                return BadRequest("Erro ao adicionar pessoa");
            }


            var usuario = new NovoUsuarioDTO
            {
                id_usuario = pessoa.id_pessoa,
                login = novoProfissional.usuario.login,
                senha = novoProfissional.usuario.senha,
                status = novoProfissional.usuario.status,
                tipo = novoProfissional.usuario.tipo
            };
            usuario = _usuarioAppService.Add(usuario);
            if (usuario == null)
            {
                _pessoaAppService.Remove(pessoa);
                return BadRequest("Erro ao adicionar usuário");
            }


            var profissional = new ProfissionalDTO
            {
                id_usuario = usuario.id_usuario,
                registro_profissional = novoProfissional.profissional.registro_profissional,
                especialidade = novoProfissional.profissional.especialidade
            };
            profissional = _profissionalAppService.Add(profissional);
            if (profissional == null)
            {
                _pessoaAppService.Remove(pessoa);
                _usuarioAppService.Remove(usuario);
                return BadRequest("Erro ao adicionar profissional");
            }

            var endereco = _enderecoAppService.Add(novoProfissional.endereco, pessoa.id_pessoa);
            if (usuario == null)
            {
                _usuarioAppService.Remove(usuario);
                _pessoaAppService.Remove(pessoa);
                _profissionalAppService.Remove(profissional);
                return BadRequest("Erro ao adicionar endereço");
            }

            var newUser = new NovoProfissionalResult
            {
                pessoa = pessoa,
                usuario = usuario,
                profissional = profissional,
                endereco = endereco
            };

            return Ok(newUser);
        }



        // Consultar Cadastro de Profissional.
        [HttpGet("ConsultarCadastroProfissional/{registro_profissional}")]
        public ActionResult<ProfissionalReturn> GetProfessional(string registro_profissional)
        {
            var profissional = _profissionalAppService.GetById(registro_profissional);
            if (profissional == null)
                return NotFound("Erro na busca pelos dados do profissional.");

            var usuario = _usuarioAppService.GetById(profissional.id_usuario);
            if (usuario == null)
                return NotFound("Erro na busca pelos dados do usuário.");

            var pessoa = _pessoaAppService.GetById(usuario.id_usuario);
            if (pessoa == null)
                return NotFound("Erro na busca pelos dados pessoais do profissional.");

            var endereco = _enderecoAppService.GetById(pessoa.id_pessoa);
            if (endereco == null)
                return NotFound("Erro na busca pelo endereço do profissional.");


            var prof = new ProfissionalReturn
            {
                pessoa = pessoa,
                usuario = usuario,
                profissional = profissional,
                endereco = endereco
            };

            return Ok(prof);
        }

        [HttpPut("AtualizarDadosProfissional")]
        public ActionResult UpdateProfessional(NovoProfissionalResult atualizarProfissional)
        {

            _pessoaAppService.Update(atualizarProfissional.pessoa);
            _usuarioAppService.Update(atualizarProfissional.usuario);
            _profissionalAppService.Update(atualizarProfissional.profissional);
            _enderecoAppService.Update(atualizarProfissional.endereco);

            return Ok();
        }
    }

    public class NovoProfissional
    {
        public NovaPessoaDTO pessoa { get; set; } = new NovaPessoaDTO();
        public NovoUsuarioDTO usuario { get; set; } = new NovoUsuarioDTO();
        public ProfissionalDTO profissional { get; set; } = new ProfissionalDTO();
        public EnderecoDTO endereco { get; set; } = new EnderecoDTO();
    }

    public class NovoProfissionalResult
    {
        public PessoaDTO pessoa { get; set; } = new PessoaDTO();
        public NovoUsuarioDTO usuario { get; set; } = new NovoUsuarioDTO();
        public ProfissionalDTO profissional { get; set; } = new ProfissionalDTO();
        public EnderecoDTO endereco { get; set; } = new EnderecoDTO();
    }

    public class ProfissionalReturn
    {
        public PessoaDTO pessoa { get; set; } = new PessoaDTO();
        public UsuarioDTO usuario { get; set; } = new UsuarioDTO();
        public ProfissionalDTO profissional { get; set; } = new ProfissionalDTO();
        public EnderecoDTO endereco { get; set; } = new EnderecoDTO();
    }
}
