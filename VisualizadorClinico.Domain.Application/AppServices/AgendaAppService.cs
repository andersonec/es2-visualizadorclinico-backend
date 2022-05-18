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
    public class AgendaAppService : IAgendaAppService
    {
        private readonly IAgendaMapper _agendaMapper;
        public readonly IAgendaRepository _agendaRepository;
        public readonly IProfissionalRepository _profissionalRepository;

        public AgendaAppService(IAgendaRepository agendaRepository, IAgendaMapper agendaMapper, IProfissionalRepository profissionalRepository)
        {
            _agendaMapper = agendaMapper;
            _agendaRepository = agendaRepository;
            _profissionalRepository = profissionalRepository;
        }

        public AgendaDTO Add(AgendaDTO obj, string registro_profissional)
        {
            if (obj != null)
            {
                int id_profissional = _profissionalRepository.GetById(registro_profissional).id_profissional;

                if (id_profissional == 0)
                    return null;

                var agenda = _agendaMapper.MapperToEntity(obj);

                var newAgenda = _agendaRepository.Add(agenda, id_profissional);

                return _agendaMapper.MapperToDTO(newAgenda);
            }
            else
                return null;
        }

        public virtual IEnumerable<AgendaDTO> GetAll(string id)
        {
            int id_profissional = _profissionalRepository.GetById(id).id_profissional;
            var agenda = _agendaRepository.GetAll(id_profissional);

            if (agenda == null)
                return null;
            else
                return _agendaMapper.MapperListAgendas(agenda);
        }

        public virtual AgendaDTO GetById(int id)
        {
            var agenda = _agendaRepository.GetById(id);

            if (agenda == null)
                return null;

            return _agendaMapper.MapperToDTO(agenda);
        }
        public virtual void Update(AgendaDTO obj)
        {
            var agenda = _agendaMapper.MapperToEntity(obj);
            _agendaRepository.Update(agenda);
        }
        public virtual void Remove(AgendaDTO obj)
        {
            var agenda = _agendaMapper.MapperToEntity(obj);
            _agendaRepository.Remove(agenda);
        }

        public void Dispose()
        {
            _agendaRepository.Dispose();
        }
    }
}
