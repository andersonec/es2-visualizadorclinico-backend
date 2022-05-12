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
    [Route("v1.0/Login")]
    public class _LoginController : ControllerBase
    {
        private readonly IAuthAppService _authService;

        public _LoginController(IAuthAppService authService)
        {
            _authService = authService;
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult<Object> Authenticate([FromBody] UsuarioLoginDTO usuarioLogin)
        {
            try
            {
                var user = _authService.UserLogin(usuarioLogin);

                if (user == null)
                    return NotFound();

                return _authService.GenerateToken(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
