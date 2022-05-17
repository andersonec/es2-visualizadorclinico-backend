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
    public class ConsultaAppService : IConsultaAppService
    {
        private readonly IConsultaMapper _consultaMapper;
        public readonly IConsultaRepository _consultaRepository;

        public ConsultaAppService(IConsultaRepository consultaRepository, IConsultaMapper consultaMapper)
        {
            _consultaMapper = consultaMapper;
            _consultaRepository = consultaRepository;
        }

        public ConsultaDTO Add(ConsultaDTO obj, int id_profissional, int id_paciente)
        {
            if (obj != null)
            {
                var consulta = _consultaMapper.MapperToEntity(obj);

                var novaConsulta = _consultaRepository.Add(consulta, id_profissional, id_paciente);

                return _consultaMapper.MapperToDTO(novaConsulta);
            }
            else
                return null;
        }

        public virtual IEnumerable<ConsultaDTO> GetAll()
        {
            var consulta = _consultaRepository.GetAll();

            if (consulta == null)
                return null;
            else
                return _consultaMapper.MapperListConsultas(consulta);
        }

        public virtual ConsultaDTO GetById(int id)
        {
            var consulta = _consultaRepository.GetById(id);
            return _consultaMapper.MapperToDTO(consulta);
        }
        public virtual void Update(ConsultaDTO obj)
        {
            var consulta = _consultaMapper.MapperToEntity(obj);
            _consultaRepository.Update(consulta);
        }
        public virtual void Remove(ConsultaDTO obj)
        {
            var consulta = _consultaMapper.MapperToEntity(obj);
            _consultaRepository.Remove(consulta);
        }

        public void Dispose()
        {
            _consultaRepository.Dispose();
        }
    }
}
