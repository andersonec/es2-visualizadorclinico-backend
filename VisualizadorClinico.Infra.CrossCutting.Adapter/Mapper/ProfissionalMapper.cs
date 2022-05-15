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
    public class ProfissionalMapper : IProfissionalMapper
    {
        List<ProfissionalDTO> profissionalDTOs = new List<ProfissionalDTO>();

        public Profissional MapperToEntity(ProfissionalDTO profissionalDTO)
        {
            Profissional profissional = new Profissional
            {
                id_profissional = profissionalDTO.id_usuario,
                registro_profissional = profissionalDTO.registro_profissional,
                especialidade = profissionalDTO.especialidade,
            };

            return profissional;
        }

        public IEnumerable<ProfissionalDTO> MapperListProfissionais(IEnumerable<Profissional> profissionals)
        {
            foreach (var profissional in profissionals)
            {
                ProfissionalDTO profissionalDTO = new ProfissionalDTO
                {
                    id_usuario = profissional.id_profissional,
                    registro_profissional = profissional.registro_profissional,
                    especialidade = profissional.especialidade,
                };

                profissionalDTOs.Add(profissionalDTO);
            }

            return profissionalDTOs;
        }

        public ProfissionalDTO MapperToDTO(Profissional profissional)
        {
            ProfissionalDTO profissionalDTO = new ProfissionalDTO
            {
                id_usuario = profissional.id_profissional,
                registro_profissional = profissional.registro_profissional,
                especialidade = profissional.especialidade,
            };

            return profissionalDTO;
        }
    }
}
