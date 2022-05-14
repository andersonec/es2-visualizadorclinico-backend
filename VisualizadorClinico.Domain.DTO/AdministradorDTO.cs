using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Domain.DTO
{
    public class AdministradorDTO
    {
        public int id_usuario { get; set; }
        public string setor { get; set; }
        public string tipo { get; set; }
    }
}
