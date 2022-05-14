using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Domain.DTO
{
    public class EnfermeiroDTO
    {
        public int id_usuario { get; set; }
        public int registro_profissional { get; set; }
        public string ala { get; set; }
    }
}
