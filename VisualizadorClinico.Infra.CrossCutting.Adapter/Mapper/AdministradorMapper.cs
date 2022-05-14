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
    public class AdministradorMapper : IAdministradorMapper
    {
        List<AdministradorDTO> adminDTOs = new List<AdministradorDTO>();

        public Administrador MapperToEntity(AdministradorDTO adminDTO)
        {
            Administrador admin = new Administrador
            {
                id_usuario = adminDTO.id_usuario,
                tipo = adminDTO.tipo,
            };

            return admin;
        }

        public IEnumerable<AdministradorDTO> MapperListAdministradores(IEnumerable<Administrador> admins)
        {
            foreach (var admin in admins)
            {
                AdministradorDTO adminDTO = new AdministradorDTO
                {
                    id_usuario = admin.id_usuario,
                };

                adminDTOs.Add(adminDTO);
            }

            return adminDTOs;
        }

        public AdministradorDTO MapperToDTO(Administrador admin)
        {
            AdministradorDTO adminDTO = new AdministradorDTO
            {
                id_usuario = admin.id_usuario,
                tipo = admin.tipo,
            };

            return adminDTO;
        }
    }
}
