using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IPacienteAppService
    {
        void Add(PacienteDTO obj);

        PacienteDTO GetById(int id);

        IEnumerable<PacienteDTO> GetAll();

        void Update(PacienteDTO obj);

        void Remove(PacienteDTO obj);

        void Dispose();
    }
}
