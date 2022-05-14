﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.Entities
{
    [Table("historico_profissional")]
    public class HistoricoProfissional
    {
        [Key]
        public int id_historico { get; set; }
        public int registro_profissional { get; set; }
        public string tipo_procedimento { get; set; }
        public DateTime data_hora { get; set; }
        public string codigo { get; set; }
        public int id_paciente { get; set; }
        public string diagnostico { get; set; }
    }
}
