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
    public class EnfermeiroAppService : IEnfermeiroAppService
    {
        private readonly IEnfermeiroMapper _enfermeiroMapper;
        public readonly IEnfermeiroRepository _enfermeiroRepository;

        public EnfermeiroAppService(IEnfermeiroRepository enfermeiroRepository, IEnfermeiroMapper enfermeiroMapper)
        {
            _enfermeiroMapper = enfermeiroMapper;
            _enfermeiroRepository = enfermeiroRepository;
        }

        public void Add(EnfermeiroDTO obj)
        {
            if (obj != null)
            {
                var enfermeiro = _enfermeiroMapper.MapperToEntity(obj);

                _enfermeiroRepository.Add(enfermeiro);
            }
            else
                return;
        }

        public virtual IEnumerable<EnfermeiroDTO> GetAll()
        {
            var enfermeiro = _enfermeiroRepository.GetAll();

            if (enfermeiro == null)
                return null;
            else
                return _enfermeiroMapper.MapperListEnfermeiros(enfermeiro);
        }

        public virtual EnfermeiroDTO GetById(int id)
        {
            var enfermeiro = _enfermeiroRepository.GetById(id);
            return _enfermeiroMapper.MapperToDTO(enfermeiro);
        }
        public virtual void Update(EnfermeiroDTO obj)
        {
            var enfermeiro = _enfermeiroMapper.MapperToEntity(obj);
            _enfermeiroRepository.Update(enfermeiro);
        }
        public virtual void Remove(EnfermeiroDTO obj)
        {
            var enfermeiro = _enfermeiroMapper.MapperToEntity(obj);
            _enfermeiroRepository.Remove(enfermeiro);
        }

        public void Dispose()
        {
            _enfermeiroRepository.Dispose();
        }
    }
}
