using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace Subnets.AlgoritmoVLSM {
    public class VLSM {

        int iteraciones = 0;
        int[] hosts;
        Red ipOriginal = new Red();

        int[] hostsEncontrados;
        List<Red> listaRedes = new List<Red>();
        List<Mascara> listaMascaras = new List<Mascara>();
        List<IPInicial> listaIPIniciales = new List<IPInicial>();
        List<IPFinal> listaIPFinales = new List<IPFinal>();
        List<IPBroadcast> listaIPBroadcast = new List<IPBroadcast>();

        public VLSM() {

        }

        public int[] GetHostEncontrados() {
            return hostsEncontrados;
        }

        public List<Red> GetListaRedes() {
            return listaRedes;
        }

        public List<Mascara> GetMascaras() {
            return listaMascaras;
        }

        public List<IPInicial> GetIPIniciales() {
            return listaIPIniciales;
        }

        public List<IPFinal> GetIPFinales() {
            return listaIPFinales;
        }

        public List<IPBroadcast> GetIPBroadcasts() {
            return listaIPBroadcast;
        }


        //Metodo para leer los datos necesarios para el algoritmo
        public void leerDatos(int iteraciones, int[] hosts, Red ipOriginal) {
            this.iteraciones = iteraciones;
            this.hosts = hosts;
            this.ipOriginal = ipOriginal;
        }

        //Calcular hostEncontrados
        public int[,] calcularHostsEncontrados() {
            int[,] datos = new int[hosts.Length, 2]; //Variable recipiente

            int n = 0, formula = 0;

            for (int i = 0; i < hosts.Length; i++) {
                while (hosts[i] > formula) {
                    n++; //Calculando exponente para la formula
                    formula = Int32.Parse((Math.Pow(2, n).ToString())) - 2; //Calculando formula
                }

                datos[i, 0] = n; //Almacenando resultados
                datos[i, 1] = formula;

                n = 0; //Reiniciando variables
                formula = 0;
            }

            return datos;

        }

        //Calcular octetetos individualmente
        public int calcularOcteto(BitArray bits) {
            int valor = 0;
            int tamano = bits.Length;
            int mid = (tamano / 2);

            for (int i = 0; i < bits.Count; i++) { //Calcular el valor del octeto
                if (bits[i]) {
                    valor += Convert.ToInt16(Math.Pow(2, i));
                }
            }

            for (int i = 0; i < mid; i++) { //Invertir array
                bool bit = bits[i];
                bits[i] = bits[tamano - i - 1];
                bits[tamano - i - 1] = bit;
            }

            return valor;
        }

        //Calcular mascara desde los bits
        public Mascara calcularMascaraByBits(int mskBits) {
            BitArray bits = new BitArray(32); //32 bits apagados/encendidos

            BitArray oct1 = new BitArray(8); //Dividir bits
            BitArray oct2 = new BitArray(8);
            BitArray oct3 = new BitArray(8);
            BitArray oct4 = new BitArray(8);

            int resta = bits.Length - mskBits; //Resta de bits

            Mascara mascara = new Mascara(); //Variable mascara

            for (int i = 0; i < mskBits; i++) { //Aisgnado bits encendidos/apagados
                bits[i] = false;
            }
            for (int i = resta; i < bits.Length; i++) {
                bits[i] = true;
            }

            for (int i = 0; i < bits.Length; i++) { //Dividiendo bits en 4 octs
                if (i < 8) {
                    oct1[i] = bits[i];
                }
                if (i > 7 && i < 16) {
                    oct2[i - 8] = bits[i];
                }
                if (i > 15 && i < 24) {
                    oct3[i - 16] = bits[i];
                }
                if (i > 23 && i < 32) {
                    oct4[i - 24] = bits[i];
                }
            }

            mascara.primerOct = calcularOcteto(oct4);
            mascara.segundoOct = calcularOcteto(oct3);
            mascara.tercerOct = calcularOcteto(oct2);
            mascara.cuartoOct = calcularOcteto(oct1);

            return mascara;

        }

        //Calcular red decimal
        public Red calcularRedDecimal(int num) {
            Red red = new Red();
            byte[] bytes = new byte[4];

            for (int i = 0; i < 4; i++) {
                bytes[i] = (byte)(num >> (i * 8) & 255);
            }

            red.primerOct = Convert.ToInt16(bytes[3]);
            red.segundoOct = Convert.ToInt16(bytes[2]);
            red.tercerOct = Convert.ToInt16(bytes[1]);
            red.cuartoOct = Convert.ToInt16(bytes[0]);

            return red;
        }

        //Metodo para calcular el salto de red
        public int[] calcularSalto(Mascara msk) {
            int[] oct = new int[5];

            if (msk.primerOct == 255) { //Revisar en que oct hubo el salto y guardarlo
                oct[0] = 0;
                if (msk.segundoOct == 255) {
                    oct[1] = 0;
                    if (msk.tercerOct == 255) {
                        oct[2] = 0;
                        if (msk.cuartoOct == 255) {
                            oct[3] = 0;
                            oct[4] = 0;
                        } else {
                            oct[4] = 256 - msk.cuartoOct;
                            oct[3] = 1;
                        }
                    } else {
                        oct[4] = 256 - msk.tercerOct;
                        oct[2] = 1;
                    }
                } else {
                    oct[4] = 256 - msk.segundoOct;
                    oct[1] = 1;
                }
            } else {
                oct[4] = 256 - msk.primerOct;
                oct[0] = 1;
            }

            return oct;
        }

        //Ejecutar el procedimiento
        public void calcular() {
            IPInicial ipInicial = new IPInicial();
            IPFinal ipFinal = new IPFinal();
            IPBroadcast ipBk = new IPBroadcast();
            Red red = new Red();
            red.primerOct = ipOriginal.primerOct;
            red.segundoOct = ipOriginal.segundoOct;
            red.tercerOct = ipOriginal.tercerOct;
            red.cuartoOct = ipOriginal.cuartoOct;

            int[,] datos = calcularHostsEncontrados();

            hostsEncontrados = new int[datos.GetLength(0)];
            for (int i = 0; i < hostsEncontrados.Length; i++) {
                hostsEncontrados[i] = datos[i, 1];
            }
                

            for (int i = 0; i < datos.GetLength(0); i++) {                
                int nx = 32 - datos[i, 0];
                Mascara mascara = calcularMascaraByBits(nx);
                int[] saltos = calcularSalto(mascara);
                Red ipPivote = calcularRedDecimal(datos[i, 1]);

                ipInicial.primerOct = red.primerOct;
                ipInicial.segundoOct = red.segundoOct;
                ipInicial.tercerOct = red.tercerOct;
                ipInicial.cuartoOct = red.cuartoOct + 1;

                ipFinal.primerOct = red.primerOct + ipPivote.primerOct;
                ipFinal.segundoOct = red.segundoOct + ipPivote.segundoOct;
                ipFinal.tercerOct = red.tercerOct + ipPivote.tercerOct;
                ipFinal.cuartoOct = red.cuartoOct + ipPivote.cuartoOct;

                ipBk.primerOct = ipFinal.primerOct;
                ipBk.segundoOct = ipFinal.segundoOct;
                ipBk.tercerOct = ipFinal.tercerOct;
                ipBk.cuartoOct = ipFinal.cuartoOct + 1;

                if(ipInicial.primerOct > 255) {
                    ipInicial.primerOct = 255;
                }
                if (ipInicial.segundoOct > 255) {
                    ipInicial.segundoOct = 255;
                }
                if (ipInicial.tercerOct > 255) {
                    ipInicial.tercerOct = 255;
                }
                if (ipInicial.cuartoOct > 255) {
                    ipInicial.cuartoOct = 255;
                }

                if (ipFinal.primerOct > 255) {
                    ipFinal.primerOct = 255;
                }
                if (ipFinal.segundoOct > 255) {
                    ipFinal.segundoOct = 255;
                }
                if (ipFinal.tercerOct > 255) {
                    ipFinal.tercerOct = 255;
                }
                if (ipFinal.cuartoOct > 255) {
                    ipFinal.cuartoOct = 255;
                }

                if (ipBk.primerOct > 255) {
                    ipBk.primerOct = 255;
                }
                if (ipBk.segundoOct > 255) {
                    ipBk.segundoOct = 255;
                }
                if (ipBk.tercerOct > 255) {
                    ipBk.tercerOct = 255;
                }
                if (ipBk.cuartoOct > 255) {
                    ipBk.cuartoOct = 255;
                }
                

                listaRedes.Add(new Red() { 
                    primerOct = red.primerOct,
                    segundoOct = red.segundoOct,
                    tercerOct = red.tercerOct,
                    cuartoOct = red.cuartoOct
                });

                listaMascaras.Add(new Mascara() {
                    primerOct = mascara.primerOct,
                    segundoOct = mascara.segundoOct,
                    tercerOct = mascara.tercerOct,
                    cuartoOct = mascara.cuartoOct
                });

                listaIPIniciales.Add(new IPInicial() {
                    primerOct = ipInicial.primerOct,
                    segundoOct = ipInicial.segundoOct,
                    tercerOct = ipInicial.tercerOct,
                    cuartoOct = ipInicial.cuartoOct
                });

                listaIPFinales.Add(new IPFinal() {
                    primerOct = ipFinal.primerOct,
                    segundoOct = ipFinal.segundoOct,
                    tercerOct = ipFinal.tercerOct,
                    cuartoOct = ipFinal.cuartoOct
                });

                listaIPBroadcast.Add(new IPBroadcast() {
                    primerOct = ipBk.primerOct,
                    segundoOct = ipBk.segundoOct,
                    tercerOct = ipBk.tercerOct,
                    cuartoOct = ipBk.cuartoOct
                });

                if (saltos[0] == 0) { //Aplicar el salto de red 
                    if (saltos[1] == 0) {
                        if (saltos[2] == 0) {
                            if (saltos[3] == 0) {

                            } else {
                                int oct4 = red.cuartoOct;
                                oct4 = oct4 + saltos[4];
                                if (oct4 > 254) {
                                    oct4 = red.tercerOct + 1;
                                    red.tercerOct = oct4;
                                } else {
                                    red.cuartoOct = oct4;
                                }
                            }
                        } else {
                            int oct3 = red.tercerOct;
                            oct3 = oct3 + saltos[4];
                            if (oct3 > 254) {
                                oct3 = red.segundoOct + 1;
                                red.segundoOct = oct3;
                            } else {
                                red.tercerOct = oct3;
                            }
                        }
                    } else {
                        int oct2 = red.segundoOct;
                        oct2 = oct2 + saltos[4];
                        if (oct2 > 254) {
                            oct2 = red.primerOct + 1;
                            red.primerOct = oct2;
                        } else {
                            red.segundoOct = oct2;
                        }
                    }
                } else {
                    int oct1 = red.primerOct;
                    oct1 = oct1 + saltos[4];
                    red.primerOct = oct1;
                }
                
            }

        }

    }
}
