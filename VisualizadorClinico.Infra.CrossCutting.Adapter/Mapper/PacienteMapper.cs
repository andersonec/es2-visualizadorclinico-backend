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
    public class PacienteMapper : IPacienteMapper
    {
        List<PacienteDTO> pacienteDTOs = new List<PacienteDTO>();

        public Paciente MapperToEntity(PacienteDTO pacienteDTO)
        {
            Paciente paciente = new Paciente
            {
                id_paciente = pacienteDTO.id_paciente,
                data_cadastro = pacienteDTO.data_cadastro,
                grupo = pacienteDTO.grupo,
                registro_sus = pacienteDTO.registro_sus,
                tipo_sanguineo = pacienteDTO.tipo_sanguineo,
            };

            return paciente;
        }

        public IEnumerable<PacienteDTO> MapperListPacientes(IEnumerable<Paciente> pacientes)
        {
            foreach (var paciente in pacientes)
            {
                PacienteDTO pacienteDTO = new PacienteDTO
                {
                    id_paciente = paciente.id_paciente,
                    data_cadastro = paciente.data_cadastro,
                    grupo = paciente.grupo,
                    registro_sus = paciente.registro_sus,
                    tipo_sanguineo = paciente.tipo_sanguineo,
                };

                pacienteDTOs.Add(pacienteDTO);
            }

            return pacienteDTOs;
        }

        public PacienteDTO MapperToDTO(Paciente paciente)
        {
            PacienteDTO pacienteDTO = new PacienteDTO
            {
                id_paciente = paciente.id_paciente,
                data_cadastro = paciente.data_cadastro,
                grupo = paciente.grupo,
                registro_sus = paciente.registro_sus,
                tipo_sanguineo = paciente.tipo_sanguineo,
            };

            return pacienteDTO;
        }
    }
}
