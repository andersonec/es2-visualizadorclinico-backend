using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.Entities
{
    [Table("tb_agenda")]
    public class Agenda
    {
        [Key]
        public int id_agenda { get; set; }
        public string tipo_procedimento { get; set; }
        public DateTime data_hora { get; set; } = new DateTime();
        public string observacao { get; set; }
    }
}
