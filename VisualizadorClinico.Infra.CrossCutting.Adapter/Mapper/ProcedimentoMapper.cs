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
    public class ProcedimentoMapper : IProcedimentoMapper
    {
        List<ProcedimentoDTO> procedimentoDTOs = new List<ProcedimentoDTO>();

        public Procedimento MapperToEntity(ProcedimentoDTO procedimentoDTO)
        {
            Procedimento procedimento = new Procedimento
            {
            };

            return procedimento;
        }

        public IEnumerable<ProcedimentoDTO> MapperListProcedimentos(IEnumerable<Procedimento> procedimentos)
        {
            foreach (var procedimento in procedimentos)
            {
                ProcedimentoDTO procedimentoDTO = new ProcedimentoDTO
                {
                };

                procedimentoDTOs.Add(procedimentoDTO);
            }

            return procedimentoDTOs;
        }

        public ProcedimentoDTO MapperToDTO(Procedimento procedimento)
        {
            ProcedimentoDTO procedimentoDTO = new ProcedimentoDTO
            {
            };

            return procedimentoDTO;
        }
    }
}
