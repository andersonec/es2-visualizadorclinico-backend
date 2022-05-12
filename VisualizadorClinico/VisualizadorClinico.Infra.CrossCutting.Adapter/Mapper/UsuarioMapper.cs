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
    public class UsuarioMapper : IUsuarioMapper
    {
        List<UsuarioDTO> userDTOs = new List<UsuarioDTO>();

        public Usuario MapperToEntity(UsuarioDTO userDTO)
        {
            Usuario user = new Usuario
            {
                id_usuario = userDTO.id_usuario,
                login = userDTO.login,
                //senha = userDTO.senha,
                tipo = userDTO.tipo,
                status = userDTO.status
            };

            return user;
        }

        public IEnumerable<UsuarioDTO> MapperListUsers(IEnumerable<Usuario> users)
        {
            foreach (var user in users)
            {
                UsuarioDTO userDTO = new UsuarioDTO
                {
                    id_usuario = user.id_usuario,
                    login = user.login,
                    //senha = user.senha,
                    tipo = user.tipo,
                    status = user.status
                };

                userDTOs.Add(userDTO);
            }

            return userDTOs;
        }

        public UsuarioDTO MapperToDTO(Usuario user)
        {
            UsuarioDTO userDTO = new UsuarioDTO
            {
                id_usuario = user.id_usuario,
                login = user.login,
                //senha = user.senha,
                tipo = user.tipo,
                status = user.status
            };

            return userDTO;
        }
    }
}
