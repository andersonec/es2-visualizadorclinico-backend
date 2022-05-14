using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper
{
    public interface IHistoricoPacienteMapper
    {
        HistoricoPaciente MapperToEntity(HistoricoPacienteDTO historicoPacienteDTO);
        IEnumerable<HistoricoPacienteDTO> MapperListHistoricoPacientes(IEnumerable<HistoricoPaciente> historicoPacientes);
        HistoricoPacienteDTO MapperToDTO(HistoricoPaciente historicoPaciente);
    }
}
