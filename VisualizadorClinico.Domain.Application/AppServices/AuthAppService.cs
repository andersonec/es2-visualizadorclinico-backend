using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.Application.IAppServices;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper;
using VisualizadorClinico.Infra.Data.IRepositories;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.AppServices
{
    public class AuthAppService : IAuthAppService
    {
        private readonly IUsuarioMapper _userMapper;
        private readonly IAuthRepository _authRepository;

        public AuthAppService(IAuthRepository authRepository, IUsuarioMapper userMapper)
        {
            _authRepository = authRepository;
            _userMapper = userMapper;
        }
        public UsuarioDTO UserLogin(UsuarioLoginDTO usuarioLogin)
        {
            var usuario = _authRepository.Validate(usuarioLogin.login, usuarioLogin.senha);

            if (usuario == null)
                return null;
            else
                return _userMapper.MapperToDTO(usuario);
        }

        public Token GenerateToken(UsuarioDTO usuarioDTO)
        {
            var usuario = _userMapper.MapperToEntity(usuarioDTO)
;
            return _authRepository.GenerateToken(usuario);
        }
    }
}
