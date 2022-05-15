using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IUsuarioAppService
    {
        NovoUsuarioDTO Add(NovoUsuarioDTO obj);

        UsuarioDTO GetById(int id);

        IEnumerable<UsuarioDTO> GetAll();

        void Update(NovoUsuarioDTO obj);

        void Remove(NovoUsuarioDTO obj);

        void Dispose();
    }
}
