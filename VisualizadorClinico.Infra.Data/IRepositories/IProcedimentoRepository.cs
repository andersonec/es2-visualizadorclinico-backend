using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IProcedimentoRepository
    {
        void Add(Procedimento entity);

        Procedimento GetById(int id);

        IEnumerable<Procedimento> GetAll();

        void Update(Procedimento obj);

        void Remove(Procedimento obj);

        void Dispose();
    }
}
