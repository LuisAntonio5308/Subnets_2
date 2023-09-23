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
using BOL;

namespace Subnets.Usuarios {
    public partial class frmEditarUsuario : DevExpress.XtraEditors.XtraForm {

        private UsuarioBLL usuarioBLL = UsuarioBLL.Instance();
        Usuario usuario = new Usuario();

        public frmEditarUsuario(Usuario usuario) {
            InitializeComponent();
            this.usuario = usuario;

            txtNickname.Text = usuario.nickname;
            txtContrasena.Text = usuario.contrasena;
            txtNombre.Text = usuario.nombre;
            txtApellidoP.Text = usuario.apellidoP;
            txtApellidoM.Text = usuario.apellidoM;
            txtDireccion.Text = usuario.direccionUsuario;
            txtCorreoElectronico.Text = usuario.correoElectronico;
            txtTelefono.Text = usuario.telefono;
            chkbtnAdmin.Checked = usuario.administrador;
        }

        private void guardar() {
            try {
                bool valor1 = false;
                bool valor2 = false;
                if (!txtNickname.Text.Equals("") && !txtContrasena.Text.Equals("") && !txtNombre.Text.Equals("")
                    && !txtApellidoP.Text.Equals("") && !txtApellidoM.Text.Equals("") && !txtDireccion.Text.Equals("")
                    && !txtCorreoElectronico.Text.Equals("") && !txtTelefono.Text.Equals("")) {

                    if (txtTelefono.Text.Length == 10) {
                        valor1 = true;
                    } else {
                        MessageBox.Show("El telefono debe tener 10 digitos");
                        valor1 = false;
                    }

                    if (validarCorreo(txtCorreoElectronico.Text)) {
                        valor2 = true;
                    } else {
                        MessageBox.Show("El correo debe ser valido");
                        valor2 = false;
                    }

                    if (valor1 && valor2) {
                        Usuario usuariox = new Usuario() {
                            nickname = txtNickname.Text,
                            contrasena = txtContrasena.Text,
                            nombre = txtNombre.Text,
                            apellidoP = txtApellidoP.Text,
                            apellidoM = txtApellidoM.Text,
                            direccionUsuario = txtDireccion.Text,
                            correoElectronico = txtCorreoElectronico.Text,
                            telefono = txtTelefono.Text,
                            administrador = chkbtnAdmin.Checked,
                            idUsuario = usuario.idUsuario
                        };

                        usuarioBLL.Update(usuariox);
                        txtNickname.Clear();
                        txtContrasena.Clear();
                        txtNombre.Clear();
                        txtApellidoP.Clear();
                        txtApellidoM.Clear();
                        txtDireccion.Clear();
                        txtCorreoElectronico.Clear();
                        txtTelefono.Clear();
                        chkbtnAdmin.Checked = false;

                        MessageBox.Show("Guardado con éxito");
                        this.Close();
                    }

                } else {
                    MessageBox.Show("No puedes dejar campos vacíos");
                }
            } catch (Exception ex) {
                MessageBox.Show("Ya existe ese nickname");
            }
        }

        private bool validarCorreo(string correo) {
            var trimmedEmail = correo.Trim();

            if (trimmedEmail.EndsWith(".")) {
                return false; // suggested by @TK-421
            }
            try {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == trimmedEmail;
            } catch {
                return false;
            }
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e) {
            guardar();
        }

        private void txtNickname_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                guardar();
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                guardar();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                guardar();
            }
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                guardar();
            }
        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                guardar();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                guardar();
            }
        }

        private void txtCorreoElectronico_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                guardar();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                guardar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmEditarUsuario_FormClosing(object sender, FormClosingEventArgs e) {
            if (txtNickname.Text.Equals("") && txtContrasena.Text.Equals("") && txtNombre.Text.Equals("")
                && txtApellidoP.Text.Equals("") && txtApellidoM.Text.Equals("") && txtDireccion.Text.Equals("")
                && txtCorreoElectronico.Text.Equals("") && txtTelefono.Text.Equals("")) {
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
    }
}