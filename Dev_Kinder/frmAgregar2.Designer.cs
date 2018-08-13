namespace Dev_Kinder
{
    partial class frmAgregar2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar2));
            this.btnConsulta = new DevExpress.XtraEditors.SimpleButton();
            this.txtCedula = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gcpConsultar = new DevExpress.XtraEditors.GroupControl();
            this.txtNombreA = new DevExpress.XtraEditors.TextEdit();
            this.btnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.txtApellidoA = new DevExpress.XtraEditors.TextEdit();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.lblNombreA = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaNa = new DevExpress.XtraEditors.LabelControl();
            this.dtiNacimiento = new DevExpress.XtraEditors.DateEdit();
            this.lblApellidoA = new DevExpress.XtraEditors.LabelControl();
            this.lblNivel = new DevExpress.XtraEditors.LabelControl();
            this.lblEdad = new DevExpress.XtraEditors.LabelControl();
            this.txtEdad = new DevExpress.XtraEditors.TextEdit();
            this.gpcDatosAl = new DevExpress.XtraEditors.GroupControl();
            this.cbxNiveles = new DevExpress.XtraEditors.LookUpEdit();
            this.tblnivelesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_kinder2 = new Dev_Kinder.db_kinder2();
            this.tblnivelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblnivelesTableAdapter1 = new Dev_Kinder.db_kinder2TableAdapters.tblnivelesTableAdapter();
            this.lblNombreRepre = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpConsultar)).BeginInit();
            this.gcpConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidoA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNacimiento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNacimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcDatosAl)).BeginInit();
            this.gpcDatosAl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNiveles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblnivelesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblnivelesBindingSource)).BeginInit();
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
            this.btnConsulta.TabIndex = 36;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
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
            this.txtCedula.TabIndex = 35;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(26, 49);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 18);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Cedula";
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
            this.gcpConsultar.TabIndex = 37;
            this.gcpConsultar.Text = "Consultar Representante";
            // 
            // txtNombreA
            // 
            this.txtNombreA.Enabled = false;
            this.txtNombreA.EnterMoveNextControl = true;
            this.txtNombreA.Location = new System.Drawing.Point(101, 32);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtNombreA.Size = new System.Drawing.Size(135, 22);
            this.txtNombreA.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.AppearanceHovered.Options.UseBackColor = true;
            this.btnLimpiar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(202, 141);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 37);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            // 
            // txtApellidoA
            // 
            this.txtApellidoA.Enabled = false;
            this.txtApellidoA.EnterMoveNextControl = true;
            this.txtApellidoA.Location = new System.Drawing.Point(315, 32);
            this.txtApellidoA.Name = "txtApellidoA";
            this.txtApellidoA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtApellidoA.Size = new System.Drawing.Size(126, 22);
            this.txtApellidoA.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregar.AppearanceHovered.Options.UseBackColor = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(331, 141);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 37);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombreA
            // 
            this.lblNombreA.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblNombreA.Appearance.Options.UseFont = true;
            this.lblNombreA.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblNombreA.Enabled = false;
            this.lblNombreA.Location = new System.Drawing.Point(32, 36);
            this.lblNombreA.Name = "lblNombreA";
            this.lblNombreA.Size = new System.Drawing.Size(59, 18);
            this.lblNombreA.TabIndex = 0;
            this.lblNombreA.Text = "Nombres";
            // 
            // lblFechaNa
            // 
            this.lblFechaNa.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblFechaNa.Appearance.Options.UseFont = true;
            this.lblFechaNa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblFechaNa.Enabled = false;
            this.lblFechaNa.Location = new System.Drawing.Point(32, 90);
            this.lblFechaNa.Name = "lblFechaNa";
            this.lblFechaNa.Size = new System.Drawing.Size(134, 18);
            this.lblFechaNa.TabIndex = 0;
            this.lblFechaNa.Text = "Fecha de nacimiento";
            // 
            // dtiNacimiento
            // 
            this.dtiNacimiento.EditValue = null;
            this.dtiNacimiento.Enabled = false;
            this.dtiNacimiento.EnterMoveNextControl = true;
            this.dtiNacimiento.Location = new System.Drawing.Point(187, 86);
            this.dtiNacimiento.Name = "dtiNacimiento";
            this.dtiNacimiento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.dtiNacimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtiNacimiento.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.dtiNacimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtiNacimiento.Size = new System.Drawing.Size(100, 22);
            this.dtiNacimiento.TabIndex = 12;
            // 
            // lblApellidoA
            // 
            this.lblApellidoA.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblApellidoA.Appearance.Options.UseFont = true;
            this.lblApellidoA.Enabled = false;
            this.lblApellidoA.Location = new System.Drawing.Point(255, 36);
            this.lblApellidoA.Name = "lblApellidoA";
            this.lblApellidoA.Size = new System.Drawing.Size(54, 18);
            this.lblApellidoA.TabIndex = 0;
            this.lblApellidoA.Text = "Apellidos";
            // 
            // lblNivel
            // 
            this.lblNivel.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblNivel.Appearance.Options.UseFont = true;
            this.lblNivel.Enabled = false;
            this.lblNivel.Location = new System.Drawing.Point(363, 90);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(35, 18);
            this.lblNivel.TabIndex = 0;
            this.lblNivel.Text = "Nivel ";
            // 
            // lblEdad
            // 
            this.lblEdad.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblEdad.Appearance.Options.UseFont = true;
            this.lblEdad.Enabled = false;
            this.lblEdad.Location = new System.Drawing.Point(469, 36);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 18);
            this.lblEdad.TabIndex = 0;
            this.lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.EnterMoveNextControl = true;
            this.txtEdad.Location = new System.Drawing.Point(514, 32);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtEdad.Size = new System.Drawing.Size(31, 22);
            this.txtEdad.TabIndex = 11;
            // 
            // gpcDatosAl
            // 
            this.gpcDatosAl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gpcDatosAl.AppearanceCaption.ForeColor = System.Drawing.Color.LavenderBlush;
            this.gpcDatosAl.AppearanceCaption.Options.UseFont = true;
            this.gpcDatosAl.AppearanceCaption.Options.UseForeColor = true;
            this.gpcDatosAl.Controls.Add(this.txtNombreA);
            this.gpcDatosAl.Controls.Add(this.btnLimpiar);
            this.gpcDatosAl.Controls.Add(this.txtApellidoA);
            this.gpcDatosAl.Controls.Add(this.btnAgregar);
            this.gpcDatosAl.Controls.Add(this.lblNombreA);
            this.gpcDatosAl.Controls.Add(this.lblFechaNa);
            this.gpcDatosAl.Controls.Add(this.dtiNacimiento);
            this.gpcDatosAl.Controls.Add(this.lblApellidoA);
            this.gpcDatosAl.Controls.Add(this.lblNivel);
            this.gpcDatosAl.Controls.Add(this.lblEdad);
            this.gpcDatosAl.Controls.Add(this.txtEdad);
            this.gpcDatosAl.Controls.Add(this.cbxNiveles);
            this.gpcDatosAl.Enabled = false;
            this.gpcDatosAl.Location = new System.Drawing.Point(12, 103);
            this.gpcDatosAl.Name = "gpcDatosAl";
            this.gpcDatosAl.Size = new System.Drawing.Size(624, 195);
            this.gpcDatosAl.TabIndex = 38;
            this.gpcDatosAl.Text = "Datos Alumno";
            // 
            // cbxNiveles
            // 
            this.cbxNiveles.Location = new System.Drawing.Point(415, 86);
            this.cbxNiveles.Name = "cbxNiveles";
            this.cbxNiveles.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cbxNiveles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNiveles.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cbxNiveles.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nivel", "Nivel", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbxNiveles.Properties.DataSource = this.tblnivelesBindingSource1;
            this.cbxNiveles.Properties.DisplayMember = "nivel";
            this.cbxNiveles.Properties.NullText = "";
            this.cbxNiveles.Properties.PopupSizeable = false;
            this.cbxNiveles.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxNiveles.Properties.ValueMember = "cod_nivel";
            this.cbxNiveles.Size = new System.Drawing.Size(130, 22);
            this.cbxNiveles.TabIndex = 13;
            // 
            // tblnivelesBindingSource1
            // 
            this.tblnivelesBindingSource1.DataMember = "tblniveles";
            this.tblnivelesBindingSource1.DataSource = this.db_kinder2;
            // 
            // db_kinder2
            // 
            this.db_kinder2.DataSetName = "db_kinder2";
            this.db_kinder2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblnivelesBindingSource
            // 
            this.tblnivelesBindingSource.DataMember = "tblniveles";
            // 
            // tblnivelesTableAdapter1
            // 
            this.tblnivelesTableAdapter1.ClearBeforeFill = true;
            // 
            // lblNombreRepre
            // 
            this.lblNombreRepre.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRepre.Appearance.Options.UseFont = true;
            this.lblNombreRepre.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblNombreRepre.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblNombreRepre.LineVisible = true;
            this.lblNombreRepre.Location = new System.Drawing.Point(415, 37);
            this.lblNombreRepre.Name = "lblNombreRepre";
            this.lblNombreRepre.Size = new System.Drawing.Size(64, 19);
            this.lblNombreRepre.TabIndex = 1;
            this.lblNombreRepre.Text = "Nombre";
            this.lblNombreRepre.Visible = false;
            // 
            // frmAgregar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 309);
            this.Controls.Add(this.gpcDatosAl);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.gcpConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAgregar2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Alumno";
            this.Load += new System.EventHandler(this.frmAgregar2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpConsultar)).EndInit();
            this.gcpConsultar.ResumeLayout(false);
            this.gcpConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidoA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNacimiento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNacimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcDatosAl)).EndInit();
            this.gpcDatosAl.ResumeLayout(false);
            this.gpcDatosAl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNiveles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblnivelesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblnivelesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnConsulta;
        private DevExpress.XtraEditors.TextEdit txtCedula;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl gcpConsultar;
        private DevExpress.XtraEditors.TextEdit txtNombreA;
        private DevExpress.XtraEditors.SimpleButton btnLimpiar;
        private DevExpress.XtraEditors.TextEdit txtApellidoA;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.LabelControl lblNombreA;
        private DevExpress.XtraEditors.LabelControl lblFechaNa;
        private DevExpress.XtraEditors.DateEdit dtiNacimiento;
        private DevExpress.XtraEditors.LabelControl lblApellidoA;
        private DevExpress.XtraEditors.LabelControl lblNivel;
        private DevExpress.XtraEditors.LabelControl lblEdad;
        private DevExpress.XtraEditors.TextEdit txtEdad;
        private DevExpress.XtraEditors.GroupControl gpcDatosAl;
        private DevExpress.XtraEditors.LookUpEdit cbxNiveles;
        //private db_kinderDataSet db_kinderDataSet;
        private System.Windows.Forms.BindingSource tblnivelesBindingSource;
        //private db_kinderDataSetTableAdapters.tblnivelesTableAdapter tblnivelesTableAdapter;
        private db_kinder2 db_kinder2;
        private System.Windows.Forms.BindingSource tblnivelesBindingSource1;
        private db_kinder2TableAdapters.tblnivelesTableAdapter tblnivelesTableAdapter1;
        private DevExpress.XtraEditors.LabelControl lblNombreRepre;
    }
}