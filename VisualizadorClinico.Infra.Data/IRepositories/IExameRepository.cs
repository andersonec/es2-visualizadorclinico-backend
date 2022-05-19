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
        Exame Add(Exame entity);

        Exame AddRealized(Exame obj, int id_profissional, int id_paciente);

        Exame GetById(int id);

        IEnumerable<Exame> GetAll();

        void Update(Exame obj);

        void Remove(Exame obj);

        void Dispose();
    }
}
