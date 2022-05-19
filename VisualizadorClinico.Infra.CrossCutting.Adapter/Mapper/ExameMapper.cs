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
    public class ExameMapper : IExameMapper
    {
        List<ExameDTO> exameDTOs = new List<ExameDTO>();

        public Exame MapperToEntity(ExameDTO exameDTO)
        {
            Exame exame = new Exame
            {
                codigo = exameDTO.codigo,
                data_hora = exameDTO.data_hora,
                diagnostico = exameDTO.diagnostico,
            };

            return exame;
        }

        public IEnumerable<ExameDTO> MapperListExames(IEnumerable<Exame> exames)
        {
            foreach (var exame in exames)
            {
                ExameDTO exameDTO = new ExameDTO
                {
                    diagnostico = exame.diagnostico,
                    data_hora = exame.data_hora,
                    codigo = exame.codigo,
                    id_exame = exame.id_exame,
                };

                exameDTOs.Add(exameDTO);
            }

            return exameDTOs;
        }

        public ExameDTO MapperToDTO(Exame exame)
        {
            ExameDTO exameDTO = new ExameDTO
            {
                diagnostico = exame.diagnostico,
                data_hora = exame.data_hora,
                codigo = exame.codigo,
                id_exame = exame.id_exame,
            };

            return exameDTO;
        }
    }
}
