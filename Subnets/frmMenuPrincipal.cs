using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
using BLL;
using Subnets.Topologias;
using Subnets.Usuarios;

namespace Subnets {
    public partial class frmMenuPrincipal : DevExpress.XtraEditors.XtraForm {

        Usuario usuario = new Usuario();
        Empresa empresa = new Empresa();
        frmPrincipal frmPrincipal;



        public frmMenuPrincipal(Usuario usuario) {
            InitializeComponent();
            this.usuario = usuario;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmPrincipal)) {
                    form.Activate();
                    return;

                }
            frmPrincipal = new frmPrincipal(usuario) { MdiParent = this };
            frmPrincipal.Show();

            if (usuario.administrador) {
                btnUsuarios.Enabled = true;
            } else {
                btnUsuarios.Enabled = false;
            }
        }

        private void btnEmpresas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmPrincipal)) {
                    form.Activate();
                    return;

                }
            frmPrincipal = new frmPrincipal(usuario) { MdiParent = this };
            frmPrincipal.Show();
        }

        private void btnTopologias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            if (frmPrincipal.GridControlGetRowCount() > 0) {
                string nombre = frmPrincipal.getSelectedEmpresa().nombreEmpresa;

                if (!nombre.Equals("nulo")) {
                    foreach (Form form in Application.OpenForms)
                        if (form.GetType() == typeof(frmTopologias)) {
                            form.Activate();
                            return;

                        }
                    MessageBox.Show("Empresa: " + nombre);
                    new frmTopologias(frmPrincipal.getSelectedEmpresa()) { MdiParent = this }.Show();
                } else {
                    MessageBox.Show("Debes seleccionar una empresa mi loko dele pa fuera");
                }
            } else {
                MessageBox.Show("No existe ninguna empresa");
            }
            

            


        }

        private void btnUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmUsuarios)) {
                    form.Activate();
                    return;

                }
            new frmUsuarios(usuario) { MdiParent = this }.Show();
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
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
    }
}