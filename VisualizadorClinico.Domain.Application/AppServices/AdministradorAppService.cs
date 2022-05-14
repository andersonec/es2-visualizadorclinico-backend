using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.Application.IAppServices;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper;
using VisualizadorClinico.Infra.Data.IRepositories;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.AppServices
{
    public class AdministradorAppService : IAdministradorAppService
    {
        private readonly IAdministradorMapper _adminMapper;
        public readonly IAdministradorRepository _adminRepository;

        public AdministradorAppService(IAdministradorRepository adminRepository, IAdministradorMapper adminMapper)
        {
            _adminMapper = adminMapper;
            _adminRepository = adminRepository;
        }

        public void Add(AdministradorDTO obj)
        {
            if (obj != null)
            {
                var admin = _adminMapper.MapperToEntity(obj);

                _adminRepository.Add(admin);
            }
            else
                return;
        }

        public virtual IEnumerable<AdministradorDTO> GetAll()
        {
            var admin = _adminRepository.GetAll();

            if (admin == null)
                return null;
            else
                return _adminMapper.MapperListAdministradores(admin);
        }

        public virtual AdministradorDTO GetById(int id)
        {
            var admin = _adminRepository.GetById(id);
            return _adminMapper.MapperToDTO(admin);
        }
        public virtual void Update(AdministradorDTO obj)
        {
            var admin = _adminMapper.MapperToEntity(obj);
            _adminRepository.Update(admin);
        }
        public virtual void Remove(AdministradorDTO obj)
        {
            var admin = _adminMapper.MapperToEntity(obj);
            _adminRepository.Remove(admin);
        }

        public void Dispose()
        {
            _adminRepository.Dispose();
        }
    }
}
