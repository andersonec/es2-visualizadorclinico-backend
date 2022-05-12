using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisualizadorClinico.Infra.Entities
{
    [Table("tb_usuario")]
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int tipo { get; set; }
        public bool status { get; set; }
    }
}
