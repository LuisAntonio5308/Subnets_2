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

namespace Subnets {
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm {

        UsuarioBLL usuarioBLL = UsuarioBLL.Instance();
        bool administrador = false;

        public frmLogin() {
            InitializeComponent();
        }

        public bool Login(string nickname, string contrasena) {
            if (!nickname.Equals("") && !contrasena.Equals("")) {
                Usuario usuario = new Usuario() { nickname = nickname, contrasena = contrasena };
                Usuario usuariox = new Usuario();

                if (usuarioBLL.Login(usuario)) {
                    MessageBox.Show("Acceso concedido");
                    txtUsuario.Clear();
                    txtContrasena.Clear();
                    txtUsuario.Focus();
                    usuariox = usuarioBLL.GetByNickname(usuario);
                    this.Hide();
                    
                    new frmMenuPrincipal(usuariox).ShowDialog();
                    this.Show();

                } else {
                    MessageBox.Show("Revisa tus datos");
                }

                return true;
            } else {
                MessageBox.Show("No puedes dejar campos vacios");
                return false;
            }
        }

        public void Cerrar(string nickname, string contrasena) {
            if (nickname.Equals("") && contrasena.Equals("")) {
                this.Close();
            } else {
            }
        }

        private void textEdit1_Properties_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar ==(char)13) {
                Login(txtUsuario.Text, txtContrasena.Text);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                Login(txtUsuario.Text, txtContrasena.Text);
            }
        }

        private void btnAceptar_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnAceptar.PerformClick();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            Login(txtUsuario.Text, txtContrasena.Text);
        }

        private void btnCancelar_KeyDown(object sender, KeyEventArgs e) {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e) {

            if (txtUsuario.Text.Equals("") && txtContrasena.Text.Equals("")) {
                e.Cancel = false;
            } else {
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

        private void btnCancelar_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}