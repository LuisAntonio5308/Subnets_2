using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOL
{
    public class Red{

        public Red() {

        }

        public int id {  get; set; }
        public int primerOct { get; set; }
        public int segundoOct { get; set; }
        public int tercerOct { get; set; }
        public int cuartoOct { get; set; }
        public int idPack { get; set; }

        public string imprimir() {
            string red = primerOct+"."+segundoOct+"."+tercerOct+"."+cuartoOct;
            return red;
        }

    }
}
