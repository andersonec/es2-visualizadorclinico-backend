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
    public class HistoricoProfissionalAppService : IHistoricoProfissionalAppService
    {
        private readonly IHistoricoProfissionalMapper _historicoProfissionalMapper;
        public readonly IHistoricoProfissionalRepository _historicoProfissionalRepository;

        public HistoricoProfissionalAppService(IHistoricoProfissionalRepository historicoProfissionalRepository, IHistoricoProfissionalMapper historicoProfissionalMapper)
        {
            _historicoProfissionalMapper = historicoProfissionalMapper;
            _historicoProfissionalRepository = historicoProfissionalRepository;
        }

        public void Add(HistoricoProfissionalDTO obj)
        {
            if (obj != null)
            {
                var historicoProfissional = _historicoProfissionalMapper.MapperToEntity(obj);

                _historicoProfissionalRepository.Add(historicoProfissional);
            }
            else
                return;
        }

        public virtual IEnumerable<HistoricoProfissionalDTO> GetAll(int id_profissional)
        {
            var historicoProfissional = _historicoProfissionalRepository.GetAll(id_profissional);

            if (historicoProfissional == null)
                return null;
            else
                return _historicoProfissionalMapper.MapperListHistoricoProfissionais(historicoProfissional);
        }

        public virtual HistoricoProfissionalDTO GetById(int id)
        {
            var historicoProfissional = _historicoProfissionalRepository.GetById(id);
            return _historicoProfissionalMapper.MapperToDTO(historicoProfissional);
        }
        public virtual void Update(HistoricoProfissionalDTO obj)
        {
            var historicoProfissional = _historicoProfissionalMapper.MapperToEntity(obj);
            _historicoProfissionalRepository.Update(historicoProfissional);
        }
        public virtual void Remove(HistoricoProfissionalDTO obj)
        {
            var historicoProfissional = _historicoProfissionalMapper.MapperToEntity(obj);
            _historicoProfissionalRepository.Remove(historicoProfissional);
        }

        public void Dispose()
        {
            _historicoProfissionalRepository.Dispose();
        }
    }
}
