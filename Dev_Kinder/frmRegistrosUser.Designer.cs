namespace Dev_Kinder
{
    partial class frmRegistrosUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrosUser));
            this.gpcOpciones = new DevExpress.XtraEditors.GroupControl();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.sP_consultaGridControl = new DevExpress.XtraGrid.GridControl();
            this.sPconsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_kinder2 = new Dev_Kinder.db_kinder2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcedula_representante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_representante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colape_representante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_alumno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colape_alumno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion_representante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelcasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelmovil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_consultaTableAdapter = new Dev_Kinder.db_kinder2TableAdapters.SP_consultaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gpcOpciones)).BeginInit();
            this.gpcOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_consultaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPconsultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcOpciones
            // 
            this.gpcOpciones.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpcOpciones.Appearance.Options.UseBackColor = true;
            this.gpcOpciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpcOpciones.Controls.Add(this.btnImprimir);
            this.gpcOpciones.Controls.Add(this.btnAgregar);
            this.gpcOpciones.Location = new System.Drawing.Point(12, 12);
            this.gpcOpciones.Name = "gpcOpciones";
            this.gpcOpciones.Size = new System.Drawing.Size(893, 66);
            this.gpcOpciones.TabIndex = 3;
            this.gpcOpciones.Text = "Opciones";
            // 
            // btnImprimir
            // 
            this.btnImprimir.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnImprimir.AppearanceHovered.Options.UseBackColor = true;
            this.btnImprimir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.ImageOptions.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(125, 20);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(114, 36);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "F5 Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
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
            // sP_consultaGridControl
            // 
            this.sP_consultaGridControl.DataSource = this.sPconsultaBindingSource;
            this.sP_consultaGridControl.Location = new System.Drawing.Point(12, 84);
            this.sP_consultaGridControl.MainView = this.gridView1;
            this.sP_consultaGridControl.Name = "sP_consultaGridControl";
            this.sP_consultaGridControl.Size = new System.Drawing.Size(893, 395);
            this.sP_consultaGridControl.TabIndex = 2;
            this.sP_consultaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sPconsultaBindingSource
            // 
            this.sPconsultaBindingSource.DataMember = "SP_consulta";
            this.sPconsultaBindingSource.DataSource = this.db_kinder2;
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
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.FooterPanel.FontStyleDelta = System.Drawing.FontStyle.Italic;
            this.gridView1.AppearancePrint.FooterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcedula_representante,
            this.colnom_representante,
            this.colape_representante,
            this.colnom_alumno,
            this.colape_alumno,
            this.colnivel,
            this.coldireccion_representante,
            this.coltelcasa,
            this.coltelmovil});
            this.gridView1.GridControl = this.sP_consultaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colcedula_representante
            // 
            this.colcedula_representante.Caption = "Cedula ";
            this.colcedula_representante.FieldName = "cedula_representante";
            this.colcedula_representante.Name = "colcedula_representante";
            this.colcedula_representante.Visible = true;
            this.colcedula_representante.VisibleIndex = 0;
            this.colcedula_representante.Width = 52;
            // 
            // colnom_representante
            // 
            this.colnom_representante.Caption = "Nombre Rep.";
            this.colnom_representante.FieldName = "nom_representante";
            this.colnom_representante.Name = "colnom_representante";
            this.colnom_representante.Visible = true;
            this.colnom_representante.VisibleIndex = 1;
            this.colnom_representante.Width = 76;
            // 
            // colape_representante
            // 
            this.colape_representante.Caption = "Apellido Rep.";
            this.colape_representante.FieldName = "ape_representante";
            this.colape_representante.Name = "colape_representante";
            this.colape_representante.Visible = true;
            this.colape_representante.VisibleIndex = 2;
            this.colape_representante.Width = 76;
            // 
            // colnom_alumno
            // 
            this.colnom_alumno.Caption = "Nombre Alumno";
            this.colnom_alumno.FieldName = "nom_alumno";
            this.colnom_alumno.Name = "colnom_alumno";
            this.colnom_alumno.Visible = true;
            this.colnom_alumno.VisibleIndex = 3;
            this.colnom_alumno.Width = 76;
            // 
            // colape_alumno
            // 
            this.colape_alumno.Caption = "Apellido Alumno";
            this.colape_alumno.FieldName = "ape_alumno";
            this.colape_alumno.Name = "colape_alumno";
            this.colape_alumno.Visible = true;
            this.colape_alumno.VisibleIndex = 4;
            this.colape_alumno.Width = 76;
            // 
            // colnivel
            // 
            this.colnivel.Caption = "Nivel Curso";
            this.colnivel.FieldName = "nivel";
            this.colnivel.Name = "colnivel";
            this.colnivel.Visible = true;
            this.colnivel.VisibleIndex = 5;
            this.colnivel.Width = 76;
            // 
            // coldireccion_representante
            // 
            this.coldireccion_representante.Caption = "Direccion";
            this.coldireccion_representante.FieldName = "direccion_representante";
            this.coldireccion_representante.Name = "coldireccion_representante";
            this.coldireccion_representante.Visible = true;
            this.coldireccion_representante.VisibleIndex = 6;
            this.coldireccion_representante.Width = 84;
            // 
            // coltelcasa
            // 
            this.coltelcasa.Caption = "Telefono local";
            this.coltelcasa.FieldName = "telcasa";
            this.coltelcasa.Name = "coltelcasa";
            this.coltelcasa.Visible = true;
            this.coltelcasa.VisibleIndex = 7;
            this.coltelcasa.Width = 89;
            // 
            // coltelmovil
            // 
            this.coltelmovil.Caption = "Telefono Movil";
            this.coltelmovil.FieldName = "telmovil";
            this.coltelmovil.Name = "coltelmovil";
            this.coltelmovil.Visible = true;
            this.coltelmovil.VisibleIndex = 8;
            this.coltelmovil.Width = 87;
            // 
            // sP_consultaTableAdapter
            // 
            this.sP_consultaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRegistrosUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 491);
            this.Controls.Add(this.gpcOpciones);
            this.Controls.Add(this.sP_consultaGridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistrosUser";
            this.Text = "Ver registros";
            this.Load += new System.EventHandler(this.frmRegistrosUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcOpciones)).EndInit();
            this.gpcOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_consultaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPconsultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpcOpciones;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraGrid.GridControl sP_consultaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcedula_representante;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_representante;
        private DevExpress.XtraGrid.Columns.GridColumn colape_representante;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_alumno;
        private DevExpress.XtraGrid.Columns.GridColumn colape_alumno;
        private DevExpress.XtraGrid.Columns.GridColumn colnivel;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion_representante;
        private DevExpress.XtraGrid.Columns.GridColumn coltelcasa;
        private DevExpress.XtraGrid.Columns.GridColumn coltelmovil;
        private db_kinder2 db_kinder2;
        private System.Windows.Forms.BindingSource sPconsultaBindingSource;
        private db_kinder2TableAdapters.SP_consultaTableAdapter sP_consultaTableAdapter;
    }
}