using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.Entities
{
    [Table("tb_paciente")]
    public class Paciente
    {
        [Key]
        public int id_paciente { get; set; }
        public string registro_sus { get; set; }
        public string tipo_sanguineo { get; set; }
        public int grupo { get; set; }
        public DateTime data_cadastro { get; set; } = new DateTime();
    }
}
