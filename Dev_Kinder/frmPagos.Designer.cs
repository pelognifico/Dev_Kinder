namespace Dev_Kinder
{
    partial class frmPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagos));
            this.btnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.btnConsulta = new DevExpress.XtraEditors.SimpleButton();
            this.btnPagar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCedula = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblTipo = new DevExpress.XtraEditors.LabelControl();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.txtComprobante = new DevExpress.XtraEditors.TextEdit();
            this.lblMes = new DevExpress.XtraEditors.LabelControl();
            this.lblComprobante = new DevExpress.XtraEditors.LabelControl();
            this.gpcDatosPa = new DevExpress.XtraEditors.GroupControl();
            this.lueTipo = new DevExpress.XtraEditors.LookUpEdit();
            this.tbltipoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_kinder2 = new Dev_Kinder.db_kinder2();
            this.dtiFechaPa = new DevExpress.XtraEditors.DateEdit();
            this.lblMonto = new DevExpress.XtraEditors.LabelControl();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.lueMes = new DevExpress.XtraEditors.LookUpEdit();
            this.tblmesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbltipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblmesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcpConsultar = new DevExpress.XtraEditors.GroupControl();
            this.lblNombreRepre = new DevExpress.XtraEditors.LabelControl();
            this.tbltipoTableAdapter1 = new Dev_Kinder.db_kinder2TableAdapters.tbltipoTableAdapter();
            this.tblmesTableAdapter1 = new Dev_Kinder.db_kinder2TableAdapters.tblmesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprobante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcDatosPa)).BeginInit();
            this.gpcDatosPa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiFechaPa.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiFechaPa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpConsultar)).BeginInit();
            this.gcpConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.AppearanceHovered.Options.UseBackColor = true;
            this.btnLimpiar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(190, 193);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 37);
            this.btnLimpiar.TabIndex = 47;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConsulta.AppearanceHovered.Options.UseBackColor = true;
            this.btnConsulta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnConsulta.Location = new System.Drawing.Point(223, 41);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(92, 37);
            this.btnConsulta.TabIndex = 45;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPagar.AppearanceHovered.Options.UseBackColor = true;
            this.btnPagar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnPagar.Enabled = false;
            this.btnPagar.Location = new System.Drawing.Point(342, 193);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(92, 37);
            this.btnPagar.TabIndex = 46;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(455, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 18);
            this.labelControl3.TabIndex = 34;
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
            this.txtCedula.TabIndex = 41;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(26, 49);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 18);
            this.labelControl6.TabIndex = 35;
            this.labelControl6.Text = "Cedula";
            // 
            // lblTipo
            // 
            this.lblTipo.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblTipo.Appearance.Options.UseFont = true;
            this.lblTipo.Enabled = false;
            this.lblTipo.Location = new System.Drawing.Point(17, 88);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(86, 18);
            this.lblTipo.TabIndex = 36;
            this.lblTipo.Text = "Tipo de pago";
            // 
            // lblFecha
            // 
            this.lblFecha.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblFecha.Appearance.Options.UseFont = true;
            this.lblFecha.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblFecha.Enabled = false;
            this.lblFecha.Location = new System.Drawing.Point(317, 138);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(76, 18);
            this.lblFecha.TabIndex = 37;
            this.lblFecha.Text = "Fecha Pago";
            // 
            // txtComprobante
            // 
            this.txtComprobante.EditValue = "";
            this.txtComprobante.Enabled = false;
            this.txtComprobante.EnterMoveNextControl = true;
            this.txtComprobante.Location = new System.Drawing.Point(117, 40);
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtComprobante.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtComprobante.Properties.Mask.EditMask = "d";
            this.txtComprobante.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtComprobante.Size = new System.Drawing.Size(135, 22);
            this.txtComprobante.TabIndex = 40;
            // 
            // lblMes
            // 
            this.lblMes.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMes.Appearance.Options.UseFont = true;
            this.lblMes.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblMes.Enabled = false;
            this.lblMes.Location = new System.Drawing.Point(29, 242);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(82, 18);
            this.lblMes.TabIndex = 38;
            this.lblMes.Text = "Mes a pagar";
            // 
            // lblComprobante
            // 
            this.lblComprobante.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblComprobante.Appearance.Options.UseFont = true;
            this.lblComprobante.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblComprobante.Enabled = false;
            this.lblComprobante.Location = new System.Drawing.Point(29, 144);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(88, 18);
            this.lblComprobante.TabIndex = 39;
            this.lblComprobante.Text = "Comprobante";
            // 
            // gpcDatosPa
            // 
            this.gpcDatosPa.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcDatosPa.AppearanceCaption.ForeColor = System.Drawing.Color.LavenderBlush;
            this.gpcDatosPa.AppearanceCaption.Options.UseFont = true;
            this.gpcDatosPa.AppearanceCaption.Options.UseForeColor = true;
            this.gpcDatosPa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gpcDatosPa.Controls.Add(this.btnLimpiar);
            this.gpcDatosPa.Controls.Add(this.lueTipo);
            this.gpcDatosPa.Controls.Add(this.dtiFechaPa);
            this.gpcDatosPa.Controls.Add(this.btnPagar);
            this.gpcDatosPa.Controls.Add(this.lblMonto);
            this.gpcDatosPa.Controls.Add(this.txtMonto);
            this.gpcDatosPa.Controls.Add(this.txtComprobante);
            this.gpcDatosPa.Controls.Add(this.lblTipo);
            this.gpcDatosPa.Controls.Add(this.lblFecha);
            this.gpcDatosPa.Controls.Add(this.lueMes);
            this.gpcDatosPa.Enabled = false;
            this.gpcDatosPa.Location = new System.Drawing.Point(12, 104);
            this.gpcDatosPa.Name = "gpcDatosPa";
            this.gpcDatosPa.Size = new System.Drawing.Size(624, 244);
            this.gpcDatosPa.TabIndex = 48;
            this.gpcDatosPa.Text = "Datos del pago";
            // 
            // lueTipo
            // 
            this.lueTipo.Enabled = false;
            this.lueTipo.Location = new System.Drawing.Point(117, 89);
            this.lueTipo.Name = "lueTipo";
            this.lueTipo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lueTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTipo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "Tipo", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("monto_tipo", "Monto", 28, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueTipo.Properties.DataSource = this.tbltipoBindingSource1;
            this.lueTipo.Properties.DisplayMember = "tipo";
            this.lueTipo.Properties.ValueMember = "cod_tipo";
            this.lueTipo.Size = new System.Drawing.Size(135, 22);
            this.lueTipo.TabIndex = 44;
            // 
            // tbltipoBindingSource1
            // 
            this.tbltipoBindingSource1.DataMember = "tbltipo";
            this.tbltipoBindingSource1.DataSource = this.db_kinder2;
            // 
            // db_kinder2
            // 
            this.db_kinder2.DataSetName = "db_kinder2";
            this.db_kinder2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtiFechaPa
            // 
            this.dtiFechaPa.EditValue = null;
            this.dtiFechaPa.Enabled = false;
            this.dtiFechaPa.Location = new System.Drawing.Point(400, 138);
            this.dtiFechaPa.Name = "dtiFechaPa";
            this.dtiFechaPa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.dtiFechaPa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtiFechaPa.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dtiFechaPa.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtiFechaPa.Size = new System.Drawing.Size(115, 22);
            this.dtiFechaPa.TabIndex = 43;
            // 
            // lblMonto
            // 
            this.lblMonto.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMonto.Appearance.Options.UseFont = true;
            this.lblMonto.Enabled = false;
            this.lblMonto.Location = new System.Drawing.Point(317, 40);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(41, 18);
            this.lblMonto.TabIndex = 20;
            this.lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.EnterMoveNextControl = true;
            this.txtMonto.Location = new System.Drawing.Point(364, 40);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtMonto.Properties.Mask.EditMask = "c";
            this.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMonto.Size = new System.Drawing.Size(126, 22);
            this.txtMonto.TabIndex = 25;
            // 
            // lueMes
            // 
            this.lueMes.Enabled = false;
            this.lueMes.Location = new System.Drawing.Point(117, 137);
            this.lueMes.Name = "lueMes";
            this.lueMes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lueMes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMes.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lueMes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("mes", "Mes", 29, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueMes.Properties.DataSource = this.tblmesBindingSource1;
            this.lueMes.Properties.DisplayMember = "mes";
            this.lueMes.Properties.NullText = "";
            this.lueMes.Properties.PopupSizeable = false;
            this.lueMes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueMes.Properties.ValueMember = "cod_mes";
            this.lueMes.Size = new System.Drawing.Size(135, 22);
            this.lueMes.TabIndex = 42;
            // 
            // tblmesBindingSource1
            // 
            this.tblmesBindingSource1.DataMember = "tblmes";
            this.tblmesBindingSource1.DataSource = this.db_kinder2;
            // 
            // tbltipoBindingSource
            // 
            this.tbltipoBindingSource.DataMember = "tbltipo";
            // 
            // tblmesBindingSource
            // 
            this.tblmesBindingSource.DataMember = "tblmes";
            // 
            // gcpConsultar
            // 
            this.gcpConsultar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcpConsultar.Appearance.Options.UseFont = true;
            this.gcpConsultar.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gcpConsultar.AppearanceCaption.ForeColor = System.Drawing.Color.LavenderBlush;
            this.gcpConsultar.AppearanceCaption.Options.UseFont = true;
            this.gcpConsultar.AppearanceCaption.Options.UseForeColor = true;
            this.gcpConsultar.Controls.Add(this.lblNombreRepre);
            this.gcpConsultar.Location = new System.Drawing.Point(12, 12);
            this.gcpConsultar.Name = "gcpConsultar";
            this.gcpConsultar.Size = new System.Drawing.Size(624, 85);
            this.gcpConsultar.TabIndex = 49;
            this.gcpConsultar.Text = "Consultar Registro";
            // 
            // lblNombreRepre
            // 
            this.lblNombreRepre.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRepre.Appearance.Options.UseFont = true;
            this.lblNombreRepre.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblNombreRepre.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblNombreRepre.LineVisible = true;
            this.lblNombreRepre.Location = new System.Drawing.Point(426, 39);
            this.lblNombreRepre.Name = "lblNombreRepre";
            this.lblNombreRepre.Size = new System.Drawing.Size(64, 19);
            this.lblNombreRepre.TabIndex = 0;
            this.lblNombreRepre.Text = "Nombre";
            this.lblNombreRepre.Visible = false;
            // 
            // tbltipoTableAdapter1
            // 
            this.tbltipoTableAdapter1.ClearBeforeFill = true;
            // 
            // tblmesTableAdapter1
            // 
            this.tblmesTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 355);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblComprobante);
            this.Controls.Add(this.gpcDatosPa);
            this.Controls.Add(this.gcpConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Pagos";
            this.Load += new System.EventHandler(this.frmPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprobante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcDatosPa)).EndInit();
            this.gpcDatosPa.ResumeLayout(false);
            this.gpcDatosPa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiFechaPa.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiFechaPa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpConsultar)).EndInit();
            this.gcpConsultar.ResumeLayout(false);
            this.gcpConsultar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLimpiar;
        private DevExpress.XtraEditors.SimpleButton btnConsulta;
        private DevExpress.XtraEditors.SimpleButton btnPagar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCedula;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblTipo;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.TextEdit txtComprobante;
        private DevExpress.XtraEditors.LabelControl lblMes;
        private DevExpress.XtraEditors.LabelControl lblComprobante;
        private DevExpress.XtraEditors.GroupControl gpcDatosPa;
        private DevExpress.XtraEditors.LabelControl lblMonto;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private DevExpress.XtraEditors.GroupControl gcpConsultar;
        private DevExpress.XtraEditors.DateEdit dtiFechaPa;
        private DevExpress.XtraEditors.LookUpEdit lueTipo;
        //private db_kinderDataSet db_kinderDataSet;
        private System.Windows.Forms.BindingSource tbltipoBindingSource;
        //private db_kinderDataSetTableAdapters.tbltipoTableAdapter tbltipoTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lueMes;
        private System.Windows.Forms.BindingSource tblmesBindingSource;
        //private db_kinderDataSetTableAdapters.tblmesTableAdapter tblmesTableAdapter;
        private db_kinder2 db_kinder2;
        private System.Windows.Forms.BindingSource tbltipoBindingSource1;
        private db_kinder2TableAdapters.tbltipoTableAdapter tbltipoTableAdapter1;
        private System.Windows.Forms.BindingSource tblmesBindingSource1;
        private db_kinder2TableAdapters.tblmesTableAdapter tblmesTableAdapter1;
        private DevExpress.XtraEditors.LabelControl lblNombreRepre;
    }
}