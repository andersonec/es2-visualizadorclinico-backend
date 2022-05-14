using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper
{
    public interface IProcedimentoMapper
    {
        Procedimento MapperToEntity(ProcedimentoDTO procedimentoDTO);
        IEnumerable<ProcedimentoDTO> MapperListProcedimentos(IEnumerable<Procedimento> procedimentos);
        ProcedimentoDTO MapperToDTO(Procedimento procedimento);
    }
}
