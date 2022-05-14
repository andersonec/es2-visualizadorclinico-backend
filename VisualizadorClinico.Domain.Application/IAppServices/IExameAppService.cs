using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IExameAppService
    {
        void Add(ExameDTO obj);

        ExameDTO GetById(int id);

        IEnumerable<ExameDTO> GetAll();

        void Update(ExameDTO obj);

        void Remove(ExameDTO obj);

        void Dispose();
    }
}
