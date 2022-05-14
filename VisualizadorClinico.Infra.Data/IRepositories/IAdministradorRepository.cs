using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IAdministradorRepository
    {
        void Add(Administrador entity);

        Administrador GetById(int id);

        IEnumerable<Administrador> GetAll();

        void Update(Administrador obj);

        void Remove(Administrador obj);

        void Dispose();
    }
}
