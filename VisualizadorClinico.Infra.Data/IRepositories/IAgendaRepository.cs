using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IAgendaRepository
    {
        Agenda Add(Agenda entity, int id_profissional);

        Agenda GetById(int id);

        IEnumerable<Agenda> GetAll(int id);

        void Update(Agenda obj);

        void Remove(Agenda obj);

        void Dispose();
    }
}
