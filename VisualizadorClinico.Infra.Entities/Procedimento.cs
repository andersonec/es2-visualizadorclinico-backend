using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.Entities
{
    [Table("tb_procedimento")]
    public class Procedimento
    {
        [Key]
        public int id_procedimento { get; set; }
        public string codigo { get; set; }
        public DateTime data_hora { get; set; } = new DateTime();
        public string diagnostico { get; set; }
    }
}
