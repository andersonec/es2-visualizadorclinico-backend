using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper
{
    public interface IEvolucaoMapper
    {
        EvolucaoPaciente MapperToEntity(EvolucaoPacienteDTO evolucaoPacienteDTO);
        IEnumerable<EvolucaoPacienteDTO> MapperListEvolucoes(IEnumerable<EvolucaoPaciente> evolucaoPacientes);
        EvolucaoPacienteDTO MapperToDTO(EvolucaoPaciente evolucaoPaciente);
    }
}
