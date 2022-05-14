using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper
{
    public interface IAdministradorMapper
    {
        Administrador MapperToEntity(AdministradorDTO administradorDTO);
        IEnumerable<AdministradorDTO> MapperListAdministradores(IEnumerable<Administrador> administradores);
        AdministradorDTO MapperToDTO(Administrador administrador);
    }
}
