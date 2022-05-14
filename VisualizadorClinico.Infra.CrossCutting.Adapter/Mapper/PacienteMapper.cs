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
            };

            return paciente;
        }

        public IEnumerable<PacienteDTO> MapperListPacientes(IEnumerable<Paciente> pacientes)
        {
            foreach (var paciente in pacientes)
            {
                PacienteDTO pacienteDTO = new PacienteDTO
                {
                };

                pacienteDTOs.Add(pacienteDTO);
            }

            return pacienteDTOs;
        }

        public PacienteDTO MapperToDTO(Paciente paciente)
        {
            PacienteDTO pacienteDTO = new PacienteDTO
            {
            };

            return pacienteDTO;
        }
    }
}
