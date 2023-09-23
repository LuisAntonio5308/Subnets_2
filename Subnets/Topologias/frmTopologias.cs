using BOL;
using BLL;
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

namespace Subnets.Topologias {
    public partial class frmTopologias : DevExpress.XtraEditors.XtraForm {

        public Empresa empresa = new Empresa();
        EmpresaBLL empesaBLL = EmpresaBLL.Instance();
        TopologiaBLL topologiaBLL = TopologiaBLL.Instance();

        public Empresa getEmpresa() {
            return empresa;
        }

        public frmTopologias(Empresa empresa) {
            InitializeComponent();
            this.empresa = empresa;
            gdcTopologias.DataSource = topologiaBLL.GetByEmpresa(empresa);
            this.btnEditarTopologia.Enabled = false;
            this.btnEliminarTopologia.Enabled = false;
            lblTopologiasTabla.Text = "Topologias: " + empresa.nombreEmpresa;
        }

        private void gdvTopologias_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) {
            this.btnEditarTopologia.Enabled = true;
            this.btnEliminarTopologia.Enabled = true;
        }

        private void btnNuevaTopologia_Click(object sender, EventArgs e) {
            frmNuevaTopologia frmNuevaTopologia = new frmNuevaTopologia(empresa);
            frmNuevaTopologia.ShowDialog();
            gdcTopologias.DataSource = topologiaBLL.GetByEmpresa(empresa);
        }

        private void btnEditarTopologia_Click(object sender, EventArgs e) {
            Topologia topo = (Topologia) gdvTopologias.FocusedRowObject;
            frmEditarTopologia frmEditarTopologia = new frmEditarTopologia(topo, empresa);
            frmEditarTopologia.ShowDialog();
            gdcTopologias.DataSource = topologiaBLL.GetByEmpresa(empresa);
        }

        private void btnEliminarTopologia_Click(object sender, EventArgs e) {
            Topologia topo = (Topologia)gdvTopologias.FocusedRowObject;
            topologiaBLL.RemoveAll(topo);
            MessageBox.Show("Eliminada correctamente");
            gdcTopologias.DataSource = topologiaBLL.GetByEmpresa(empresa);
            btnEditarTopologia.Enabled = false;
            btnEliminarTopologia.Enabled = false;
        }

        private void gdvTopologias_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) {
            this.btnEditarTopologia.Enabled = true;
            this.btnEliminarTopologia.Enabled = true;
        }
    }
}