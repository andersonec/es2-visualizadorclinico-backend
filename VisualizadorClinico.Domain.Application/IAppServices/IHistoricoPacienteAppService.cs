using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IHistoricoPacienteAppService
    {
        void Add(HistoricoPacienteDTO obj);

        HistoricoPacienteDTO GetById(int id);

        IEnumerable<HistoricoPacienteDTO> GetAll();

        void Update(HistoricoPacienteDTO obj);

        void Remove(HistoricoPacienteDTO obj);

        void Dispose();
    }
}
