using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IConsultaRepository
    {
        Consulta Add(Consulta entity, int id_profissional, int id_paciente);

        Consulta GetById(int id);

        IEnumerable<Consulta> GetAll();

        void Update(Consulta obj);

        void Remove(Consulta obj);

        void Dispose();
    }
}
