using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace BOL
{
    public class Usuario{

        public Usuario() {

        }

        public int idUsuario { get; set; }
        public string nickname { get; set; }    
        public string contrasena { get; set; }
        public bool administrador { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public string direccionUsuario { get; set; }
        public string correoElectronico { get; set; }
        public string telefono { get; set; }

    }
}
