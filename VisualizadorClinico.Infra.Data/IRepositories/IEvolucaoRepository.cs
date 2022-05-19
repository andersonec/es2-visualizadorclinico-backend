using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IEvolucaoRepository
    {
        EvolucaoPaciente Add(EvolucaoPaciente entity);

        EvolucaoPaciente GetById(int id);

        IEnumerable<EvolucaoPaciente> GetAll(int id);

        void Update(EvolucaoPaciente obj);

        void Remove(EvolucaoPaciente obj);

        void Dispose();
    }
}
