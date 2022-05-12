using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorClinico.Infra.Entities
{
    public class Token
    {
        public string Access { get; set; }
        public int Expires_in { get; set; }
        public string Type { get; set; }
    }
}
