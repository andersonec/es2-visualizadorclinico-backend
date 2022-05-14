using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IExameRepository
    {
        void Add(Exame entity);

        Exame GetById(int id);

        IEnumerable<Exame> GetAll();

        void Update(Exame obj);

        void Remove(Exame obj);

        void Dispose();
    }
}
