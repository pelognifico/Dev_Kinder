namespace Dev_Kinder
{
    partial class frmControlUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlUser));
            this.gpcOpciones = new DevExpress.XtraEditors.GroupControl();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sPConsultaUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_kinder2 = new Dev_Kinder.db_kinder2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_Consulta_UsersTableAdapter = new Dev_Kinder.db_kinder2TableAdapters.SP_Consulta_UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gpcOpciones)).BeginInit();
            this.gpcOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPConsultaUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcOpciones
            // 
            this.gpcOpciones.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpcOpciones.Appearance.Options.UseBackColor = true;
            this.gpcOpciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpcOpciones.Controls.Add(this.btnEliminar);
            this.gpcOpciones.Controls.Add(this.btnAgregar);
            this.gpcOpciones.Location = new System.Drawing.Point(12, 12);
            this.gpcOpciones.Name = "gpcOpciones";
            this.gpcOpciones.Size = new System.Drawing.Size(626, 66);
            this.gpcOpciones.TabIndex = 2;
            this.gpcOpciones.Text = "Opciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEliminar.AppearanceHovered.Options.UseBackColor = true;
            this.btnEliminar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(125, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 36);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "F4 Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregar.AppearanceHovered.Options.UseBackColor = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(5, 20);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 36);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "F2 Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sPConsultaUsersBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 84);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(626, 337);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sPConsultaUsersBindingSource
            // 
            this.sPConsultaUsersBindingSource.DataMember = "SP_Consulta_Users";
            this.sPConsultaUsersBindingSource.DataSource = this.db_kinder2;
            // 
            // db_kinder2
            // 
            this.db_kinder2.DataSetName = "db_kinder2";
            this.db_kinder2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnombre,
            this.colusername,
            this.colpassword,
            this.coltipo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 55;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 157;
            // 
            // colusername
            // 
            this.colusername.Caption = "UserName";
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.Visible = true;
            this.colusername.VisibleIndex = 2;
            this.colusername.Width = 157;
            // 
            // colpassword
            // 
            this.colpassword.Caption = "Contraseña";
            this.colpassword.FieldName = "password";
            this.colpassword.Name = "colpassword";
            this.colpassword.Visible = true;
            this.colpassword.VisibleIndex = 3;
            this.colpassword.Width = 157;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 4;
            this.coltipo.Width = 163;
            // 
            // sP_Consulta_UsersTableAdapter
            // 
            this.sP_Consulta_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // frmControlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 433);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gpcOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmControlUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Usuarios";
            this.Load += new System.EventHandler(this.frmControlUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcOpciones)).EndInit();
            this.gpcOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPConsultaUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpcOpciones;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private db_kinder2 db_kinder2;
        private System.Windows.Forms.BindingSource sPConsultaUsersBindingSource;
        private db_kinder2TableAdapters.SP_Consulta_UsersTableAdapter sP_Consulta_UsersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colpassword;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
    }
}