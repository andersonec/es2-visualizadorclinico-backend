using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface ICirurgiaRepository
    {
        void Add(Cirurgia entity);

        Cirurgia GetById(int id);

        IEnumerable<Cirurgia> GetAll();

        void Update(Cirurgia obj);

        void Remove(Cirurgia obj);

        void Dispose();
    }
}
