﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IEvolucaoAppService
    {
        EvolucaoPacienteDTO Add(EvolucaoPacienteDTO obj);

        EvolucaoPacienteDTO GetById(int id);

        IEnumerable<EvolucaoPacienteDTO> GetAll(int id);

        void Update(EvolucaoPacienteDTO obj);

        void Remove(EvolucaoPacienteDTO obj);

        void Dispose();
    }
}
