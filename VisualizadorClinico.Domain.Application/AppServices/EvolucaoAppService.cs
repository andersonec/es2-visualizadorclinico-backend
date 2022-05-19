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
    public class EvolucaoAppService : IEvolucaoAppService
    {
        private readonly IEvolucaoMapper _Mapper;
        public readonly IEvolucaoRepository _Repository;

        public EvolucaoAppService(IEvolucaoRepository Repository, IEvolucaoMapper Mapper)
        {
            _Mapper = Mapper;
            _Repository = Repository;
        }

        public EvolucaoPacienteDTO Add(EvolucaoPacienteDTO obj)
        {
            if (obj != null)
            {
                var exame = _Mapper.MapperToEntity(obj);

                var exameNew = _Repository.Add(exame);

                return _Mapper.MapperToDTO(exameNew);
            }
            else
                return null;
        }

        public virtual IEnumerable<EvolucaoPacienteDTO> GetAll(int id)
        {
            var exame = _Repository.GetAll(id);

            if (exame == null)
                return null;
            else
                return _Mapper.MapperListEvolucoes(exame);
        }

        public virtual EvolucaoPacienteDTO GetById(int id)
        {
            var exame = _Repository.GetById(id);
            return _Mapper.MapperToDTO(exame);
        }
        public virtual void Update(EvolucaoPacienteDTO obj)
        {
            var exame = _Mapper.MapperToEntity(obj);
            _Repository.Update(exame);
        }
        public virtual void Remove(EvolucaoPacienteDTO obj)
        {
            var exame = _Mapper.MapperToEntity(obj);
            _Repository.Remove(exame);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
