using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.Mapper
{
    public class EnderecoMapper : IEnderecoMapper
    {
        List<EnderecoDTO> enderecoDTOs = new List<EnderecoDTO>();

        public Endereco MapperToEntity(EnderecoDTO enderecoDTO)
        {
            Endereco endereco = new Endereco
            {
            };

            return endereco;
        }

        public IEnumerable<EnderecoDTO> MapperListEnderecos(IEnumerable<Endereco> enderecos)
        {
            foreach (var endereco in enderecos)
            {
                EnderecoDTO enderecoDTO = new EnderecoDTO
                {
                };

                enderecoDTOs.Add(enderecoDTO);
            }

            return enderecoDTOs;
        }

        public EnderecoDTO MapperToDTO(Endereco endereco)
        {
            EnderecoDTO enderecoDTO = new EnderecoDTO
            {
            };

            return enderecoDTO;
        }
    }
}
