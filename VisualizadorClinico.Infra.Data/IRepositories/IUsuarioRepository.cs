using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IUsuarioRepository
    {
        Usuario Add(Usuario entity);

        Usuario GetById(int id);

        IEnumerable<Usuario> GetAll();

        void Update(Usuario obj);

        void Remove(Usuario obj);

        void Dispose();
    }
}
