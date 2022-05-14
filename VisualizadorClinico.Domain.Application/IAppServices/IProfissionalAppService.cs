﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.DTO;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Domain.Application.IAppServices
{
    public interface IProfissionalAppService
    {
        void Add(ProfissionalDTO obj);

        ProfissionalDTO GetById(int id);

        IEnumerable<ProfissionalDTO> GetAll();

        void Update(ProfissionalDTO obj);

        void Remove(ProfissionalDTO obj);

        void Dispose();
    }
}