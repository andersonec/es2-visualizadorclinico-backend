using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Domain.DTO
{
    public class EnderecoDTO
    {
        public int id_endereco { get; set; }
        public string logradouro { get; set; }
        public string tipo_logradouro { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string complemento { get; set; }
        public string numero { get; set; }
    }
}
