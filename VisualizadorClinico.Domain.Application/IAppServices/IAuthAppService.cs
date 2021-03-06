using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IAuthAppService
    {
        UsuarioDTO UserLogin(UsuarioLoginDTO usuarioLogin);
        Token GenerateToken(UsuarioDTO usuario);
    }
}
