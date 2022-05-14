using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper
{
    public interface IPacienteMapper
    {
        Paciente MapperToEntity(PacienteDTO pacienteDTO);
        IEnumerable<PacienteDTO> MapperListPacientes(IEnumerable<Paciente> pacientes);
        PacienteDTO MapperToDTO(Paciente paciente);
    }
}
