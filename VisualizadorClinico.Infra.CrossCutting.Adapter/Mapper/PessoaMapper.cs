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
    public class PessoaMapper : IPessoaMapper
    {
        List<PessoaDTO> pessoaDTOs = new List<PessoaDTO>();

        public Pessoa MapperToEntity(PessoaDTO pessoaDTO)
        {
            Pessoa pessoa = new Pessoa
            {
            };

            return pessoa;
        }

        public IEnumerable<PessoaDTO> MapperListPessoas(IEnumerable<Pessoa> pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                PessoaDTO pessoaDTO = new PessoaDTO
                {
                };

                pessoaDTOs.Add(pessoaDTO);
            }

            return pessoaDTOs;
        }

        public PessoaDTO MapperToDTO(Pessoa pessoa)
        {
            PessoaDTO pessoaDTO = new PessoaDTO
            {
            };

            return pessoaDTO;
        }
    }
}
