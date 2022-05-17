using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IHistoricoProfissionalAppService
    {
        void Add(HistoricoProfissionalDTO obj);

        HistoricoProfissionalDTO GetById(int id);

        IEnumerable<HistoricoProfissionalDTO> GetAll(int id_profissional);

        void Update(HistoricoProfissionalDTO obj);

        void Remove(HistoricoProfissionalDTO obj);

        void Dispose();
    }
}
