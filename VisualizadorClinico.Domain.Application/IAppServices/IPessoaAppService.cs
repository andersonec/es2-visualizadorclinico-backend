using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IPessoaAppService
    {
        void Add(PessoaDTO obj);

        PessoaDTO GetById(int id);

        IEnumerable<PessoaDTO> GetAll();

        void Update(PessoaDTO obj);

        void Remove(PessoaDTO obj);

        void Dispose();
    }
}
