using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IEnfermeiroRepository
    {
        void Add(Enfermeiro entity);

        Enfermeiro GetById(int id);

        IEnumerable<Enfermeiro> GetAll();

        void Update(Enfermeiro obj);

        void Remove(Enfermeiro obj);

        void Dispose();
    }
}
