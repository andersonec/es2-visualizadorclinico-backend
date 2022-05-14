using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper
{
    public interface IHistoricoProfissionalMapper
    {
        HistoricoProfissional MapperToEntity(HistoricoProfissionalDTO historicoProfissionalDTO);
        IEnumerable<HistoricoProfissionalDTO> MapperListHistoricoProfissionais(IEnumerable<HistoricoProfissional> historicoProfissionais);
        HistoricoProfissionalDTO MapperToDTO(HistoricoProfissional historicoProfissional);
    }
}
