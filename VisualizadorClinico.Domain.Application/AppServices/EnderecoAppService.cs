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
    public class EnderecoAppService : IEnderecoAppService
    {
        private readonly IEnderecoMapper _enderecoMapper;
        public readonly IEnderecoRepository _enderecoRepository;

        public EnderecoAppService(IEnderecoRepository enderecoRepository, IEnderecoMapper enderecoMapper)
        {
            _enderecoMapper = enderecoMapper;
            _enderecoRepository = enderecoRepository;
        }

        public void Add(EnderecoDTO obj)
        {
            if (obj != null)
            {
                var endereco = _enderecoMapper.MapperToEntity(obj);

                _enderecoRepository.Add(endereco);
            }
            else
                return;
        }

        public virtual IEnumerable<EnderecoDTO> GetAll()
        {
            var endereco = _enderecoRepository.GetAll();

            if (endereco == null)
                return null;
            else
                return _enderecoMapper.MapperListEnderecos(endereco);
        }

        public virtual EnderecoDTO GetById(int id)
        {
            var endereco = _enderecoRepository.GetById(id);
            return _enderecoMapper.MapperToDTO(endereco);
        }
        public virtual void Update(EnderecoDTO obj)
        {
            var endereco = _enderecoMapper.MapperToEntity(obj);
            _enderecoRepository.Update(endereco);
        }
        public virtual void Remove(EnderecoDTO obj)
        {
            var endereco = _enderecoMapper.MapperToEntity(obj);
            _enderecoRepository.Remove(endereco);
        }

        public void Dispose()
        {
            _enderecoRepository.Dispose();
        }
    }
}
