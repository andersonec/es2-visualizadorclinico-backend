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
    public class PacienteAppService : IPacienteAppService
    {
        private readonly IPacienteMapper _pacienteMapper;
        public readonly IPacienteRepository _pacienteRepository;

        public PacienteAppService(IPacienteRepository pacienteRepository, IPacienteMapper pacienteMapper)
        {
            _pacienteMapper = pacienteMapper;
            _pacienteRepository = pacienteRepository;
        }

        public PacienteDTO Add(PacienteDTO obj)
        {
            if (obj != null)
            {
                var paciente = _pacienteMapper.MapperToEntity(obj);

                var novoPaciente = _pacienteRepository.Add(paciente);

                return _pacienteMapper.MapperToDTO(novoPaciente);
            }
            else
                return null;
        }

        public virtual IEnumerable<PacienteDTO> GetAll()
        {
            var paciente = _pacienteRepository.GetAll();

            if (paciente == null)
                return null;
            else
                return _pacienteMapper.MapperListPacientes(paciente);
        }

        public virtual PacienteDTO GetById(string id)
        {
            var paciente = _pacienteRepository.GetById(id);
            return _pacienteMapper.MapperToDTO(paciente);
        }
        public virtual void Update(PacienteDTO obj)
        {
            var paciente = _pacienteMapper.MapperToEntity(obj);
            _pacienteRepository.Update(paciente);
        }
        public virtual void Remove(PacienteDTO obj)
        {
            var paciente = _pacienteMapper.MapperToEntity(obj);
            _pacienteRepository.Remove(paciente);
        }

        public void Dispose()
        {
            _pacienteRepository.Dispose();
        }
    }
}
