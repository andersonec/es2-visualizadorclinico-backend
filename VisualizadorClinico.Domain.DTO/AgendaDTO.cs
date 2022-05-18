using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Domain.DTO
{
    public class AgendaDTO
    {
        public int id_agenda { get; set; }
        public string tipo_procedimento { get; set; }
        public DateTime data_hora { get; set; } = new DateTime();
        public string observacao { get; set; }
    }
}
