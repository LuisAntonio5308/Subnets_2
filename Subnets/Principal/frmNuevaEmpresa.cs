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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Subnets.Principal {
    public partial class frmNuevaEmpresa : DevExpress.XtraEditors.XtraForm {

        EmpresaBLL EmpresaBLL = EmpresaBLL.Instance();
        public frmNuevaEmpresa() {
            InitializeComponent();
        }

        private void guardar() {
            bool valor1 = false;
            bool valor2 = false;
            if (!txtNombre.Text.Equals("") && !txtDireccion.Text.Equals("") && !txtCorreoElectronico.Text.Equals("") && !txtTelefono.Text.Equals("")) {
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
                    try {
                        Empresa empresa = new Empresa() {
                            nombreEmpresa = txtNombre.Text,
                            correoElectronico = txtCorreoElectronico.Text,
                            direccionEmpresa = txtDireccion.Text,
                            telefono = txtTelefono.Text
                        };
                        EmpresaBLL.Add(empresa);
                        txtNombre.Clear();
                        txtDireccion.Clear();
                        txtCorreoElectronico.Clear();
                        txtTelefono.Clear();

                        MessageBox.Show("Guardado con exito");
                        this.Close();
                    } catch (Exception ex) {
                        MessageBox.Show("No puede haber dos empresas con los mismos datos");
                    }
                }

            } else {
                MessageBox.Show("No puedes dejar campos vacíos");
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

        private void frmNuevaEmpresa_FormClosing(object sender, FormClosingEventArgs e) {
            if (txtNombre.Text.Equals("") && txtDireccion.Text.Equals("") && txtCorreoElectronico.Text.Equals("")  && txtTelefono.Text.Equals("")) {
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
            this.Close();
        }

        private void btnGuardarEmpresa_Click(object sender, EventArgs e) {
            guardar();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                guardar();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                guardar();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                guardar();
            }
        }

        private void txtCorreoElectronico_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                guardar();
            }
        }

        private void btnGuardarEmpresa_KeyPress(object sender, KeyPressEventArgs e) {

        }
    }
}