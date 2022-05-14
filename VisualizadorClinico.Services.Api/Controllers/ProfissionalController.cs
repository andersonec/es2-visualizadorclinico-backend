using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisualizadorClinico.Domain.Application.IAppServices;
using VisualizadorClinico.Domain.DTO;

namespace VisualizadorClinico.Services.Api.Controllers
{
    [ApiController]
    [Route("v1.0/[controller]")]
    public class ProfissionalController : ControllerBase
    {
        // Consultar dados de paciente
        // Consultar lista de consultas e exames realizados por ele mesmo.
        // Criar agenda de exames e consultas.
        // Prescrever a Evolução do Paciente.
        // Solicitar Exames.
    }
}
