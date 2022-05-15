using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IEnderecoRepository
    {
        Endereco Add(Endereco entity, int id_pessoa);

        Endereco GetById(int id);

        IEnumerable<Endereco> GetAll();

        void Update(Endereco obj);

        void Remove(Endereco obj);

        void Dispose();
    }
}
