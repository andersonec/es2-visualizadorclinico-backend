using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IPessoaRepository
    {
        void Add(Pessoa entity);

        Pessoa GetById(int id);

        IEnumerable<Pessoa> GetAll();

        void Update(Pessoa obj);

        void Remove(Pessoa obj);

        void Dispose();
    }
}
