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
                id_pessoa = pessoaDTO.id_pessoa,
                data_nascimento = pessoaDTO.data_nascimento,
                nome = pessoaDTO.nome,
                cpf = pessoaDTO.cpf,
                sexo = pessoaDTO.sexo,
                registro_geral = pessoaDTO.registro_geral,
                naturalidade = pessoaDTO.naturalidade,
                ocupacao = pessoaDTO.ocupacao,
                telefone = pessoaDTO.telefone,
                email = pessoaDTO.email,
            };

            return pessoa;
        }
        public Pessoa MapperNewToEntity(NovaPessoaDTO pessoaDTO)
        {
            Pessoa pessoa = new Pessoa
            {
                data_nascimento = pessoaDTO.data_nascimento,
                nome = pessoaDTO.nome,
                cpf = pessoaDTO.cpf,
                sexo = pessoaDTO.sexo,
                registro_geral = pessoaDTO.registro_geral,
                naturalidade = pessoaDTO.naturalidade,
                ocupacao = pessoaDTO.ocupacao,
                telefone = pessoaDTO.telefone,
                email = pessoaDTO.email,
            };

            return pessoa;
        }

        public IEnumerable<PessoaDTO> MapperListPessoas(IEnumerable<Pessoa> pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                PessoaDTO pessoaDTO = new PessoaDTO
                {
                    id_pessoa = pessoa.id_pessoa,
                    data_nascimento = pessoa.data_nascimento,
                    nome = pessoa.nome,
                    cpf = pessoa.cpf,
                    sexo = pessoa.sexo,
                    registro_geral = pessoa.registro_geral,
                    naturalidade = pessoa.naturalidade,
                    ocupacao = pessoa.ocupacao,
                    telefone = pessoa.telefone,
                    email = pessoa.email,
                };

                pessoaDTOs.Add(pessoaDTO);
            }

            return pessoaDTOs;
        }

        public PessoaDTO MapperToDTO(Pessoa pessoa)
        {
            PessoaDTO pessoaDTO = new PessoaDTO
            {
                id_pessoa = pessoa.id_pessoa,
                data_nascimento = pessoa.data_nascimento,
                nome = pessoa.nome,
                cpf = pessoa.cpf,
                sexo = pessoa.sexo,
                registro_geral = pessoa.registro_geral,
                naturalidade = pessoa.naturalidade,
                ocupacao = pessoa.ocupacao,
                telefone = pessoa.telefone,
                email = pessoa.email,
            };

            return pessoaDTO;
        }

        public NovaPessoaDTO MapperToNewDTO(Pessoa pessoa)
        {
            NovaPessoaDTO pessoaDTO = new NovaPessoaDTO
            {
                data_nascimento = pessoa.data_nascimento,
                nome = pessoa.nome,
                cpf = pessoa.cpf,
                sexo = pessoa.sexo,
                registro_geral = pessoa.registro_geral,
                naturalidade = pessoa.naturalidade,
                ocupacao = pessoa.ocupacao,
                telefone = pessoa.telefone,
                email = pessoa.email,
            };

            return pessoaDTO;
        }
    }
}
