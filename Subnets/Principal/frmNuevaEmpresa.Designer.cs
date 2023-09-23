namespace Subnets.Principal {
    partial class frmNuevaEmpresa {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gcNuevaEmpresa = new DevExpress.XtraEditors.GroupControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarEmpresa = new DevExpress.XtraEditors.SimpleButton();
            this.txtCorreoElectronico = new DevExpress.XtraEditors.TextEdit();
            this.lblCorreo = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.lblTelefono = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.lblDireccion = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcNuevaEmpresa)).BeginInit();
            this.gcNuevaEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreoElectronico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcNuevaEmpresa
            // 
            this.gcNuevaEmpresa.Controls.Add(this.btnCancelar);
            this.gcNuevaEmpresa.Controls.Add(this.btnGuardarEmpresa);
            this.gcNuevaEmpresa.Controls.Add(this.txtCorreoElectronico);
            this.gcNuevaEmpresa.Controls.Add(this.lblCorreo);
            this.gcNuevaEmpresa.Controls.Add(this.txtTelefono);
            this.gcNuevaEmpresa.Controls.Add(this.lblTelefono);
            this.gcNuevaEmpresa.Controls.Add(this.txtDireccion);
            this.gcNuevaEmpresa.Controls.Add(this.lblDireccion);
            this.gcNuevaEmpresa.Controls.Add(this.txtNombre);
            this.gcNuevaEmpresa.Controls.Add(this.lblNombre);
            this.gcNuevaEmpresa.Location = new System.Drawing.Point(12, 12);
            this.gcNuevaEmpresa.Name = "gcNuevaEmpresa";
            this.gcNuevaEmpresa.Size = new System.Drawing.Size(369, 254);
            this.gcNuevaEmpresa.TabIndex = 0;
            this.gcNuevaEmpresa.Text = "Nueva Empresa";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseBackColor = true;
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Location = new System.Drawing.Point(202, 201);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarEmpresa
            // 
            this.btnGuardarEmpresa.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnGuardarEmpresa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEmpresa.Appearance.Options.UseBackColor = true;
            this.btnGuardarEmpresa.Appearance.Options.UseFont = true;
            this.btnGuardarEmpresa.Location = new System.Drawing.Point(52, 201);
            this.btnGuardarEmpresa.Name = "btnGuardarEmpresa";
            this.btnGuardarEmpresa.Size = new System.Drawing.Size(116, 32);
            this.btnGuardarEmpresa.TabIndex = 5;
            this.btnGuardarEmpresa.Text = "Guardar empresa";
            this.btnGuardarEmpresa.Click += new System.EventHandler(this.btnGuardarEmpresa_Click);
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(153, 135);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Properties.Appearance.Options.UseFont = true;
            this.txtCorreoElectronico.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorreoElectronico.Properties.MaxLength = 100;
            this.txtCorreoElectronico.Size = new System.Drawing.Size(180, 24);
            this.txtCorreoElectronico.TabIndex = 4;
            this.txtCorreoElectronico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreoElectronico_KeyPress);
            // 
            // lblCorreo
            // 
            this.lblCorreo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Appearance.Options.UseFont = true;
            this.lblCorreo.Location = new System.Drawing.Point(36, 138);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(42, 18);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "E-Mail:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(153, 105);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTelefono.Properties.MaskSettings.Set("mask", "d");
            this.txtTelefono.Properties.MaxLength = 10;
            this.txtTelefono.Size = new System.Drawing.Size(180, 24);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Appearance.Options.UseFont = true;
            this.lblTelefono.Location = new System.Drawing.Point(36, 108);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(62, 18);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(153, 75);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Properties.MaxLength = 150;
            this.txtDireccion.Size = new System.Drawing.Size(180, 24);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Appearance.Options.UseFont = true;
            this.lblDireccion.Location = new System.Drawing.Point(36, 78);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(62, 18);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Properties.MaxLength = 100;
            this.txtNombre.Size = new System.Drawing.Size(180, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Appearance.Options.UseFont = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmNuevaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 278);
            this.Controls.Add(this.gcNuevaEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNuevaEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPRESA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNuevaEmpresa_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gcNuevaEmpresa)).EndInit();
            this.gcNuevaEmpresa.ResumeLayout(false);
            this.gcNuevaEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreoElectronico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcNuevaEmpresa;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.LabelControl lblTelefono;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.LabelControl lblDireccion;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardarEmpresa;
        private DevExpress.XtraEditors.TextEdit txtCorreoElectronico;
        private DevExpress.XtraEditors.LabelControl lblCorreo;
    }
}