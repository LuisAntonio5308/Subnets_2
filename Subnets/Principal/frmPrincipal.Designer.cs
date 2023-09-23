namespace Subnets {
    partial class frmPrincipal {
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
            this.components = new System.ComponentModel.Container();
            this.gcPrincipal = new DevExpress.XtraEditors.GroupControl();
            this.gdcEmpresas = new DevExpress.XtraGrid.GridControl();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvEmpresas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccionEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreoElectronico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lupeEmpresas = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnEliminarEmpresa = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditarEmpresa = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevaEmpresa = new DevExpress.XtraEditors.SimpleButton();
            this.lblEmpresas = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcPrincipal)).BeginInit();
            this.gcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupeEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPrincipal
            // 
            this.gcPrincipal.Controls.Add(this.gdcEmpresas);
            this.gcPrincipal.Controls.Add(this.btnEliminarEmpresa);
            this.gcPrincipal.Controls.Add(this.btnEditarEmpresa);
            this.gcPrincipal.Controls.Add(this.btnNuevaEmpresa);
            this.gcPrincipal.Controls.Add(this.lblEmpresas);
            this.gcPrincipal.Controls.Add(this.labelControl1);
            this.gcPrincipal.Location = new System.Drawing.Point(12, 12);
            this.gcPrincipal.Name = "gcPrincipal";
            this.gcPrincipal.Size = new System.Drawing.Size(974, 444);
            this.gcPrincipal.TabIndex = 0;
            this.gcPrincipal.Text = "Subnets";
            // 
            // gdcEmpresas
            // 
            this.gdcEmpresas.DataSource = this.empresasBindingSource;
            this.gdcEmpresas.Location = new System.Drawing.Point(288, 80);
            this.gdcEmpresas.MainView = this.gdvEmpresas;
            this.gdcEmpresas.Name = "gdcEmpresas";
            this.gdcEmpresas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lupeEmpresas});
            this.gdcEmpresas.Size = new System.Drawing.Size(686, 364);
            this.gdcEmpresas.TabIndex = 4;
            this.gdcEmpresas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvEmpresas});
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataSource = typeof(BOL.Empresas);
            // 
            // gdvEmpresas
            // 
            this.gdvEmpresas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidEmpresa,
            this.colnombreEmpresa,
            this.coldireccionEmpresa,
            this.coltelefono,
            this.colcorreoElectronico});
            this.gdvEmpresas.GridControl = this.gdcEmpresas;
            this.gdvEmpresas.Name = "gdvEmpresas";
            this.gdvEmpresas.OptionsBehavior.Editable = false;
            this.gdvEmpresas.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gdvEmpresas_RowClick);
            // 
            // colidEmpresa
            // 
            this.colidEmpresa.Caption = "EMPRESA";
            this.colidEmpresa.FieldName = "idEmpresa";
            this.colidEmpresa.Name = "colidEmpresa";
            // 
            // colnombreEmpresa
            // 
            this.colnombreEmpresa.CustomizationCaption = "NOMBRE EMPRESA";
            this.colnombreEmpresa.FieldName = "nombreEmpresa";
            this.colnombreEmpresa.Name = "colnombreEmpresa";
            this.colnombreEmpresa.Visible = true;
            this.colnombreEmpresa.VisibleIndex = 0;
            // 
            // coldireccionEmpresa
            // 
            this.coldireccionEmpresa.FieldName = "direccionEmpresa";
            this.coldireccionEmpresa.Name = "coldireccionEmpresa";
            this.coldireccionEmpresa.Visible = true;
            this.coldireccionEmpresa.VisibleIndex = 1;
            // 
            // coltelefono
            // 
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 2;
            // 
            // colcorreoElectronico
            // 
            this.colcorreoElectronico.FieldName = "correoElectronico";
            this.colcorreoElectronico.Name = "colcorreoElectronico";
            this.colcorreoElectronico.Visible = true;
            this.colcorreoElectronico.VisibleIndex = 3;
            // 
            // lupeEmpresas
            // 
            this.lupeEmpresas.AutoHeight = false;
            this.lupeEmpresas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupeEmpresas.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idEmpresa", "id Empresa", 61, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombreEmpresa", "nombre Empresa", 89, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccionEmpresa", "direccion Empresa", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 49, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("correoElectronico", "correo Electronico", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupeEmpresas.DataSource = this.empresasBindingSource;
            this.lupeEmpresas.Name = "lupeEmpresas";
            // 
            // btnEliminarEmpresa
            // 
            this.btnEliminarEmpresa.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarEmpresa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpresa.Appearance.Options.UseBackColor = true;
            this.btnEliminarEmpresa.Appearance.Options.UseFont = true;
            this.btnEliminarEmpresa.Location = new System.Drawing.Point(85, 272);
            this.btnEliminarEmpresa.Name = "btnEliminarEmpresa";
            this.btnEliminarEmpresa.Size = new System.Drawing.Size(117, 39);
            this.btnEliminarEmpresa.TabIndex = 3;
            this.btnEliminarEmpresa.Text = "Eliminar empresa";
            this.btnEliminarEmpresa.Click += new System.EventHandler(this.btnEliminarEmpresa_Click);
            // 
            // btnEditarEmpresa
            // 
            this.btnEditarEmpresa.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditarEmpresa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEmpresa.Appearance.Options.UseBackColor = true;
            this.btnEditarEmpresa.Appearance.Options.UseFont = true;
            this.btnEditarEmpresa.Location = new System.Drawing.Point(85, 217);
            this.btnEditarEmpresa.Name = "btnEditarEmpresa";
            this.btnEditarEmpresa.Size = new System.Drawing.Size(117, 39);
            this.btnEditarEmpresa.TabIndex = 2;
            this.btnEditarEmpresa.Text = "Editar empresa";
            this.btnEditarEmpresa.Click += new System.EventHandler(this.btnEditarEmpresa_Click);
            // 
            // btnNuevaEmpresa
            // 
            this.btnNuevaEmpresa.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnNuevaEmpresa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaEmpresa.Appearance.Options.UseBackColor = true;
            this.btnNuevaEmpresa.Appearance.Options.UseFont = true;
            this.btnNuevaEmpresa.Location = new System.Drawing.Point(85, 163);
            this.btnNuevaEmpresa.Name = "btnNuevaEmpresa";
            this.btnNuevaEmpresa.Size = new System.Drawing.Size(117, 39);
            this.btnNuevaEmpresa.TabIndex = 1;
            this.btnNuevaEmpresa.Text = "Nueva empresa";
            this.btnNuevaEmpresa.Click += new System.EventHandler(this.btnNuevaEmpresa_Click);
            // 
            // lblEmpresas
            // 
            this.lblEmpresas.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresas.Appearance.Options.UseFont = true;
            this.lblEmpresas.Location = new System.Drawing.Point(283, 50);
            this.lblEmpresas.Name = "lblEmpresas";
            this.lblEmpresas.Size = new System.Drawing.Size(68, 19);
            this.lblEmpresas.TabIndex = 4;
            this.lblEmpresas.Text = "Empresas";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Principal";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(BOL.Usuarios);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 468);
            this.Controls.Add(this.gcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINCIPAL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gcPrincipal)).EndInit();
            this.gcPrincipal.ResumeLayout(false);
            this.gcPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupeEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcPrincipal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnNuevaEmpresa;
        private DevExpress.XtraEditors.LabelControl lblEmpresas;
        private DevExpress.XtraEditors.SimpleButton btnEditarEmpresa;
        private DevExpress.XtraEditors.SimpleButton btnEliminarEmpresa;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private DevExpress.XtraGrid.GridControl gdcEmpresas;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvEmpresas;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lupeEmpresas;
        private DevExpress.XtraGrid.Columns.GridColumn colidEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccionEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreoElectronico;
    }
}