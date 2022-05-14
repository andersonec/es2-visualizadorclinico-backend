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
    public class HistoricoProfissionalMapper : IHistoricoProfissionalMapper
    {
        List<HistoricoProfissionalDTO> historicoProfissionalDTOs = new List<HistoricoProfissionalDTO>();

        public HistoricoProfissional MapperToEntity(HistoricoProfissionalDTO historicoProfissionalDTO)
        {
            HistoricoProfissional historicoProfissional = new HistoricoProfissional
            {
            };

            return historicoProfissional;
        }

        public IEnumerable<HistoricoProfissionalDTO> MapperListHistoricoProfissionais(IEnumerable<HistoricoProfissional> historicoProfissionals)
        {
            foreach (var historicoProfissional in historicoProfissionals)
            {
                HistoricoProfissionalDTO historicoProfissionalDTO = new HistoricoProfissionalDTO
                {
                };

                historicoProfissionalDTOs.Add(historicoProfissionalDTO);
            }

            return historicoProfissionalDTOs;
        }

        public HistoricoProfissionalDTO MapperToDTO(HistoricoProfissional historicoProfissional)
        {
            HistoricoProfissionalDTO historicoProfissionalDTO = new HistoricoProfissionalDTO
            {
            };

            return historicoProfissionalDTO;
        }
    }
}
