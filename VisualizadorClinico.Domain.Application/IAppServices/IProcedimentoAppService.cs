using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IProcedimentoAppService
    {
        void Add(ProcedimentoDTO obj);

        ProcedimentoDTO GetById(int id);

        IEnumerable<ProcedimentoDTO> GetAll();

        void Update(ProcedimentoDTO obj);

        void Remove(ProcedimentoDTO obj);

        void Dispose();
    }
}
