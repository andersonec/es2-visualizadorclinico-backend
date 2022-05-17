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
                diagnostico = historicoPacienteDTO.diagnostico,
                data_hora = historicoPacienteDTO.data_hora,
                tipo_procedimento = historicoPacienteDTO.tipo_procedimento,
                codigo = historicoPacienteDTO.codigo,
                id_paciente = historicoPacienteDTO.id_paciente,
                id_profissional = historicoPacienteDTO.id_profissional,
            };

            return historicoPaciente;
        }

        public IEnumerable<HistoricoPacienteDTO> MapperListHistoricoPacientes(IEnumerable<HistoricoPaciente> historicoPacientes)
        {
            foreach (var historicoPaciente in historicoPacientes)
            {
                HistoricoPacienteDTO historicoPacienteDTO = new HistoricoPacienteDTO
                {
                    id_historico = historicoPaciente.id_historico,
                    diagnostico = historicoPaciente.diagnostico,
                    data_hora = historicoPaciente.data_hora,
                    tipo_procedimento = historicoPaciente.tipo_procedimento,
                    codigo = historicoPaciente.codigo,
                    id_paciente = historicoPaciente.id_paciente,
                    id_profissional = historicoPaciente.id_profissional,
                };

                historicoPacienteDTOs.Add(historicoPacienteDTO);
            }

            return historicoPacienteDTOs;
        }

        public HistoricoPacienteDTO MapperToDTO(HistoricoPaciente historicoPaciente)
        {
            HistoricoPacienteDTO historicoPacienteDTO = new HistoricoPacienteDTO
            {
                id_historico = historicoPaciente.id_historico,
                diagnostico = historicoPaciente.diagnostico,
                data_hora = historicoPaciente.data_hora,
                tipo_procedimento = historicoPaciente.tipo_procedimento,
                codigo = historicoPaciente.codigo,
                id_paciente = historicoPaciente.id_paciente,
                id_profissional = historicoPaciente.id_profissional,
            };

            return historicoPacienteDTO;
        }
    }
}
