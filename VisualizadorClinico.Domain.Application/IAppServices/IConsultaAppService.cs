using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IConsultaAppService
    {
        ConsultaDTO Add(ConsultaDTO obj, int id_profissional, int id_paciente);

        ConsultaDTO GetById(int id);

        IEnumerable<ConsultaDTO> GetAll();

        void Update(ConsultaDTO obj);

        void Remove(ConsultaDTO obj);

        void Dispose();
    }
}
