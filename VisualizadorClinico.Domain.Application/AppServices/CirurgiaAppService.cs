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
    public class CirurgiaAppService : ICirurgiaAppService
    {
        private readonly ICirurgiaMapper _cirurgiaMapper;
        public readonly ICirurgiaRepository _cirurgiaRepository;

        public CirurgiaAppService(ICirurgiaRepository cirurgiaRepository, ICirurgiaMapper cirurgiaMapper)
        {
            _cirurgiaMapper = cirurgiaMapper;
            _cirurgiaRepository = cirurgiaRepository;
        }

        public void Add(CirurgiaDTO obj)
        {
            if (obj != null)
            {
                var cirurgia = _cirurgiaMapper.MapperToEntity(obj);

                _cirurgiaRepository.Add(cirurgia);
            }
            else
                return;
        }

        public virtual IEnumerable<CirurgiaDTO> GetAll()
        {
            var cirurgia = _cirurgiaRepository.GetAll();

            if (cirurgia == null)
                return null;
            else
                return _cirurgiaMapper.MapperListCirurgias(cirurgia);
        }

        public virtual CirurgiaDTO GetById(int id)
        {
            var cirurgia = _cirurgiaRepository.GetById(id);
            return _cirurgiaMapper.MapperToDTO(cirurgia);
        }
        public virtual void Update(CirurgiaDTO obj)
        {
            var cirurgia = _cirurgiaMapper.MapperToEntity(obj);
            _cirurgiaRepository.Update(cirurgia);
        }
        public virtual void Remove(CirurgiaDTO obj)
        {
            var cirurgia = _cirurgiaMapper.MapperToEntity(obj);
            _cirurgiaRepository.Remove(cirurgia);
        }

        public void Dispose()
        {
            _cirurgiaRepository.Dispose();
        }
    }
}
