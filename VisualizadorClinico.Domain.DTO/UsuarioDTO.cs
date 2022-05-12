using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Domain.DTO
{
    public class UsuarioDTO
    {
        public int id_usuario { get; set; }
        public string login { get; set; }
        //public string senha { get; set; }
        public int tipo { get; set; }
        public bool status { get; set; }
    }

    public class UsuarioLoginDTO
    {
        public string login { get; set; }
        public string senha { get; set; }
    }
}
