using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IEnderecoAppService
    {
        void Add(EnderecoDTO obj);

        EnderecoDTO GetById(int id);

        IEnumerable<EnderecoDTO> GetAll();

        void Update(EnderecoDTO obj);

        void Remove(EnderecoDTO obj);

        void Dispose();
    }
}
