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
    public class ExameAppService : IExameAppService
    {
        private readonly IExameMapper _exameMapper;
        public readonly IExameRepository _exameRepository;

        public ExameAppService(IExameRepository exameRepository, IExameMapper exameMapper)
        {
            _exameMapper = exameMapper;
            _exameRepository = exameRepository;
        }

        public ExameDTO Add(ExameDTO obj)
        {
            if (obj != null)
            {
                var exame = _exameMapper.MapperToEntity(obj);

                var exameNew = _exameRepository.Add(exame);

                return _exameMapper.MapperToDTO(exameNew);
            }
            else
                return null;
        }

        public ExameDTO AddRealized(ExameDTO obj, int id_profissional, int id_paciente)
        {
            if (obj != null)
            {
                var exame = _exameMapper.MapperToEntity(obj);

                var novoExame = _exameRepository.AddRealized(exame, id_profissional, id_paciente);

                return _exameMapper.MapperToDTO(novoExame);
            }
            else
                return null;
        }

        public virtual IEnumerable<ExameDTO> GetAll()
        {
            var exame = _exameRepository.GetAll();

            if (exame == null)
                return null;
            else
                return _exameMapper.MapperListExames(exame);
        }

        public virtual ExameDTO GetById(int id)
        {
            var exame = _exameRepository.GetById(id);
            return _exameMapper.MapperToDTO(exame);
        }
        public virtual void Update(ExameDTO obj)
        {
            var exame = _exameMapper.MapperToEntity(obj);
            _exameRepository.Update(exame);
        }
        public virtual void Remove(ExameDTO obj)
        {
            var exame = _exameMapper.MapperToEntity(obj);
            _exameRepository.Remove(exame);
        }

        public void Dispose()
        {
            _exameRepository.Dispose();
        }
    }
}
