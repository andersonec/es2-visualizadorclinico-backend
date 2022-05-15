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

        public GestorController(IPessoaAppService pessoaAppService, IUsuarioAppService usuarioAppService, IProfissionalAppService profissionalAppService)
        {
            _pessoaAppService = pessoaAppService;
            _usuarioAppService = usuarioAppService;
            _profissionalAppService = profissionalAppService;
        }

        // Cadastrar Novos Profissionais.
        [HttpPost("CadastrarProfissional")]
        public ActionResult<NewProfessionalReturn> NewUser(NewUser novoUsuario)
        {
            if (novoUsuario.pessoa == null)
                return BadRequest("Insira todos os dados de usuário.");

            if (novoUsuario.usuario == null)
                return BadRequest("Insira todos os dados de usuário");

            if (novoUsuario.profissional == null)
                return BadRequest("Insira todos os dados do profissional");

            var pessoa = _pessoaAppService.Add(novoUsuario.pessoa);

            var usuario = new NovoUsuarioDTO
            {
                id_usuario = pessoa.id_pessoa,
                login = novoUsuario.usuario.login,
                senha = novoUsuario.usuario.senha,
                status = novoUsuario.usuario.status,
                tipo = novoUsuario.usuario.tipo
            };
            usuario = _usuarioAppService.Add(usuario);

            var profissional = new ProfissionalDTO
            {
                id_usuario = usuario.id_usuario,
                registro_profissional = novoUsuario.profissional.registro_profissional,
                especialidade = novoUsuario.profissional.especialidade
            };
            profissional = _profissionalAppService.Add(novoUsuario.profissional);


            var newUser = new NewProfessionalReturn
            {
                pessoa = pessoa,
                usuario = usuario,
                profissional = profissional
            };

            return Ok(newUser);
        }



        // Consultar Cadastro de Profissional.
        [HttpGet("ConsultarCadastroProfissional/{registro_profissional}")]
        public ActionResult<ProfessionalReturn> GetProfessional(int registro_profissional)
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

            var prof = new ProfessionalReturn
            {
                pessoa = pessoa,
                usuario = usuario,
                profissional = profissional
            };

            return Ok(prof);
        }

        [HttpPut("AtualizarDadosProfissional")]
        public ActionResult UpdateProfessional(NewProfessionalReturn atualizarProfissional)
        {

            _pessoaAppService.Update(atualizarProfissional.pessoa);
            _usuarioAppService.Update(atualizarProfissional.usuario);
            _profissionalAppService.Update(atualizarProfissional.profissional);

            return Ok();
        }
    }

    public class NewUser
    {
        public NovaPessoaDTO pessoa { get; set; } = new NovaPessoaDTO();
        public NovoUsuarioDTO usuario { get; set; } = new NovoUsuarioDTO();
        public ProfissionalDTO profissional { get; set; } = new ProfissionalDTO();
    }

    public class NewProfessionalReturn
    {
        public PessoaDTO pessoa { get; set; } = new PessoaDTO();
        public NovoUsuarioDTO usuario { get; set; } = new NovoUsuarioDTO();
        public ProfissionalDTO profissional { get; set; } = new ProfissionalDTO();
    }

    public class ProfessionalReturn
    {
        public PessoaDTO pessoa { get; set; } = new PessoaDTO();
        public UsuarioDTO usuario { get; set; } = new UsuarioDTO();
        public ProfissionalDTO profissional { get; set; } = new ProfissionalDTO();
    }
}
