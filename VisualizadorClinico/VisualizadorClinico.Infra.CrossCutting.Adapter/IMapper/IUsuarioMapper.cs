using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper
{
    public interface IUsuarioMapper
    {
        Usuario MapperToEntity(UsuarioDTO userDTO);
        IEnumerable<UsuarioDTO> MapperListUsers(IEnumerable<Usuario> users);
        UsuarioDTO MapperToDTO(Usuario user);
    }
}
