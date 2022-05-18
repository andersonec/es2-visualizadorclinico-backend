using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IAgendaAppService
    {
        AgendaDTO Add(AgendaDTO obj, string registro_profissional);

        AgendaDTO GetById(int id);

        IEnumerable<AgendaDTO> GetAll(string id);

        void Update(AgendaDTO obj);

        void Remove(AgendaDTO obj);

        void Dispose();
    }
}
