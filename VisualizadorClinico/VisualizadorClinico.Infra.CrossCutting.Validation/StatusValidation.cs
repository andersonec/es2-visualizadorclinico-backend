using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.CrossCutting.Validation
{
    public class StatusValidation
    {
        public bool isValid { get; set; }
        public string statusMessage { get; set; }
    }
}
