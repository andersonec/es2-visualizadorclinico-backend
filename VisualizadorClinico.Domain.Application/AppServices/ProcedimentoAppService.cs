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
    public class ProcedimentoAppService : IProcedimentoAppService
    {
        private readonly IProcedimentoMapper _userMapper;
        public readonly IProcedimentoRepository _userRepository;

        public ProcedimentoAppService(IProcedimentoRepository userRepository, IProcedimentoMapper userMapper)
        {
            _userMapper = userMapper;
            _userRepository = userRepository;
        }

        public void Add(ProcedimentoDTO obj)
        {
            if (obj != null)
            {
                var user = _userMapper.MapperToEntity(obj);

                _userRepository.Add(user);
            }
            else
                return;
        }

        public virtual IEnumerable<ProcedimentoDTO> GetAll()
        {
            var user = _userRepository.GetAll();

            if (user == null)
                return null;
            else
                return _userMapper.MapperListProcedimentos(user);
        }

        public virtual ProcedimentoDTO GetById(int id)
        {
            var user = _userRepository.GetById(id);
            return _userMapper.MapperToDTO(user);
        }
        public virtual void Update(ProcedimentoDTO obj)
        {
            var user = _userMapper.MapperToEntity(obj);
            _userRepository.Update(user);
        }
        public virtual void Remove(ProcedimentoDTO obj)
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
