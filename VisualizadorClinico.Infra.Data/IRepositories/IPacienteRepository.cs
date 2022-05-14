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
        void Add(Paciente entity);

        Paciente GetById(int id);

        IEnumerable<Paciente> GetAll();

        void Update(Paciente obj);

        void Remove(Paciente obj);

        void Dispose();
    }
}
