using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.Entities.Relations
{
    [Table("pessoa_endereco")]
    public class PessoaEndereco
    {
        [Key]
        public int id_pessoa_endereco { get; set; }

        [ForeignKey("fk_tb_pessoa")]
        public int id_pessoa { get; set; }

        [ForeignKey("fk_tb_endereco")]
        public int id_endereco { get; set; }
    }
}
