using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Domain.DTO
{
    public class ProfissionalDTO
    {
        public int id_usuario { get; set; }
        public string registro_profissional { get; set; }
        public string especialidade { get; set; }
    }
}
