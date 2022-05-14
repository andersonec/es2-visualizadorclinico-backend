using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper
{
    public interface IEnderecoMapper
    {
        Endereco MapperToEntity(EnderecoDTO enderecoDTO);
        IEnumerable<EnderecoDTO> MapperListEnderecos(IEnumerable<Endereco> enderecos);
        EnderecoDTO MapperToDTO(Endereco endereco);
    }
}
