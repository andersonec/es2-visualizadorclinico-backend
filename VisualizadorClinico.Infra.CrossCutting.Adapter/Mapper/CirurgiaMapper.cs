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
    public class CirurgiaMapper : ICirurgiaMapper
    {
        List<CirurgiaDTO> cirurgiaDTOs = new List<CirurgiaDTO>();

        public Cirurgia MapperToEntity(CirurgiaDTO cirurgiaDTO)
        {
            Cirurgia cirurgia = new Cirurgia
            {
            };

            return cirurgia;
        }

        public IEnumerable<CirurgiaDTO> MapperListCirurgias(IEnumerable<Cirurgia> cirurgias)
        {
            foreach (var cirurgia in cirurgias)
            {
                CirurgiaDTO cirurgiaDTO = new CirurgiaDTO
                {
                };

                cirurgiaDTOs.Add(cirurgiaDTO);
            }

            return cirurgiaDTOs;
        }

        public CirurgiaDTO MapperToDTO(Cirurgia cirurgia)
        {
            CirurgiaDTO cirurgiaDTO = new CirurgiaDTO
            {
            };

            return cirurgiaDTO;
        }
    }
}
