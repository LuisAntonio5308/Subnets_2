namespace Subnets.Topologias {
    partial class frmEditarTopologia {
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
            this.gcRedPacks = new DevExpress.XtraEditors.GroupControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCalcularVLSM = new DevExpress.XtraEditors.SimpleButton();
            this.gdcHosts = new DevExpress.XtraGrid.GridControl();
            this.gdvHosts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcVLSM = new DevExpress.XtraGrid.GridControl();
            this.gdvVLSM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dteFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.spnRedes = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccionIP = new DevExpress.XtraEditors.TextEdit();
            this.lblDireccionIP = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcRedPacks)).BeginInit();
            this.gcRedPacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcHosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvHosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcVLSM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVLSM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnRedes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcRedPacks
            // 
            this.gcRedPacks.Controls.Add(this.btnCancelar);
            this.gcRedPacks.Controls.Add(this.btnGuardar);
            this.gcRedPacks.Controls.Add(this.btnCalcularVLSM);
            this.gcRedPacks.Controls.Add(this.gdcHosts);
            this.gcRedPacks.Controls.Add(this.gdcVLSM);
            this.gcRedPacks.Controls.Add(this.dteFecha);
            this.gcRedPacks.Controls.Add(this.lblFecha);
            this.gcRedPacks.Controls.Add(this.spnRedes);
            this.gcRedPacks.Controls.Add(this.labelControl1);
            this.gcRedPacks.Controls.Add(this.txtDireccionIP);
            this.gcRedPacks.Controls.Add(this.lblDireccionIP);
            this.gcRedPacks.Controls.Add(this.txtNombre);
            this.gcRedPacks.Controls.Add(this.lblNombre);
            this.gcRedPacks.Location = new System.Drawing.Point(12, 12);
            this.gcRedPacks.Name = "gcRedPacks";
            this.gcRedPacks.Size = new System.Drawing.Size(894, 394);
            this.gcRedPacks.TabIndex = 1;
            this.gcRedPacks.Text = "RedPacks - Editar Topologia";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseBackColor = true;
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Location = new System.Drawing.Point(23, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseBackColor = true;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Location = new System.Drawing.Point(23, 180);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCalcularVLSM
            // 
            this.btnCalcularVLSM.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnCalcularVLSM.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularVLSM.Appearance.Options.UseBackColor = true;
            this.btnCalcularVLSM.Appearance.Options.UseFont = true;
            this.btnCalcularVLSM.Location = new System.Drawing.Point(23, 139);
            this.btnCalcularVLSM.Name = "btnCalcularVLSM";
            this.btnCalcularVLSM.Size = new System.Drawing.Size(113, 35);
            this.btnCalcularVLSM.TabIndex = 5;
            this.btnCalcularVLSM.Text = "Calcular VLSM";
            this.btnCalcularVLSM.Click += new System.EventHandler(this.btnCalcularVLSM_Click);
            // 
            // gdcHosts
            // 
            this.gdcHosts.Location = new System.Drawing.Point(183, 139);
            this.gdcHosts.MainView = this.gdvHosts;
            this.gdcHosts.Name = "gdcHosts";
            this.gdcHosts.Size = new System.Drawing.Size(150, 250);
            this.gdcHosts.TabIndex = 8;
            this.gdcHosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvHosts});
            this.gdcHosts.EditorKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gdcHosts_EditorKeyPress);
            // 
            // gdvHosts
            // 
            this.gdvHosts.GridControl = this.gdcHosts;
            this.gdvHosts.Name = "gdvHosts";
            this.gdvHosts.OptionsCustomization.AllowSort = false;
            // 
            // gdcVLSM
            // 
            this.gdcVLSM.Location = new System.Drawing.Point(339, 139);
            this.gdcVLSM.MainView = this.gdvVLSM;
            this.gdcVLSM.Name = "gdcVLSM";
            this.gdcVLSM.Size = new System.Drawing.Size(550, 250);
            this.gdcVLSM.TabIndex = 9;
            this.gdcVLSM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvVLSM});
            // 
            // gdvVLSM
            // 
            this.gdvVLSM.GridControl = this.gdcVLSM;
            this.gdvVLSM.Name = "gdvVLSM";
            this.gdvVLSM.OptionsBehavior.ReadOnly = true;
            // 
            // dteFecha
            // 
            this.dteFecha.EditValue = null;
            this.dteFecha.Location = new System.Drawing.Point(95, 76);
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteFecha.Properties.Appearance.Options.UseFont = true;
            this.dteFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Size = new System.Drawing.Size(180, 24);
            this.dteFecha.TabIndex = 4;
            this.dteFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dteFecha_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Appearance.Options.UseFont = true;
            this.lblFecha.Location = new System.Drawing.Point(23, 75);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(39, 18);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // spnRedes
            // 
            this.spnRedes.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnRedes.Location = new System.Drawing.Point(700, 42);
            this.spnRedes.Name = "spnRedes";
            this.spnRedes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnRedes.Properties.Appearance.Options.UseFont = true;
            this.spnRedes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnRedes.Properties.MaxLength = 2;
            this.spnRedes.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spnRedes.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnRedes.Properties.ReadOnly = true;
            this.spnRedes.Size = new System.Drawing.Size(70, 24);
            this.spnRedes.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(604, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 18);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "No. de redes:";
            // 
            // txtDireccionIP
            // 
            this.txtDireccionIP.EditValue = "10.0.0.0";
            this.txtDireccionIP.Location = new System.Drawing.Point(391, 42);
            this.txtDireccionIP.Name = "txtDireccionIP";
            this.txtDireccionIP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionIP.Properties.Appearance.Options.UseFont = true;
            this.txtDireccionIP.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtDireccionIP.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtDireccionIP.Properties.MaskSettings.Set("mask", "(([01]?[0-9]?[0-9])|(2[0-4][0-9])|(25[0-5]))\\.(([01]?[0-9]?[0-9])|(2[0-4][0-9])|(" +
        "25[0-5]))\\.(([01]?[0-9]?[0-9])|(2[0-4][0-9])|(25[0-5]))\\.(([01]?[0-9]?[0-9])|(2[" +
        "0-4][0-9])|(25[0-5]))");
            this.txtDireccionIP.Properties.MaxLength = 15;
            this.txtDireccionIP.Size = new System.Drawing.Size(180, 24);
            this.txtDireccionIP.TabIndex = 2;
            this.txtDireccionIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccionIP_KeyPress);
            // 
            // lblDireccionIP
            // 
            this.lblDireccionIP.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionIP.Appearance.Options.UseFont = true;
            this.lblDireccionIP.Location = new System.Drawing.Point(304, 45);
            this.lblDireccionIP.Name = "lblDireccionIP";
            this.lblDireccionIP.Size = new System.Drawing.Size(81, 18);
            this.lblDireccionIP.TabIndex = 2;
            this.lblDireccionIP.Text = "Direccion IP:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.MaxLength = 49;
            this.txtNombre.Properties.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(180, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Appearance.Options.UseFont = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmEditarTopologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 418);
            this.Controls.Add(this.gcRedPacks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEditarTopologia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPOLOGIAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditarTopologia_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gcRedPacks)).EndInit();
            this.gcRedPacks.ResumeLayout(false);
            this.gcRedPacks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcHosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvHosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcVLSM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVLSM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnRedes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcRedPacks;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnCalcularVLSM;
        private DevExpress.XtraGrid.GridControl gdcHosts;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvHosts;
        private DevExpress.XtraGrid.GridControl gdcVLSM;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvVLSM;
        private DevExpress.XtraEditors.DateEdit dteFecha;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.SpinEdit spnRedes;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDireccionIP;
        private DevExpress.XtraEditors.LabelControl lblDireccionIP;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl lblNombre;
    }
}