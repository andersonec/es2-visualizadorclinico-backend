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
                id_endereco = enderecoDTO.id_endereco,
                bairro = enderecoDTO.bairro,
                cep = enderecoDTO.cep,
                cidade = enderecoDTO.cidade,
                complemento = enderecoDTO.complemento,
                logradouro = enderecoDTO.logradouro,
                numero = enderecoDTO.numero,
                tipo_logradouro =enderecoDTO.tipo_logradouro,
            };

            return endereco;
        }

        public IEnumerable<EnderecoDTO> MapperListEnderecos(IEnumerable<Endereco> enderecos)
        {
            foreach (var endereco in enderecos)
            {
                EnderecoDTO enderecoDTO = new EnderecoDTO
                {
                    id_endereco = endereco.id_endereco,
                    bairro = endereco.bairro,
                    cep = endereco.cep,
                    cidade = endereco.cidade,
                    complemento = endereco.complemento,
                    logradouro = endereco.logradouro,
                    numero = endereco.numero,
                    tipo_logradouro = endereco.tipo_logradouro,
                };

                enderecoDTOs.Add(enderecoDTO);
            }

            return enderecoDTOs;
        }

        public EnderecoDTO MapperToDTO(Endereco endereco)
        {
            EnderecoDTO enderecoDTO = new EnderecoDTO
            {
                id_endereco = endereco.id_endereco,
                bairro = endereco.bairro,
                cep = endereco.cep,
                cidade = endereco.cidade,
                complemento = endereco.complemento,
                logradouro = endereco.logradouro,
                numero = endereco.numero,
                tipo_logradouro = endereco.tipo_logradouro,
            };

            return enderecoDTO;
        }
    }
}
