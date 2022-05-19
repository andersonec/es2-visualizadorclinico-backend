using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Domain.DTO
{
    public class EvolucaoPacienteDTO
    {
        public int id_evolucao { get; set; }
        public DateTime data_hora { get; set; } = new DateTime();
        public int id_paciente { get; set; }
        public int id_profissional { get; set; }
        public string diagnostico { get; set; }
    }
    public class EvolucaoPacienteAdd
    {
        public DateTime data_hora { get; set; } = new DateTime();
        public string registro_paciente { get; set; }
        public string registro_profissional { get; set; }
        public string diagnostico { get; set; }
    }
}
