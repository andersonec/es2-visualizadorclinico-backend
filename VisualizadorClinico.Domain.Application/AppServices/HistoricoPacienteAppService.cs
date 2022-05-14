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
    public class HistoricoPacienteAppService : IHistoricoPacienteAppService
    {
        private readonly IHistoricoPacienteMapper _historicoPacienteMapper;
        public readonly IHistoricoPacienteRepository _historicoPacienteRepository;

        public HistoricoPacienteAppService(IHistoricoPacienteRepository historicoPacienteRepository, IHistoricoPacienteMapper historicoPacienteMapper)
        {
            _historicoPacienteMapper = historicoPacienteMapper;
            _historicoPacienteRepository = historicoPacienteRepository;
        }

        public void Add(HistoricoPacienteDTO obj)
        {
            if (obj != null)
            {
                var historicoPaciente = _historicoPacienteMapper.MapperToEntity(obj);

                _historicoPacienteRepository.Add(historicoPaciente);
            }
            else
                return;
        }

        public virtual IEnumerable<HistoricoPacienteDTO> GetAll()
        {
            var historicoPaciente = _historicoPacienteRepository.GetAll();

            if (historicoPaciente == null)
                return null;
            else
                return _historicoPacienteMapper.MapperListHistoricoPacientes(historicoPaciente);
        }

        public virtual HistoricoPacienteDTO GetById(int id)
        {
            var historicoPaciente = _historicoPacienteRepository.GetById(id);
            return _historicoPacienteMapper.MapperToDTO(historicoPaciente);
        }
        public virtual void Update(HistoricoPacienteDTO obj)
        {
            var historicoPaciente = _historicoPacienteMapper.MapperToEntity(obj);
            _historicoPacienteRepository.Update(historicoPaciente);
        }
        public virtual void Remove(HistoricoPacienteDTO obj)
        {
            var historicoPaciente = _historicoPacienteMapper.MapperToEntity(obj);
            _historicoPacienteRepository.Remove(historicoPaciente);
        }

        public void Dispose()
        {
            _historicoPacienteRepository.Dispose();
        }
    }
}
