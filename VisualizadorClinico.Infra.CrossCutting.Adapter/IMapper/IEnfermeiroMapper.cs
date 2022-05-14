using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper
{
    public interface IEnfermeiroMapper
    {
        Enfermeiro MapperToEntity(EnfermeiroDTO enfermeiroDTO);
        IEnumerable<EnfermeiroDTO> MapperListEnfermeiros(IEnumerable<Enfermeiro> enfermeiros);
        EnfermeiroDTO MapperToDTO(Enfermeiro enfermeiro);
    }
}
