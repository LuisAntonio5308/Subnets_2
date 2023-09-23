namespace Subnets.Usuarios {
    partial class frmUsuarios {
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
            this.gcUsuarios = new DevExpress.XtraEditors.GroupControl();
            this.btnEliminarUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditarUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevoUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.lblUsuariosTabla = new DevExpress.XtraEditors.LabelControl();
            this.gdcUsuarios = new DevExpress.XtraGrid.GridControl();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnickname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontrasena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladministrador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellidoP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellidoM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccionUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreoElectronico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupUsuarios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lblUsuarios = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).BeginInit();
            this.gcUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUsuarios
            // 
            this.gcUsuarios.Controls.Add(this.btnEliminarUsuario);
            this.gcUsuarios.Controls.Add(this.btnEditarUsuario);
            this.gcUsuarios.Controls.Add(this.btnNuevoUsuario);
            this.gcUsuarios.Controls.Add(this.lblUsuariosTabla);
            this.gcUsuarios.Controls.Add(this.gdcUsuarios);
            this.gcUsuarios.Controls.Add(this.lblUsuarios);
            this.gcUsuarios.Location = new System.Drawing.Point(12, 12);
            this.gcUsuarios.Name = "gcUsuarios";
            this.gcUsuarios.Size = new System.Drawing.Size(974, 444);
            this.gcUsuarios.TabIndex = 0;
            this.gcUsuarios.Text = "Subnets";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Appearance.Options.UseBackColor = true;
            this.btnEliminarUsuario.Appearance.Options.UseFont = true;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(85, 272);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(117, 39);
            this.btnEliminarUsuario.TabIndex = 3;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditarUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.Appearance.Options.UseBackColor = true;
            this.btnEditarUsuario.Appearance.Options.UseFont = true;
            this.btnEditarUsuario.Location = new System.Drawing.Point(85, 217);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(117, 39);
            this.btnEditarUsuario.TabIndex = 2;
            this.btnEditarUsuario.Text = "Editar usuario";
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnNuevoUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.Appearance.Options.UseBackColor = true;
            this.btnNuevoUsuario.Appearance.Options.UseFont = true;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(85, 163);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(117, 39);
            this.btnNuevoUsuario.TabIndex = 1;
            this.btnNuevoUsuario.Text = "Nuevo usuario";
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // lblUsuariosTabla
            // 
            this.lblUsuariosTabla.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosTabla.Appearance.Options.UseFont = true;
            this.lblUsuariosTabla.Location = new System.Drawing.Point(292, 50);
            this.lblUsuariosTabla.Name = "lblUsuariosTabla";
            this.lblUsuariosTabla.Size = new System.Drawing.Size(67, 19);
            this.lblUsuariosTabla.TabIndex = 2;
            this.lblUsuariosTabla.Text = "Usuarios:";
            // 
            // gdcUsuarios
            // 
            this.gdcUsuarios.DataSource = this.usuariosBindingSource;
            this.gdcUsuarios.Location = new System.Drawing.Point(292, 75);
            this.gdcUsuarios.MainView = this.gdvUsuarios;
            this.gdcUsuarios.Name = "gdcUsuarios";
            this.gdcUsuarios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupUsuarios});
            this.gdcUsuarios.Size = new System.Drawing.Size(677, 364);
            this.gdcUsuarios.TabIndex = 4;
            this.gdcUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvUsuarios});
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(BOL.Usuarios);
            // 
            // gdvUsuarios
            // 
            this.gdvUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidUsuario,
            this.colnickname,
            this.colcontrasena,
            this.coladministrador,
            this.colnombre,
            this.colapellidoP,
            this.colapellidoM,
            this.coldireccionUsuario,
            this.colcorreoElectronico,
            this.coltelefono});
            this.gdvUsuarios.GridControl = this.gdcUsuarios;
            this.gdvUsuarios.Name = "gdvUsuarios";
            this.gdvUsuarios.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gdvUsuarios.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gdvUsuarios.OptionsBehavior.ReadOnly = true;
            this.gdvUsuarios.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gdvUsuarios_RowClick);
            // 
            // colidUsuario
            // 
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.Name = "colidUsuario";
            // 
            // colnickname
            // 
            this.colnickname.Caption = "Nickname";
            this.colnickname.FieldName = "nickname";
            this.colnickname.Name = "colnickname";
            this.colnickname.Visible = true;
            this.colnickname.VisibleIndex = 0;
            // 
            // colcontrasena
            // 
            this.colcontrasena.FieldName = "contrasena";
            this.colcontrasena.Name = "colcontrasena";
            // 
            // coladministrador
            // 
            this.coladministrador.Caption = "Administrador";
            this.coladministrador.FieldName = "administrador";
            this.coladministrador.Name = "coladministrador";
            this.coladministrador.Visible = true;
            this.coladministrador.VisibleIndex = 1;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 2;
            // 
            // colapellidoP
            // 
            this.colapellidoP.Caption = "1er Apellido";
            this.colapellidoP.FieldName = "apellidoP";
            this.colapellidoP.Name = "colapellidoP";
            this.colapellidoP.Visible = true;
            this.colapellidoP.VisibleIndex = 3;
            // 
            // colapellidoM
            // 
            this.colapellidoM.Caption = "2do Apellido";
            this.colapellidoM.FieldName = "apellidoM";
            this.colapellidoM.Name = "colapellidoM";
            this.colapellidoM.Visible = true;
            this.colapellidoM.VisibleIndex = 4;
            // 
            // coldireccionUsuario
            // 
            this.coldireccionUsuario.Caption = "Direccion";
            this.coldireccionUsuario.FieldName = "direccionUsuario";
            this.coldireccionUsuario.Name = "coldireccionUsuario";
            this.coldireccionUsuario.Visible = true;
            this.coldireccionUsuario.VisibleIndex = 5;
            // 
            // colcorreoElectronico
            // 
            this.colcorreoElectronico.Caption = "E-Mail";
            this.colcorreoElectronico.FieldName = "correoElectronico";
            this.colcorreoElectronico.Name = "colcorreoElectronico";
            this.colcorreoElectronico.Visible = true;
            this.colcorreoElectronico.VisibleIndex = 6;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Telefono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 7;
            // 
            // rlupUsuarios
            // 
            this.rlupUsuarios.AutoHeight = false;
            this.rlupUsuarios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupUsuarios.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idUsuario", "id Usuario", 56, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nickname", "nickname", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("contrasena", "contrasena", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("administrador", "administrador", 74, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apellidoP", "apellido P", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apellidoM", "apellido M", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccionUsuario", "direccion Usuario", 90, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("correoElectronico", "correo Electronico", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 49, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupUsuarios.DataSource = this.usuariosBindingSource;
            this.rlupUsuarios.Name = "rlupUsuarios";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Appearance.Options.UseFont = true;
            this.lblUsuarios.Location = new System.Drawing.Point(5, 26);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(91, 29);
            this.lblUsuarios.TabIndex = 0;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 468);
            this.Controls.Add(this.gcUsuarios);
            this.Name = "frmUsuarios";
            this.Text = "USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).EndInit();
            this.gcUsuarios.ResumeLayout(false);
            this.gcUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcUsuarios;
        private DevExpress.XtraEditors.SimpleButton btnEliminarUsuario;
        private DevExpress.XtraEditors.SimpleButton btnEditarUsuario;
        private DevExpress.XtraEditors.SimpleButton btnNuevoUsuario;
        private DevExpress.XtraEditors.LabelControl lblUsuariosTabla;
        private DevExpress.XtraGrid.GridControl gdcUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvUsuarios;
        private DevExpress.XtraEditors.LabelControl lblUsuarios;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colnickname;
        private DevExpress.XtraGrid.Columns.GridColumn colcontrasena;
        private DevExpress.XtraGrid.Columns.GridColumn coladministrador;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colapellidoP;
        private DevExpress.XtraGrid.Columns.GridColumn colapellidoM;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccionUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreoElectronico;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupUsuarios;
    }
}