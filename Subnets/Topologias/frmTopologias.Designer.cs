namespace Subnets.Topologias {
    partial class frmTopologias {
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
            this.btnEliminarTopologia = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditarTopologia = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevaTopologia = new DevExpress.XtraEditors.SimpleButton();
            this.lblTopologiasTabla = new DevExpress.XtraEditors.LabelControl();
            this.gdcTopologias = new DevExpress.XtraGrid.GridControl();
            this.topologiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvTopologias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidTopologia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreTopologia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupTopologias = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.topologiasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblTopologias = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).BeginInit();
            this.gcUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcTopologias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topologiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTopologias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupTopologias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topologiasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUsuarios
            // 
            this.gcUsuarios.Controls.Add(this.btnEliminarTopologia);
            this.gcUsuarios.Controls.Add(this.btnEditarTopologia);
            this.gcUsuarios.Controls.Add(this.btnNuevaTopologia);
            this.gcUsuarios.Controls.Add(this.lblTopologiasTabla);
            this.gcUsuarios.Controls.Add(this.gdcTopologias);
            this.gcUsuarios.Controls.Add(this.lblTopologias);
            this.gcUsuarios.Location = new System.Drawing.Point(12, 12);
            this.gcUsuarios.Name = "gcUsuarios";
            this.gcUsuarios.Size = new System.Drawing.Size(974, 444);
            this.gcUsuarios.TabIndex = 0;
            this.gcUsuarios.Text = "Subnets";
            // 
            // btnEliminarTopologia
            // 
            this.btnEliminarTopologia.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarTopologia.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTopologia.Appearance.Options.UseBackColor = true;
            this.btnEliminarTopologia.Appearance.Options.UseFont = true;
            this.btnEliminarTopologia.Location = new System.Drawing.Point(85, 272);
            this.btnEliminarTopologia.Name = "btnEliminarTopologia";
            this.btnEliminarTopologia.Size = new System.Drawing.Size(117, 39);
            this.btnEliminarTopologia.TabIndex = 3;
            this.btnEliminarTopologia.Text = "Eliminar topologia";
            this.btnEliminarTopologia.Click += new System.EventHandler(this.btnEliminarTopologia_Click);
            // 
            // btnEditarTopologia
            // 
            this.btnEditarTopologia.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditarTopologia.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTopologia.Appearance.Options.UseBackColor = true;
            this.btnEditarTopologia.Appearance.Options.UseFont = true;
            this.btnEditarTopologia.Location = new System.Drawing.Point(85, 217);
            this.btnEditarTopologia.Name = "btnEditarTopologia";
            this.btnEditarTopologia.Size = new System.Drawing.Size(117, 39);
            this.btnEditarTopologia.TabIndex = 2;
            this.btnEditarTopologia.Text = "Editar topologia";
            this.btnEditarTopologia.Click += new System.EventHandler(this.btnEditarTopologia_Click);
            // 
            // btnNuevaTopologia
            // 
            this.btnNuevaTopologia.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnNuevaTopologia.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaTopologia.Appearance.Options.UseBackColor = true;
            this.btnNuevaTopologia.Appearance.Options.UseFont = true;
            this.btnNuevaTopologia.Location = new System.Drawing.Point(85, 163);
            this.btnNuevaTopologia.Name = "btnNuevaTopologia";
            this.btnNuevaTopologia.Size = new System.Drawing.Size(117, 39);
            this.btnNuevaTopologia.TabIndex = 1;
            this.btnNuevaTopologia.Text = "Nueva topologia";
            this.btnNuevaTopologia.Click += new System.EventHandler(this.btnNuevaTopologia_Click);
            // 
            // lblTopologiasTabla
            // 
            this.lblTopologiasTabla.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopologiasTabla.Appearance.Options.UseFont = true;
            this.lblTopologiasTabla.Location = new System.Drawing.Point(315, 50);
            this.lblTopologiasTabla.Name = "lblTopologiasTabla";
            this.lblTopologiasTabla.Size = new System.Drawing.Size(84, 19);
            this.lblTopologiasTabla.TabIndex = 2;
            this.lblTopologiasTabla.Text = "Topologias:";
            // 
            // gdcTopologias
            // 
            this.gdcTopologias.DataSource = this.topologiasBindingSource;
            this.gdcTopologias.Location = new System.Drawing.Point(315, 75);
            this.gdcTopologias.MainView = this.gdvTopologias;
            this.gdcTopologias.Name = "gdcTopologias";
            this.gdcTopologias.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupTopologias});
            this.gdcTopologias.Size = new System.Drawing.Size(654, 364);
            this.gdcTopologias.TabIndex = 4;
            this.gdcTopologias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvTopologias});
            // 
            // topologiasBindingSource
            // 
            this.topologiasBindingSource.DataSource = typeof(BOL.Topologias);
            // 
            // gdvTopologias
            // 
            this.gdvTopologias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidTopologia,
            this.colnombreTopologia,
            this.colfecha,
            this.colidEmpresa});
            this.gdvTopologias.GridControl = this.gdcTopologias;
            this.gdvTopologias.Name = "gdvTopologias";
            this.gdvTopologias.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gdvTopologias.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gdvTopologias.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gdvTopologias.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gdvTopologias_RowClick_1);
            // 
            // colidTopologia
            // 
            this.colidTopologia.FieldName = "idTopologia";
            this.colidTopologia.Name = "colidTopologia";
            // 
            // colnombreTopologia
            // 
            this.colnombreTopologia.Caption = "Topologia";
            this.colnombreTopologia.FieldName = "nombreTopologia";
            this.colnombreTopologia.Name = "colnombreTopologia";
            this.colnombreTopologia.OptionsColumn.ReadOnly = true;
            this.colnombreTopologia.Visible = true;
            this.colnombreTopologia.VisibleIndex = 0;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            // 
            // colidEmpresa
            // 
            this.colidEmpresa.FieldName = "idEmpresa";
            this.colidEmpresa.Name = "colidEmpresa";
            // 
            // rlupTopologias
            // 
            this.rlupTopologias.AutoHeight = false;
            this.rlupTopologias.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupTopologias.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idTopologia", "id Topologia", 66, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombreTopologia", "nombre Topologia", 94, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("fecha", "fecha", 36, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idEmpresa", "id Empresa", 61, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupTopologias.DataSource = this.topologiasBindingSource1;
            this.rlupTopologias.Name = "rlupTopologias";
            // 
            // topologiasBindingSource1
            // 
            this.topologiasBindingSource1.DataSource = typeof(BOL.Topologias);
            // 
            // lblTopologias
            // 
            this.lblTopologias.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopologias.Appearance.Options.UseFont = true;
            this.lblTopologias.Location = new System.Drawing.Point(5, 26);
            this.lblTopologias.Name = "lblTopologias";
            this.lblTopologias.Size = new System.Drawing.Size(113, 29);
            this.lblTopologias.TabIndex = 0;
            this.lblTopologias.Text = "Topologias";
            // 
            // frmTopologias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 468);
            this.Controls.Add(this.gcUsuarios);
            this.Name = "frmTopologias";
            this.Text = "TOPOLOGIAS";
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).EndInit();
            this.gcUsuarios.ResumeLayout(false);
            this.gcUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcTopologias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topologiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTopologias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupTopologias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topologiasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcUsuarios;
        private DevExpress.XtraEditors.SimpleButton btnEliminarTopologia;
        private DevExpress.XtraEditors.SimpleButton btnEditarTopologia;
        private DevExpress.XtraEditors.SimpleButton btnNuevaTopologia;
        private DevExpress.XtraEditors.LabelControl lblTopologiasTabla;
        private DevExpress.XtraGrid.GridControl gdcTopologias;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvTopologias;
        private DevExpress.XtraEditors.LabelControl lblTopologias;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupTopologias;
        private System.Windows.Forms.BindingSource topologiasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidTopologia;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreTopologia;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colidEmpresa;
        private System.Windows.Forms.BindingSource topologiasBindingSource1;
    }
}