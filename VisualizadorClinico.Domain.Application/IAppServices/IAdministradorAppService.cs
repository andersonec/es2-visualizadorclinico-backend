using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IAdministradorAppService
    {
        void Add(AdministradorDTO obj);

        AdministradorDTO GetById(int id);

        IEnumerable<AdministradorDTO> GetAll();

        void Update(AdministradorDTO obj);

        void Remove(AdministradorDTO obj);

        void Dispose();
    }
}
