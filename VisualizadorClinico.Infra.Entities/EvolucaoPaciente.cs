using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.Entities
{
    [Table("tb_evolucao")]
    public class EvolucaoPaciente
    {
        [Key]
        public int id_evolucao { get; set; }
        public DateTime data_hora { get; set; } = new DateTime();
        public int id_paciente { get; set; }
        public int id_profissional { get; set; }
        public string diagnostico { get; set; }
    }
}
