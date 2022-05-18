using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.Mapper
{
    public class AgendaMapper : IAgendaMapper
    {
        List<AgendaDTO> agendaDTOs = new List<AgendaDTO>();

        public Agenda MapperToEntity(AgendaDTO agendaDTO)
        {
            Agenda agenda = new Agenda
            {
                id_agenda = agendaDTO.id_agenda,
                data_hora = agendaDTO.data_hora,
                tipo_procedimento = agendaDTO.tipo_procedimento,
                observacao = agendaDTO.observacao,
            };

            return agenda;
        }

        public IEnumerable<AgendaDTO> MapperListAgendas(IEnumerable<Agenda> agendas)
        {
            foreach (var agenda in agendas)
            {
                AgendaDTO agendaDTO = new AgendaDTO
                {
                    id_agenda = agenda.id_agenda,
                    data_hora = agenda.data_hora,
                    tipo_procedimento = agenda.tipo_procedimento,
                    observacao = agenda.observacao,
                };

                agendaDTOs.Add(agendaDTO);
            }

            return agendaDTOs;
        }

        public AgendaDTO MapperToDTO(Agenda agenda)
        {
            AgendaDTO agendaDTO = new AgendaDTO
            {
                id_agenda = agenda.id_agenda,
                data_hora = agenda.data_hora,
                tipo_procedimento = agenda.tipo_procedimento,
                observacao = agenda.observacao,
            };

            return agendaDTO;
        }
    }
}
