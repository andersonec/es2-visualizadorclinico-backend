using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IPacienteRepository
    {
        Paciente Add(Paciente entity);

        Paciente GetById(string id);

        IEnumerable<Paciente> GetAll();

        void Update(Paciente obj);

        void Remove(Paciente obj);

        void Dispose();
    }
}
