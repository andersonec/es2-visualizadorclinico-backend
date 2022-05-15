using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IProfissionalRepository
    {
        Profissional Add(Profissional entity);

        Profissional GetById(int id);

        IEnumerable<Profissional> GetAll();

        void Update(Profissional obj);

        void Remove(Profissional obj);

        void Dispose();
    }
}
