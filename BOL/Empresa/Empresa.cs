using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Empresa{

        public Empresa() { 
        
        }

        public int idEmpresa { get; set; }
        public string nombreEmpresa { get; set; }
        public string direccionEmpresa { get; set; }
        public string telefono { get; set; }
        public string correoElectronico { get; set; }

    }
}
