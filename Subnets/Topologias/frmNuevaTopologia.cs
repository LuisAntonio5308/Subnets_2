using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
using BLL;
using Subnets.AlgoritmoVLSM;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;

namespace Subnets.Topologias {
    public partial class frmNuevaTopologia : DevExpress.XtraEditors.XtraForm {

        private RedBLL redBLL = RedBLL.Instance();
        private MascaraBLL mascaraBLL = MascaraBLL.Instance();
        private IPInicialBLL ipinicialBLL = IPInicialBLL.Instance();
        private IPFinalBLL ipfinalBLL = IPFinalBLL.Instance();
        private IPBroadcastBLL ipbroadcastBLL = IPBroadcastBLL.Instance();
        private TopologiaBLL topologiaBLL = TopologiaBLL.Instance();
        private RedPackBLL redPackBLL = RedPackBLL.Instance();
        List<Red> listaRedes;
        List<Mascara> listaMascaras;
        List<IPInicial> listaIPIniciales;
        List<IPFinal> listaIPFinales;
        List<IPBroadcast> listaIPBroadcast;



        Empresa empresa = new Empresa();
        List<HostsObj> list = new List<HostsObj>();
        Object obj = new { NumRed = 0, Hosts = 0 };

        public frmNuevaTopologia(Empresa empresa) {
            InitializeComponent();
            this.empresa = empresa;
            dteFecha.DateTime = DateTime.Now;

            btnGuardar.Enabled = false;
            cargarTablaHosts(Convert.ToInt32(spnRedes.Value));
        }

        private void cargarTablaHosts(int numReds) {
            int[,] hosts = new int[2, numReds];

            for (int i = 0; i < numReds; i++) {
                hosts[0, i] = i + 1;
                hosts[1, i] = 1;
            }

            for (int i = 0; i < hosts.GetLength(1); i++) {
                Console.WriteLine("[0][" + i + "]: " + hosts[0, i]);
            }

            Console.WriteLine();

            for (int i = 0; i < hosts.GetLength(1); i++) {
                Console.WriteLine("[1][" + i + "]: " + hosts[1, i]);
            }

            list = new List<HostsObj>();
            for (int i = 0; i < hosts.GetLength(1); i++) {
                list.Add(new HostsObj() { NumRed = hosts[0, i], Hosts = hosts[1, i] });
            }

            gdcHosts.DataSource = list;

            gdvHosts.Columns[0].OptionsColumn.AllowEdit = false;
            gdvHosts.Columns[1].OptionsColumn.AllowEdit = true;
        }

        private void cargarTablaHostsX(int numReds) {
            int[,] hosts = new int[2, numReds];

            for (int i = 0; i < numReds; i++) {
                hosts[0, i] = i + 1;
                hosts[1, i] = 1;
            }

            /*for (int i = 0; i < numReds; i++) {

                bool valor = false;

                try {
                    do {
                        string numeroStr = Microsoft.VisualBasic.Interaction.InputBox("[" + (i + 1) + "] Ingresa un número entero:", "Ingreso de número entero", "");
                        int numx = Convert.ToInt32(numeroStr);
                        hosts[0, i] = i + 1;
                        hosts[1, i] = numx;
                    } while (valor);
                    valor = true;
                } catch (Exception ex) {
                    valor = false;
                    MessageBox.Show("Por default el valor será 1");
                    hosts[0, i] = i + 1;
                    hosts[1, i] = 1;
                }
            }*/

            for (int i = 0; i < hosts.GetLength(1); i++) {
                Console.WriteLine("[0][" + i + "]: " + hosts[0, i]);
            }

            Console.WriteLine();

            for (int i = 0; i < hosts.GetLength(1); i++) {
                Console.WriteLine("[1][" + i + "]: " + hosts[1, i]);
            }

            list = new List<HostsObj>();
            for (int i = 0; i < hosts.GetLength(1); i++) {
                list.Add(new HostsObj() { NumRed = hosts[0, i], Hosts = hosts[1, i] });
            }

            gdcHosts.DataSource = list;

            gdvHosts.Columns[0].OptionsColumn.AllowEdit = false;
            gdvHosts.Columns[1].OptionsColumn.AllowEdit = true;
        }

        private void btnCalcularVLSM_Click(object sender, EventArgs e) {
            procesar();
        }

