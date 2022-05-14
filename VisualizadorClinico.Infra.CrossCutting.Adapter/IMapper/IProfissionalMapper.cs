using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper
{
    public interface IProfissionalMapper
    {
        Profissional MapperToEntity(ProfissionalDTO profissionalDTO);
        IEnumerable<ProfissionalDTO> MapperListProfissionais(IEnumerable<Profissional> profissionais);
        ProfissionalDTO MapperToDTO(Profissional profissional);
    }
}
