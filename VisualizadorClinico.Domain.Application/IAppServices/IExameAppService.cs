﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IExameAppService
    {
        ExameDTO Add(ExameDTO obj);

        ExameDTO AddRealized(ExameDTO obj, int id_profissional, int id_paciente);

        ExameDTO GetById(int id);

        IEnumerable<ExameDTO> GetAll();

        void Update(ExameDTO obj);

        void Remove(ExameDTO obj);

        void Dispose();
    }
}
