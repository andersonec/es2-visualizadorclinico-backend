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
    public class PessoaAppService : IPessoaAppService
    {
        private readonly IPessoaMapper _pessoaMapper;
        public readonly IPessoaRepository _pessoaRepository;

        public PessoaAppService(IPessoaRepository pessoaRepository, IPessoaMapper pessoaMapper)
        {
            _pessoaMapper = pessoaMapper;
            _pessoaRepository = pessoaRepository;
        }

        public PessoaDTO Add(NovaPessoaDTO obj)
        {
            if (obj != null)
            {
                var pessoa = _pessoaMapper.MapperNewToEntity(obj);

                var novaPessoa = _pessoaRepository.Add(pessoa);

                return _pessoaMapper.MapperToDTO(novaPessoa);
            }
            else
                return null;
        }

        public virtual IEnumerable<PessoaDTO> GetAll()
        {
            var pessoa = _pessoaRepository.GetAll();

            if (pessoa == null)
                return null;
            else
                return _pessoaMapper.MapperListPessoas(pessoa);
        }

        public virtual PessoaDTO GetById(int id)
        {
            var pessoa = _pessoaRepository.GetById(id);
            return _pessoaMapper.MapperToDTO(pessoa);
        }
        public virtual void Update(PessoaDTO obj)
        {
            var pessoa = _pessoaMapper.MapperToEntity(obj);
            _pessoaRepository.Update(pessoa);
        }
        public virtual void Remove(PessoaDTO obj)
        {
            var pessoa = _pessoaMapper.MapperToEntity(obj);
            _pessoaRepository.Remove(pessoa);
        }

        public void Dispose()
        {
            _pessoaRepository.Dispose();
        }
    }
}
