namespace Dev_Kinder
{
    partial class frmReportesUser
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesUser));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sPConsultaPagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_kinder2 = new Dev_Kinder.db_kinder2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcod_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_representante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colape_representante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gpcOpciones = new DevExpress.XtraEditors.GroupControl();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.sP_Consulta_PagosTableAdapter = new Dev_Kinder.db_kinder2TableAdapters.SP_Consulta_PagosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPConsultaPagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcOpciones)).BeginInit();
            this.gpcOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sPConsultaPagosBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(12, 84);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(893, 395);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sPConsultaPagosBindingSource
            // 
            this.sPConsultaPagosBindingSource.DataMember = "SP_Consulta_Pagos";
            this.sPConsultaPagosBindingSource.DataSource = this.db_kinder2;
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
            this.colcod_pago,
            this.colnom_representante,
            this.colape_representante,
            this.colmonto_pago,
            this.coltipo,
            this.colmes,
            this.colfecha_pago});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            // 
            // colcod_pago
            // 
            this.colcod_pago.Caption = "Codigo";
            this.colcod_pago.FieldName = "cod_pago";
            this.colcod_pago.Name = "colcod_pago";
            this.colcod_pago.Visible = true;
            this.colcod_pago.VisibleIndex = 0;
            this.colcod_pago.Width = 64;
            // 
            // colnom_representante
            // 
            this.colnom_representante.Caption = "Nombre";
            this.colnom_representante.FieldName = "nom_representante";
            this.colnom_representante.Name = "colnom_representante";
            this.colnom_representante.Visible = true;
            this.colnom_representante.VisibleIndex = 1;
            this.colnom_representante.Width = 132;
            // 
            // colape_representante
            // 
            this.colape_representante.Caption = "Apellido";
            this.colape_representante.FieldName = "ape_representante";
            this.colape_representante.Name = "colape_representante";
            this.colape_representante.Visible = true;
            this.colape_representante.VisibleIndex = 2;
            this.colape_representante.Width = 132;
            // 
            // colmonto_pago
            // 
            this.colmonto_pago.Caption = "Monto";
            this.colmonto_pago.FieldName = "monto_pago";
            this.colmonto_pago.Name = "colmonto_pago";
            this.colmonto_pago.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "monto_pago", "SUMA={0:#.##}")});
            this.colmonto_pago.Visible = true;
            this.colmonto_pago.VisibleIndex = 3;
            this.colmonto_pago.Width = 92;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 4;
            this.coltipo.Width = 207;
            // 
            // colmes
            // 
            this.colmes.Caption = "Mes";
            this.colmes.FieldName = "mes";
            this.colmes.Name = "colmes";
            this.colmes.Visible = true;
            this.colmes.VisibleIndex = 5;
            this.colmes.Width = 93;
            // 
            // colfecha_pago
            // 
            this.colfecha_pago.Caption = "Fecha";
            this.colfecha_pago.FieldName = "fecha_pago";
            this.colfecha_pago.Name = "colfecha_pago";
            this.colfecha_pago.Visible = true;
            this.colfecha_pago.VisibleIndex = 6;
            this.colfecha_pago.Width = 152;
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
            this.gpcOpciones.TabIndex = 4;
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
            // sP_Consulta_PagosTableAdapter
            // 
            this.sP_Consulta_PagosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportesUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 491);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gpcOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportesUser";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmReportesUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPConsultaPagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcOpciones)).EndInit();
            this.gpcOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_pago;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_representante;
        private DevExpress.XtraGrid.Columns.GridColumn colape_representante;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_pago;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colmes;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_pago;
        private DevExpress.XtraEditors.GroupControl gpcOpciones;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private db_kinder2 db_kinder2;
        private System.Windows.Forms.BindingSource sPConsultaPagosBindingSource;
        private db_kinder2TableAdapters.SP_Consulta_PagosTableAdapter sP_Consulta_PagosTableAdapter;
    }
}