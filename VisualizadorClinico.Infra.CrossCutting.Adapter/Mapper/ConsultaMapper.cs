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
    public class ConsultaMapper : IConsultaMapper
    {
        List<ConsultaDTO> consultaDTOs = new List<ConsultaDTO>();

        public Consulta MapperToEntity(ConsultaDTO consultaDTO)
        {
            Consulta consulta = new Consulta
            {
                codigo = consultaDTO.codigo,
                data_hora = consultaDTO.data_hora,
                diagnostico = consultaDTO.diagnostico,
            };

            return consulta;
        }

        public IEnumerable<ConsultaDTO> MapperListConsultas(IEnumerable<Consulta> consultas)
        {
            foreach (var consulta in consultas)
            {
                ConsultaDTO consultaDTO = new ConsultaDTO
                {
                    id_consulta = consulta.id_consulta,
                    codigo = consulta.codigo,
                    data_hora = consulta.data_hora,
                    diagnostico = consulta.diagnostico,
                };

                consultaDTOs.Add(consultaDTO);
            }

            return consultaDTOs;
        }

        public ConsultaDTO MapperToDTO(Consulta consulta)
        {
            ConsultaDTO consultaDTO = new ConsultaDTO
            {
                id_consulta = consulta.id_consulta,
                codigo = consulta.codigo,
                data_hora = consulta.data_hora,
                diagnostico = consulta.diagnostico,
            };

            return consultaDTO;
        }
    }
}
