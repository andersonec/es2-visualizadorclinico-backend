﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper
{
    public interface IAgendaMapper
    {
        Agenda MapperToEntity(AgendaDTO agendaDTO);
        IEnumerable<AgendaDTO> MapperListAgendas(IEnumerable<Agenda> agendas);
        AgendaDTO MapperToDTO(Agenda agenda);
    }
}
