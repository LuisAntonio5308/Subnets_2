using BLL;
using BOL;
using DevExpress.Data.Mask.Internal;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using Subnets.Principal;
using Subnets.Topologias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subnets {
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm {

        Usuario usuario = new Usuario();
        EmpresaBLL empresaBLL = EmpresaBLL.Instance();
        public Empresa empresaReturn = new Empresa();

        public frmPrincipal(Usuario usuario) {
            InitializeComponent();
            this.usuario = usuario;
            btnEditarEmpresa.Enabled = false; //Pendiente
            btnEliminarEmpresa.Enabled = false;
            gdcEmpresas.DataSource = empresaBLL.GetAll();
            
        }

        public int GridControlGetRowCount() {
            int count = 0;
            count = gdvEmpresas.RowCount;
            return count;
        }

        public Empresa getSelectedEmpresa() {
            try {
                Empresa empresa = (Empresa)gdvEmpresas.FocusedRowObject;

                if (empresa is null) {
                    return new Empresa() { nombreEmpresa = "nulo" };
                } else {
                    
                    return empresa;
                }

                
            } catch (Exception ex) {
                MessageBox.Show("Debes seleccionar una empresa");
                return new Empresa() { nombreEmpresa = "nulo"};
            }
            
        }


        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e) {

        }

        private void gdvEmpresas_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) {
            btnEditarEmpresa.Enabled = true; //Pendiente
            btnEliminarEmpresa.Enabled = true;
            
        }

        private void btnEditarEmpresa_Click(object sender, EventArgs e) {
            Empresa empresa = (Empresa) gdvEmpresas.FocusedRowObject;
            frmEditarEmpresa frmEditarEmpresa = new frmEditarEmpresa(empresa);
            frmEditarEmpresa.ShowDialog();
            gdcEmpresas.DataSource = empresaBLL.GetAll();
            btnEditarEmpresa.Enabled = false;
            btnEliminarEmpresa.Enabled=false;
        }

        private void btnNuevaEmpresa_Click(object sender, EventArgs e) {
            frmNuevaEmpresa frmNuevaEmpresa = new frmNuevaEmpresa();
            frmNuevaEmpresa.ShowDialog();
            gdcEmpresas.DataSource = empresaBLL.GetAll();
        }

        private void btnEliminarEmpresa_Click(object sender, EventArgs e) {
            Empresa empresa = (Empresa)gdvEmpresas.FocusedRowObject;
            empresaBLL.RemoveAll(empresa);
            gdcEmpresas.DataSource = empresaBLL.GetAll();
            gdvEmpresas.RefreshData();
            btnEliminarEmpresa.Enabled = false;
            btnEditarEmpresa.Enabled = false;
            Form mdiParent = this.ParentForm;
            foreach (Form form in mdiParent.MdiChildren) {
                if (form.GetType() == typeof(frmTopologias)) {
                    form.Close();
                    break;
                }
            }

        }

        
    }
}