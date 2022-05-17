using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.Entities.Relations
{
    [Table("profissional_consulta")]
    public class ProfissionalConsulta
    {
        [Key]
        public int id_consultas { get; set; }
        public int id_profissional { get; set; }
        public int id_consulta { get; set; }
    }
}
