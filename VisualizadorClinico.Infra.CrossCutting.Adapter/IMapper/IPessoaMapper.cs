using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper
{
    public interface IPessoaMapper
    {
        Pessoa MapperToEntity(PessoaDTO pessoaDTO);
        Pessoa MapperNewToEntity(NovaPessoaDTO pessoaDTO);
        IEnumerable<PessoaDTO> MapperListPessoas(IEnumerable<Pessoa> pessoas);
        PessoaDTO MapperToDTO(Pessoa pessoa);
        NovaPessoaDTO MapperToNewDTO(Pessoa pessoa);
    }
}
