using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface ICirurgiaAppService
    {
        void Add(CirurgiaDTO obj);

        CirurgiaDTO GetById(int id);

        IEnumerable<CirurgiaDTO> GetAll();

        void Update(CirurgiaDTO obj);

        void Remove(CirurgiaDTO obj);

        void Dispose();
    }
}
