using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.Entities
{
    [Table("tb_profissional")]
    public class Profissional
    {
        [Key]
        public int id_profissional { get; set; }
        public string registro_profissional { get; set; }
        public string especialidade { get; set; }
    }
}
