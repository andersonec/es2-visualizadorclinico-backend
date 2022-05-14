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
    public class EnfermeiroMapper : IEnfermeiroMapper
    {
        List<EnfermeiroDTO> enfermeiroDTOs = new List<EnfermeiroDTO>();

        public Enfermeiro MapperToEntity(EnfermeiroDTO enfermeiroDTO)
        {
            Enfermeiro enfermeiro = new Enfermeiro
            {
                id_usuario = enfermeiroDTO.id_usuario,
            };

            return enfermeiro;
        }

        public IEnumerable<EnfermeiroDTO> MapperListEnfermeiros(IEnumerable<Enfermeiro> enfermeiros)
        {
            foreach (var enfermeiro in enfermeiros)
            {
                EnfermeiroDTO enfermeiroDTO = new EnfermeiroDTO
                {
                    id_usuario = enfermeiro.id_usuario,
                };

                enfermeiroDTOs.Add(enfermeiroDTO);
            }

            return enfermeiroDTOs;
        }

        public EnfermeiroDTO MapperToDTO(Enfermeiro enfermeiro)
        {
            EnfermeiroDTO enfermeiroDTO = new EnfermeiroDTO
            {
                id_usuario = enfermeiro.id_usuario,
            };

            return enfermeiroDTO;
        }
    }
}
