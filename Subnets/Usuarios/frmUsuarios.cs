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

namespace Subnets.Usuarios {
    public partial class frmUsuarios : DevExpress.XtraEditors.XtraForm {

        private UsuarioBLL usuarioBLL = UsuarioBLL.Instance();
        Usuario usuariox = new Usuario();

        public frmUsuarios(Usuario usuariox) {
            InitializeComponent();
            gdcUsuarios.DataSource = usuarioBLL.GetAll();
            btnEditarUsuario.Enabled = false;
            btnEliminarUsuario.Enabled = false;
            this.usuariox = usuariox;
        }

        private void gdvUsuarios_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) {
            btnEditarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e) {
            frmNuevoUsuario frmNuevoUsuario = new frmNuevoUsuario();
            frmNuevoUsuario.ShowDialog();
            gdcUsuarios.DataSource = usuarioBLL.GetAll();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e) {
            Usuario usuario = (Usuario)gdvUsuarios.FocusedRowObject;
            if (usuariox.idUsuario == usuario.idUsuario) {
                MessageBox.Show("No puedes eliminar el usuario actual");
            } else {
                frmEditarUsuario frmEditarUsuario = new frmEditarUsuario(usuario);
                frmEditarUsuario.ShowDialog();
                btnEditarUsuario.Enabled = false;
                btnEliminarUsuario.Enabled = false;
                gdcUsuarios.DataSource = usuarioBLL.GetAll();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e) {
            Usuario usuario = (Usuario)gdvUsuarios.FocusedRowObject;
            if (usuariox.idUsuario == usuario.idUsuario) {
                MessageBox.Show("No puedes eliminar el usuario actual");
            } else {
                usuarioBLL.Remove(usuario);
                MessageBox.Show("Eliminado correctamente");
                btnEditarUsuario.Enabled = false;
                btnEliminarUsuario.Enabled = false;
                gdcUsuarios.DataSource = usuarioBLL.GetAll();
            }
        }
    }
}