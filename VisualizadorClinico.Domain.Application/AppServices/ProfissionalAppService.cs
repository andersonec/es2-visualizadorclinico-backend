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
    public class ProfissionalAppService : IProfissionalAppService
    {
        private readonly IProfissionalMapper _profissionalMapper;
        public readonly IProfissionalRepository _profissionalRepository;

        public ProfissionalAppService(IProfissionalRepository profissionalRepository, IProfissionalMapper profissionalMapper)
        {
            _profissionalMapper = profissionalMapper;
            _profissionalRepository = profissionalRepository;
        }

        public ProfissionalDTO Add(ProfissionalDTO obj)
        {
            if (obj != null)
            {
                var profissional = _profissionalMapper.MapperToEntity(obj);

                var newProfessional = _profissionalRepository.Add(profissional);

                return _profissionalMapper.MapperToDTO(newProfessional);
            }
            else
                return null;
        }

        public virtual IEnumerable<ProfissionalDTO> GetAll()
        {
            var profissional = _profissionalRepository.GetAll();

            if (profissional == null)
                return null;
            else
                return _profissionalMapper.MapperListProfissionais(profissional);
        }

        public virtual ProfissionalDTO GetById(int id)
        {
            var profissional = _profissionalRepository.GetById(id);
            return _profissionalMapper.MapperToDTO(profissional);
        }
        public virtual void Update(ProfissionalDTO obj)
        {
            var profissional = _profissionalMapper.MapperToEntity(obj);
            _profissionalRepository.Update(profissional);
        }
        public virtual void Remove(ProfissionalDTO obj)
        {
            var profissional = _profissionalMapper.MapperToEntity(obj);
            _profissionalRepository.Remove(profissional);
        }

        public void Dispose()
        {
            _profissionalRepository.Dispose();
        }
    }
}
