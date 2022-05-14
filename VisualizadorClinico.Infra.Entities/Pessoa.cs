using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.Entities
{
    [Table("tb_pessoa")]
    public class Pessoa
    {
        [Key]
        public int id_pessoa { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public string registro_geral { get; set; }
        public string naturalidade { get; set; }
        public DateTime data_nascimento { get; set; } = new DateTime();
        public string ocupacao { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}