        private void procesar() {
            try {
                if (!txtDireccionIP.Text.Equals("") && !txtNombre.Text.Equals("")) {
                    Topologia topologia = new Topologia() {
                        nombreTopologia = txtNombre.Text,
                        fecha = dteFecha.DateTime,
                        idEmpresa = empresa.idEmpresa
                    };

                    //Obteniendo los hosts de la tabla
                    int[] hosts = new int[list.Count];
                    for (int i = 0; i < hosts.Length; i++) {
                        hosts[i] = (int)list[i].Hosts;
                    }

                    //Obtiene los octetos de la red
                    string[] octsx = txtDireccionIP.Text.Split('.');
                    int[] octs = new int[4];
                    octs[0] = Convert.ToInt32(octsx[0]);
                    octs[1] = Convert.ToInt32(octsx[1]);
                    octs[2] = Convert.ToInt32(octsx[2]);
                    octs[3] = Convert.ToInt32(octsx[3]);

                    for (int i = 0; i < octs.Length; i++) {
                        Console.WriteLine("Octs[" + i + "]: " + octs[i]);
                    }


                    Red red = new Red();
                    red.primerOct = octs[0];
                    red.segundoOct = octs[1];
                    red.tercerOct = octs[2];
                    red.cuartoOct = octs[3];

                    VLSM vlsm = new VLSM();

                    vlsm.leerDatos(hosts.Length, hosts, red);
                    vlsm.calcular();

                    int[] hostEncontrados = vlsm.GetHostEncontrados();
                    listaRedes = vlsm.GetListaRedes();
                    listaMascaras = vlsm.GetMascaras();
                    listaIPIniciales = vlsm.GetIPIniciales();
                    listaIPFinales = vlsm.GetIPFinales();
                    listaIPBroadcast = vlsm.GetIPBroadcasts();

                    List<RedObj> listaRedObjs = new List<RedObj>();
                    List<RedObjStrg> listaRedObjStrg = new List<RedObjStrg>();

                    for (int i = 0; i < hostEncontrados.Length; i++) {
                        Console.WriteLine("Hosts: " + hostEncontrados[i]);
                    }

                    for (int i = 0; i < listaRedes.Count; i++) {
                        RedObj redObj = new RedObj();
                        RedObjStrg redObjStrg = new RedObjStrg();
                        Console.WriteLine("Red: " + listaRedes[i].imprimir());
                        redObj.red = listaRedes[i];
                        redObjStrg.red = listaRedes[i].imprimir();
                        Console.WriteLine("Mascara: " + listaMascaras[i].imprimir());
                        redObj.mascara = listaMascaras[i];
                        redObjStrg.mascara = listaMascaras[i].imprimir();
                        Console.WriteLine("IP Inicial: " + listaIPIniciales[i].imprimir());
                        redObj.ipinicial = listaIPIniciales[i];
                        redObjStrg.ipinicial = listaIPIniciales[i].imprimir();
                        Console.WriteLine("IP Final: " + listaIPFinales[i].imprimir());
                        redObj.ipfinal = listaIPFinales[i];
                        redObjStrg.ipfinal = listaIPFinales[i].imprimir();
                        Console.WriteLine("IP Bk:: " + listaIPBroadcast[i].imprimir());
                        redObj.ipbroadcast = listaIPBroadcast[i];
                        redObjStrg.ipbroadcast = listaIPBroadcast[i].imprimir();
                        listaRedObjs.Add(redObj);
                        listaRedObjStrg.Add(redObjStrg);
                    }

                    gdcVLSM.DataSource = listaRedObjStrg;
                    gdvVLSM.Columns[0].Caption = "Red";
                    gdvVLSM.Columns[1].Caption = "Mascara";
                    gdvVLSM.Columns[2].Caption = "IP Inicial";
                    gdvVLSM.Columns[3].Caption = "IP Final";
                    gdvVLSM.Columns[4].Caption = "IP Broadcast";

                    gdvVLSM.Columns[0].OptionsColumn.AllowEdit = false;
                    gdvVLSM.Columns[1].OptionsColumn.AllowEdit = false;
                    gdvVLSM.Columns[2].OptionsColumn.AllowEdit = false;
                    gdvVLSM.Columns[3].OptionsColumn.AllowEdit = false;
                    gdvVLSM.Columns[4].OptionsColumn.AllowEdit = false;

                    btnGuardar.Enabled = true;

                } else {
                    MessageBox.Show("Revisa tus inputs");
                }

            } catch (Exception ex) {
                throw new Exception("Error: " + ex.Message);
            }
        }

        private void spnRedes_EditValueChanged(object sender, EventArgs e) {
            cargarTablaHosts(Convert.ToInt32(spnRedes.Value));
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            List<Topologia> topos = topologiaBLL.GetByEmpresa(empresa).ToList<Topologia>();
            bool valor = true;
            for (int i = 0; i < topos.Count; i++) {
                if (topos[i].nombreTopologia.Equals(txtNombre.Text)) {
                    valor = false;
                }
            }

            if (valor) {
                Topologia topologiax = new Topologia() {
                    nombreTopologia = txtNombre.Text,
                    fecha = dteFecha.DateTime,
                    idEmpresa = empresa.idEmpresa
                };
                topologiaBLL.Add(topologiax);

                Topologia topologia = topologiaBLL.GetByNombre(topologiax);

                RedPack redPackx = new RedPack() {
                    idTopologia = topologia.idTopologia,
                };
                redPackBLL.Add(redPackx);

                RedPack redPack = redPackBLL.GetByIDTopologia(redPackx);

                for (int i = 0; i < listaRedes.Count; i++) {
                    listaRedes[i].idPack = redPack.idPack;
                    listaMascaras[i].idPack = redPack.idPack;
                    listaIPIniciales[i].idPack = redPack.idPack;
                    listaIPFinales[i].idPack = redPack.idPack;
                    listaIPBroadcast[i].idPack = redPack.idPack;
                }

                for (int i = 0; i < listaRedes.Count; i++) {
                    redBLL.Add(listaRedes[i]);
                    mascaraBLL.Add(listaMascaras[i]);
                    ipinicialBLL.Add(listaIPIniciales[i]);
                    ipfinalBLL.Add(listaIPFinales[i]);
                    ipbroadcastBLL.Add(listaIPBroadcast[i]);
                }

                MessageBox.Show("Guardado con éxito!");
                this.Close();
            } else {
                MessageBox.Show("No puede haber dos redes con el mismo nombre");
            }

            /*
            
            */


        }

        private void spnRedes_Leave(object sender, EventArgs e) {
            
        }

        private void frmNuevaTopologia_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea salir?",
                                                    "SALIR",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (dialogo == DialogResult.No) {
                e.Cancel = true;
            } else {
                e.Cancel = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                procesar();
            }
        }

        private void dteFecha_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                procesar();
            }
        }

        private void txtDireccionIP_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                procesar();
            }
        }

        private void gdcHosts_EditorKeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                procesar();
            }
        }
    }
}