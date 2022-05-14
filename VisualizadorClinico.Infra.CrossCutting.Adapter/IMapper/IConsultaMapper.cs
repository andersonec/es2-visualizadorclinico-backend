﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.CrossCutting.Adapter.IMapper
{
    public interface IConsultaMapper
    {
        Consulta MapperToEntity(ConsultaDTO consultaDTO);
        IEnumerable<ConsultaDTO> MapperListConsultas(IEnumerable<Consulta> consultas);
        ConsultaDTO MapperToDTO(Consulta consulta);
    }
}