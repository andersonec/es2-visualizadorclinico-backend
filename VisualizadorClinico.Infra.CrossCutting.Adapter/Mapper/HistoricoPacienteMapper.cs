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
    public class HistoricoPacienteMapper : IHistoricoPacienteMapper
    {
        List<HistoricoPacienteDTO> historicoPacienteDTOs = new List<HistoricoPacienteDTO>();

        public HistoricoPaciente MapperToEntity(HistoricoPacienteDTO historicoPacienteDTO)
        {
            HistoricoPaciente historicoPaciente = new HistoricoPaciente
            {
            };

            return historicoPaciente;
        }

        public IEnumerable<HistoricoPacienteDTO> MapperListHistoricoPacientes(IEnumerable<HistoricoPaciente> historicoPacientes)
        {
            foreach (var historicoPaciente in historicoPacientes)
            {
                HistoricoPacienteDTO historicoPacienteDTO = new HistoricoPacienteDTO
                {
                };

                historicoPacienteDTOs.Add(historicoPacienteDTO);
            }

            return historicoPacienteDTOs;
        }

        public HistoricoPacienteDTO MapperToDTO(HistoricoPaciente historicoPaciente)
        {
            HistoricoPacienteDTO historicoPacienteDTO = new HistoricoPacienteDTO
            {
            };

            return historicoPacienteDTO;
        }
    }
}
