using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.Entities.Relations
{
    [Table("agenda_profissional")]
    public class ProfissionalAgenda
    {
        [Key]
        public int id_evento { get; set; }
        public int id_agenda { get; set; }
        public int id_profissional { get; set; }
    }
}
