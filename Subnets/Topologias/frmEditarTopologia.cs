using BLL;
using BOL;
using DevExpress.XtraEditors;
using Subnets.AlgoritmoVLSM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subnets.Topologias {
    public partial class frmEditarTopologia : DevExpress.XtraEditors.XtraForm {

        TopologiaBLL topologiaBLL = TopologiaBLL.Instance();
        RedPackBLL redPackBLL = RedPackBLL.Instance();
        RedBLL redBLL = RedBLL.Instance();
        MascaraBLL mascaraBLL = MascaraBLL.Instance();
        IPInicialBLL ipinicialBLL = IPInicialBLL.Instance();
        IPFinalBLL ipfinalBLL = IPFinalBLL.Instance();
        IPBroadcastBLL ipbroadcastBLL = IPBroadcastBLL.Instance();


        Topologia topologia = new Topologia();
        Empresa empresa = new Empresa();
        RedPack redPack = new RedPack();


        List<HostsObj> list = new List<HostsObj>();
        List<Red> listaRedes;
        List<Mascara> listaMascaras;
        List<IPInicial> listaIPIniciales;
        List<IPFinal> listaIPFinales;
        List<IPBroadcast> listaIPBroadcast;
        int[] idReds;
        int[] idMascaras;
        int[] idIPIniciales;
        int[] idIPFinales;
        int[] idIPBroadcasts;

        public frmEditarTopologia(Topologia topologia, Empresa empresa) {
            InitializeComponent();

            this.topologia = topologiaBLL.GetByNombre(topologia);

            RedPack redPackx = new RedPack();
            redPackx.idTopologia = this.topologia.idTopologia;

            this.redPack = redPackBLL.GetByIDTopologia(redPackx);
            this.empresa = empresa;
            txtNombre.Text = this.topologia.nombreTopologia;
            dteFecha.DateTime = this.topologia.fecha;

            cargarTablaVLSM();
            spnRedes.Value = gdvVLSM.RowCount;
            cargarTablaHosts(Convert.ToInt32(spnRedes.Value));

            idReds = new int[listaRedes.Count];
            idMascaras = new int[listaMascaras.Count];
            idIPIniciales = new int[listaIPIniciales.Count];
            idIPFinales = new int[listaIPFinales.Count];
            idIPBroadcasts = new int[listaIPBroadcast.Count];

            for (int i = 0; i < listaRedes.Count; i++) {
                idReds[i] = listaRedes[i].id;
                idMascaras[i] = listaMascaras[i].id;
                idIPIniciales[i] = listaIPIniciales[i].id;
                idIPFinales[i] = listaIPFinales[i].id;
                idIPBroadcasts[i] = listaIPBroadcast[i].id;
            }
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

        private void spnRedes_EditValueChanged(object sender, EventArgs e) {

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

        private void cargarTablaVLSM() {


            Red redx = new Red() { idPack = redPack.idPack };
            Mascara mascarax = new Mascara() { idPack = redPack.idPack };
            IPInicial ipinicialx = new IPInicial() { idPack = redPack.idPack };
            IPFinal ipfinalx = new IPFinal() { idPack = redPack.idPack };
            IPBroadcast ipbroadcastx = new IPBroadcast() { idPack = redPack.idPack };


            listaRedes = redBLL.GetByPack(redx).ToList<Red>();
            listaMascaras = mascaraBLL.GetByPack(mascarax).ToList<Mascara>();
            listaIPIniciales = ipinicialBLL.GetByPack(ipinicialx).ToList<IPInicial>();
            listaIPFinales = ipfinalBLL.GetByPack(ipfinalx).ToList<IPFinal>();
            listaIPBroadcast = ipbroadcastBLL.GetByPack(ipbroadcastx).ToList<IPBroadcast>();

            List<RedObj> listaRedObjs = new List<RedObj>();
            List<RedObjStrg> listaRedObjStrg = new List<RedObjStrg>();



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

        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            List<Topologia> topos = topologiaBLL.GetByEmpresa(empresa).ToList<Topologia>();

            topologia.nombreTopologia = txtNombre.Text;
            topologia.fecha = dteFecha.DateTime;
            topologia.idEmpresa = empresa.idEmpresa;
            topologiaBLL.Update(topologia);

            for (int i = 0; i < listaRedes.Count; i++) {
                listaRedes[i].id = idReds[i];
                listaMascaras[i].id = idMascaras[i];
                listaIPIniciales[i].id = idIPIniciales[i];
                listaIPFinales[i].id = idIPFinales[i];
                listaIPBroadcast[i].id = idIPBroadcasts[i];
            }

            for (int i = 0; i < listaRedes.Count; i++) {
                redBLL.Update(listaRedes[i]);
                mascaraBLL.Update(listaMascaras[i]);
                ipinicialBLL.Update(listaIPIniciales[i]);
                ipfinalBLL.Update(listaIPFinales[i]);
                ipbroadcastBLL.Update(listaIPBroadcast[i]);
            }

            MessageBox.Show("Guardado con éxito!");
            this.Close();

        }

        private void frmEditarTopologia_FormClosing(object sender, FormClosingEventArgs e) {
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

        private void txtDireccionIP_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                procesar();
            }
        }

        private void dteFecha_KeyPress(object sender, KeyPressEventArgs e) {
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