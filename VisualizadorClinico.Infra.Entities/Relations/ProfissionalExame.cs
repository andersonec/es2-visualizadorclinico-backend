using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.Entities.Relations
{
    [Table("profissional_exame")]
    public class ProfissionalExame
    {
        [Key]
        public int id_exames { get; set; }
        public int id_profissional { get; set; }
        public int id_exame { get; set; }
    }
}
