using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace Subnets.AlgoritmoVLSM {
    public class RedObj {

        public Red red { get; set; }
        public Mascara mascara { get; set; }
        public IPInicial ipinicial { get; set; }
        public IPFinal ipfinal {  get; set; }
        public IPBroadcast ipbroadcast { get; set; }

        public RedObj() { }
    }
}
