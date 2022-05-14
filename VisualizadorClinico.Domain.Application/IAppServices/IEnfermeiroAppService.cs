using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IEnfermeiroAppService
    {
        void Add(EnfermeiroDTO obj);

        EnfermeiroDTO GetById(int id);

        IEnumerable<EnfermeiroDTO> GetAll();

        void Update(EnfermeiroDTO obj);

        void Remove(EnfermeiroDTO obj);

        void Dispose();
    }
}
