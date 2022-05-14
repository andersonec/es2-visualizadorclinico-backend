using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IHistoricoProfissionalRepository
    {
        void Add(HistoricoProfissional entity);

        HistoricoProfissional GetById(int id);

        IEnumerable<HistoricoProfissional> GetAll();

        void Update(HistoricoProfissional obj);

        void Remove(HistoricoProfissional obj);

        void Dispose();
    }
}
