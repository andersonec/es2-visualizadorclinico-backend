using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IHistoricoPacienteRepository
    {
        void Add(HistoricoPaciente entity);

        HistoricoPaciente GetById(int id);

        IEnumerable<HistoricoPaciente> GetAll();

        void Update(HistoricoPaciente obj);

        void Remove(HistoricoPaciente obj);

        void Dispose();
    }
}
