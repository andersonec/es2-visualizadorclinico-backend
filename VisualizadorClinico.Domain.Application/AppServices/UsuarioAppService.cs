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
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioMapper _userMapper;
        public readonly IUsuarioRepository _userRepository;

        public UsuarioAppService(IUsuarioRepository userRepository, IUsuarioMapper userMapper)
        {
            _userMapper = userMapper;
            _userRepository = userRepository;
        }

        public void Add(UsuarioDTO obj)
        {
            if (obj != null)
            {
                var user = _userMapper.MapperToEntity(obj);

                _userRepository.Add(user);
            }
            else
                return;
        }

        public virtual IEnumerable<UsuarioDTO> GetAll()
        {
            var user = _userRepository.GetAll();

            if (user == null)
                return null;
            else
                return _userMapper.MapperListUsers(user);
        }

        public virtual UsuarioDTO GetById(int id)
        {
            var user = _userRepository.GetById(id);
            return _userMapper.MapperToDTO(user);
        }
        public virtual void Update(UsuarioDTO obj)
        {
            var user = _userMapper.MapperToEntity(obj);
            _userRepository.Update(user);
        }
        public virtual void Remove(UsuarioDTO obj)
        {
            var user = _userMapper.MapperToEntity(obj);
            _userRepository.Remove(user);
        }

        public void Dispose()
        {
            _userRepository.Dispose();
        }
    }
}
