namespace Dev_Kinder
{
    partial class frmEditarPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarPagos));
            this.btnConsulta = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCedula = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gpcDatosPa = new DevExpress.XtraEditors.GroupControl();
            this.btnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.lblTipo = new DevExpress.XtraEditors.LabelControl();
            this.lblMes = new DevExpress.XtraEditors.LabelControl();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.lblMonto = new DevExpress.XtraEditors.LabelControl();
            this.txtEditTipo = new DevExpress.XtraEditors.LookUpEdit();
            this.tbltipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_kinder2 = new Dev_Kinder.db_kinder2();
            this.dttFecha = new DevExpress.XtraEditors.DateEdit();
            this.txtEditMes = new DevExpress.XtraEditors.LookUpEdit();
            this.tblmesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcpConsultar = new DevExpress.XtraEditors.GroupControl();
            this.tbltipoTableAdapter = new Dev_Kinder.db_kinder2TableAdapters.tbltipoTableAdapter();
            this.tblmesTableAdapter = new Dev_Kinder.db_kinder2TableAdapters.tblmesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcDatosPa)).BeginInit();
            this.gpcDatosPa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConsulta.AppearanceHovered.Options.UseBackColor = true;
            this.btnConsulta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnConsulta.Location = new System.Drawing.Point(223, 41);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(92, 37);
            this.btnConsulta.TabIndex = 53;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(455, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 18);
            this.labelControl3.TabIndex = 50;
            // 
            // txtCedula
            // 
            this.txtCedula.EnterMoveNextControl = true;
            this.txtCedula.Location = new System.Drawing.Point(82, 49);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtCedula.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCedula.Properties.Mask.EditMask = "d";
            this.txtCedula.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCedula.Size = new System.Drawing.Size(100, 22);
            this.txtCedula.TabIndex = 52;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(26, 49);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 18);
            this.labelControl6.TabIndex = 51;
            this.labelControl6.Text = "Codigo";
            // 
            // gpcDatosPa
            // 
            this.gpcDatosPa.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcDatosPa.AppearanceCaption.ForeColor = System.Drawing.Color.LavenderBlush;
            this.gpcDatosPa.AppearanceCaption.Options.UseFont = true;
            this.gpcDatosPa.AppearanceCaption.Options.UseForeColor = true;
            this.gpcDatosPa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gpcDatosPa.Controls.Add(this.btnLimpiar);
            this.gpcDatosPa.Controls.Add(this.btnModificar);
            this.gpcDatosPa.Controls.Add(this.lblTipo);
            this.gpcDatosPa.Controls.Add(this.lblMes);
            this.gpcDatosPa.Controls.Add(this.lblFecha);
            this.gpcDatosPa.Controls.Add(this.txtMonto);
            this.gpcDatosPa.Controls.Add(this.lblMonto);
            this.gpcDatosPa.Controls.Add(this.txtEditTipo);
            this.gpcDatosPa.Controls.Add(this.dttFecha);
            this.gpcDatosPa.Controls.Add(this.txtEditMes);
            this.gpcDatosPa.Enabled = false;
            this.gpcDatosPa.Location = new System.Drawing.Point(12, 104);
            this.gpcDatosPa.Name = "gpcDatosPa";
            this.gpcDatosPa.Size = new System.Drawing.Size(624, 197);
            this.gpcDatosPa.TabIndex = 54;
            this.gpcDatosPa.Text = "Datos A Modificar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.AppearanceHovered.Options.UseBackColor = true;
            this.btnLimpiar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(211, 149);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 37);
            this.btnLimpiar.TabIndex = 47;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModificar.AppearanceHovered.Options.UseBackColor = true;
            this.btnModificar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(342, 149);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 37);
            this.btnModificar.TabIndex = 46;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblTipo.Appearance.Options.UseFont = true;
            this.lblTipo.Enabled = false;
            this.lblTipo.Location = new System.Drawing.Point(354, 45);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 18);
            this.lblTipo.TabIndex = 20;
            this.lblTipo.Text = "Tipo";
            // 
            // lblMes
            // 
            this.lblMes.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMes.Appearance.Options.UseFont = true;
            this.lblMes.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblMes.Enabled = false;
            this.lblMes.Location = new System.Drawing.Point(11, 91);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 18);
            this.lblMes.TabIndex = 37;
            this.lblMes.Text = "Mes";
            // 
            // lblFecha
            // 
            this.lblFecha.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblFecha.Appearance.Options.UseFont = true;
            this.lblFecha.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblFecha.Enabled = false;
            this.lblFecha.Location = new System.Drawing.Point(342, 92);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(39, 18);
            this.lblFecha.TabIndex = 38;
            this.lblFecha.Text = "Fecha";
            // 
            // txtMonto
            // 
            this.txtMonto.EditValue = "";
            this.txtMonto.Enabled = false;
            this.txtMonto.EnterMoveNextControl = true;
            this.txtMonto.Location = new System.Drawing.Point(58, 41);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtMonto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtMonto.Properties.Mask.EditMask = "c";
            this.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMonto.Size = new System.Drawing.Size(175, 22);
            this.txtMonto.TabIndex = 40;
            // 
            // lblMonto
            // 
            this.lblMonto.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMonto.Appearance.Options.UseFont = true;
            this.lblMonto.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblMonto.Enabled = false;
            this.lblMonto.Location = new System.Drawing.Point(11, 45);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(41, 18);
            this.lblMonto.TabIndex = 39;
            this.lblMonto.Text = "Monto";
            // 
            // txtEditTipo
            // 
            this.txtEditTipo.Location = new System.Drawing.Point(388, 42);
            this.txtEditTipo.Name = "txtEditTipo";
            this.txtEditTipo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtEditTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEditTipo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "Tipo", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("monto_tipo", "Monto", 28, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtEditTipo.Properties.DataSource = this.tbltipoBindingSource;
            this.txtEditTipo.Properties.DisplayMember = "tipo";
            this.txtEditTipo.Properties.NullText = "";
            this.txtEditTipo.Properties.ValueMember = "cod_tipo";
            this.txtEditTipo.Size = new System.Drawing.Size(176, 22);
            this.txtEditTipo.TabIndex = 25;
            // 
            // tbltipoBindingSource
            // 
            this.tbltipoBindingSource.DataMember = "tbltipo";
            this.tbltipoBindingSource.DataSource = this.db_kinder2;
            // 
            // db_kinder2
            // 
            this.db_kinder2.DataSetName = "db_kinder2";
            this.db_kinder2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dttFecha
            // 
            this.dttFecha.EditValue = null;
            this.dttFecha.Location = new System.Drawing.Point(388, 89);
            this.dttFecha.Name = "dttFecha";
            this.dttFecha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.dttFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dttFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dttFecha.Properties.DisplayFormat.FormatString = "";
            this.dttFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dttFecha.Properties.EditFormat.FormatString = "";
            this.dttFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dttFecha.Size = new System.Drawing.Size(176, 22);
            this.dttFecha.TabIndex = 43;
            // 
            // txtEditMes
            // 
            this.txtEditMes.Location = new System.Drawing.Point(44, 90);
            this.txtEditMes.Name = "txtEditMes";
            this.txtEditMes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtEditMes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEditMes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("mes", "Mes", 29, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtEditMes.Properties.DataSource = this.tblmesBindingSource;
            this.txtEditMes.Properties.DisplayMember = "mes";
            this.txtEditMes.Properties.NullText = "";
            this.txtEditMes.Properties.ValueMember = "cod_mes";
            this.txtEditMes.Size = new System.Drawing.Size(189, 22);
            this.txtEditMes.TabIndex = 44;
            // 
            // tblmesBindingSource
            // 
            this.tblmesBindingSource.DataMember = "tblmes";
            this.tblmesBindingSource.DataSource = this.db_kinder2;
            // 
            // gcpConsultar
            // 
            this.gcpConsultar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcpConsultar.Appearance.Options.UseFont = true;
            this.gcpConsultar.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gcpConsultar.AppearanceCaption.ForeColor = System.Drawing.Color.LavenderBlush;
            this.gcpConsultar.AppearanceCaption.Options.UseFont = true;
            this.gcpConsultar.AppearanceCaption.Options.UseForeColor = true;
            this.gcpConsultar.Location = new System.Drawing.Point(12, 12);
            this.gcpConsultar.Name = "gcpConsultar";
            this.gcpConsultar.Size = new System.Drawing.Size(624, 85);
            this.gcpConsultar.TabIndex = 55;
            this.gcpConsultar.Text = "Consultar Registro";
            // 
            // tbltipoTableAdapter
            // 
            this.tbltipoTableAdapter.ClearBeforeFill = true;
            // 
            // tblmesTableAdapter
            // 
            this.tblmesTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 312);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.gpcDatosPa);
            this.Controls.Add(this.gcpConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditarPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Pagos";
            this.Load += new System.EventHandler(this.frmEditarPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcDatosPa)).EndInit();
            this.gpcDatosPa.ResumeLayout(false);
            this.gpcDatosPa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnConsulta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCedula;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl gpcDatosPa;
        private DevExpress.XtraEditors.SimpleButton btnLimpiar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.LabelControl lblTipo;
        private DevExpress.XtraEditors.LabelControl lblMes;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private DevExpress.XtraEditors.LabelControl lblMonto;
        private DevExpress.XtraEditors.LookUpEdit txtEditTipo;
        private DevExpress.XtraEditors.DateEdit dttFecha;
        private DevExpress.XtraEditors.LookUpEdit txtEditMes;
        private DevExpress.XtraEditors.GroupControl gcpConsultar;
        private db_kinder2 db_kinder2;
        private System.Windows.Forms.BindingSource tbltipoBindingSource;
        private db_kinder2TableAdapters.tbltipoTableAdapter tbltipoTableAdapter;
        private System.Windows.Forms.BindingSource tblmesBindingSource;
        private db_kinder2TableAdapters.tblmesTableAdapter tblmesTableAdapter;
    }
}