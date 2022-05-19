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
    public class EvolucaoMapper : IEvolucaoMapper
    {
        List<EvolucaoPacienteDTO> evolucaoPacienteDTOs = new List<EvolucaoPacienteDTO>();

        public EvolucaoPaciente MapperToEntity(EvolucaoPacienteDTO evolucaoPacienteDTO)
        {
            EvolucaoPaciente evolucaoPaciente = new EvolucaoPaciente
            {
                id_paciente = evolucaoPacienteDTO.id_paciente,
                id_profissional = evolucaoPacienteDTO.id_profissional,
                data_hora = evolucaoPacienteDTO.data_hora,
                diagnostico = evolucaoPacienteDTO.diagnostico,
            };

            return evolucaoPaciente;
        }

        public IEnumerable<EvolucaoPacienteDTO> MapperListEvolucoes(IEnumerable<EvolucaoPaciente> evolucaoPacientes)
        {
            foreach (var evolucaoPaciente in evolucaoPacientes)
            {
                EvolucaoPacienteDTO evolucaoPacienteDTO = new EvolucaoPacienteDTO
                {
                    id_evolucao = evolucaoPaciente.id_evolucao,
                    id_paciente = evolucaoPaciente.id_paciente,
                    id_profissional = evolucaoPaciente.id_profissional,
                    diagnostico = evolucaoPaciente.diagnostico,
                    data_hora = evolucaoPaciente.data_hora,
                };

                evolucaoPacienteDTOs.Add(evolucaoPacienteDTO);
            }

            return evolucaoPacienteDTOs;
        }

        public EvolucaoPacienteDTO MapperToDTO(EvolucaoPaciente evolucaoPacientes)
        {
            EvolucaoPacienteDTO evolucaoPacienteDTO = new EvolucaoPacienteDTO
            {
                id_evolucao = evolucaoPacientes.id_evolucao,
                id_paciente = evolucaoPacientes.id_paciente,
                id_profissional = evolucaoPacientes.id_profissional,
                diagnostico = evolucaoPacientes.diagnostico,
                data_hora = evolucaoPacientes.data_hora,
            };

            return evolucaoPacienteDTO;
        }
    }
}
