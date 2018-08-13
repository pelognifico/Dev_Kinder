namespace Dev_Kinder
{
    partial class frmAgregarUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarUser));
            this.gpcDatosAl = new DevExpress.XtraEditors.GroupControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.btnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.lblNombreA = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaNa = new DevExpress.XtraEditors.LabelControl();
            this.lblApellidoA = new DevExpress.XtraEditors.LabelControl();
            this.lblNivel = new DevExpress.XtraEditors.LabelControl();
            this.txtEditTipo = new DevExpress.XtraEditors.LookUpEdit();
            this.tbltipousuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_kinder2 = new Dev_Kinder.db_kinder2();
            this.tbltipo_usuTableAdapter = new Dev_Kinder.db_kinder2TableAdapters.tbltipo_usuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gpcDatosAl)).BeginInit();
            this.gpcDatosAl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipousuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcDatosAl
            // 
            this.gpcDatosAl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gpcDatosAl.AppearanceCaption.ForeColor = System.Drawing.Color.LavenderBlush;
            this.gpcDatosAl.AppearanceCaption.Options.UseFont = true;
            this.gpcDatosAl.AppearanceCaption.Options.UseForeColor = true;
            this.gpcDatosAl.Controls.Add(this.txtPassword);
            this.gpcDatosAl.Controls.Add(this.txtNombre);
            this.gpcDatosAl.Controls.Add(this.btnLimpiar);
            this.gpcDatosAl.Controls.Add(this.txtUsername);
            this.gpcDatosAl.Controls.Add(this.btnAgregar);
            this.gpcDatosAl.Controls.Add(this.lblNombreA);
            this.gpcDatosAl.Controls.Add(this.lblFechaNa);
            this.gpcDatosAl.Controls.Add(this.lblApellidoA);
            this.gpcDatosAl.Controls.Add(this.lblNivel);
            this.gpcDatosAl.Controls.Add(this.txtEditTipo);
            this.gpcDatosAl.Location = new System.Drawing.Point(12, 12);
            this.gpcDatosAl.Name = "gpcDatosAl";
            this.gpcDatosAl.Size = new System.Drawing.Size(624, 227);
            this.gpcDatosAl.TabIndex = 39;
            this.gpcDatosAl.Text = "Datos del usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Location = new System.Drawing.Point(112, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtPassword.Size = new System.Drawing.Size(135, 22);
            this.txtPassword.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.EnterMoveNextControl = true;
            this.txtNombre.Location = new System.Drawing.Point(90, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtNombre.Size = new System.Drawing.Size(157, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.AppearanceHovered.Options.UseBackColor = true;
            this.btnLimpiar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnLimpiar.Location = new System.Drawing.Point(206, 176);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 37);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.EnterMoveNextControl = true;
            this.txtUsername.Location = new System.Drawing.Point(451, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtUsername.Size = new System.Drawing.Size(130, 22);
            this.txtUsername.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregar.AppearanceHovered.Options.UseBackColor = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAgregar.Location = new System.Drawing.Point(327, 176);
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
            this.lblNombreA.Location = new System.Drawing.Point(32, 51);
            this.lblNombreA.Name = "lblNombreA";
            this.lblNombreA.Size = new System.Drawing.Size(52, 18);
            this.lblNombreA.TabIndex = 0;
            this.lblNombreA.Text = "Nombre";
            // 
            // lblFechaNa
            // 
            this.lblFechaNa.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblFechaNa.Appearance.Options.UseFont = true;
            this.lblFechaNa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblFechaNa.Location = new System.Drawing.Point(32, 105);
            this.lblFechaNa.Name = "lblFechaNa";
            this.lblFechaNa.Size = new System.Drawing.Size(74, 18);
            this.lblFechaNa.TabIndex = 0;
            this.lblFechaNa.Text = "Contraseña";
            // 
            // lblApellidoA
            // 
            this.lblApellidoA.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblApellidoA.Appearance.Options.UseFont = true;
            this.lblApellidoA.Location = new System.Drawing.Point(376, 49);
            this.lblApellidoA.Name = "lblApellidoA";
            this.lblApellidoA.Size = new System.Drawing.Size(69, 18);
            this.lblApellidoA.TabIndex = 0;
            this.lblApellidoA.Text = "UserName";
            // 
            // lblNivel
            // 
            this.lblNivel.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblNivel.Appearance.Options.UseFont = true;
            this.lblNivel.Location = new System.Drawing.Point(364, 105);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(81, 18);
            this.lblNivel.TabIndex = 0;
            this.lblNivel.Text = "Tipo Usuario";
            // 
            // txtEditTipo
            // 
            this.txtEditTipo.Location = new System.Drawing.Point(451, 101);
            this.txtEditTipo.Name = "txtEditTipo";
            this.txtEditTipo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtEditTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEditTipo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtEditTipo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "Tipo", 28, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtEditTipo.Properties.DataSource = this.tbltipousuBindingSource;
            this.txtEditTipo.Properties.DisplayMember = "tipo";
            this.txtEditTipo.Properties.NullText = "";
            this.txtEditTipo.Properties.PopupSizeable = false;
            this.txtEditTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtEditTipo.Properties.ValueMember = "cod_tipo";
            this.txtEditTipo.Size = new System.Drawing.Size(130, 22);
            this.txtEditTipo.TabIndex = 13;
            // 
            // tbltipousuBindingSource
            // 
            this.tbltipousuBindingSource.DataMember = "tbltipo_usu";
            this.tbltipousuBindingSource.DataSource = this.db_kinder2;
            // 
            // db_kinder2
            // 
            this.db_kinder2.DataSetName = "db_kinder2";
            this.db_kinder2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbltipo_usuTableAdapter
            // 
            this.tbltipo_usuTableAdapter.ClearBeforeFill = true;
            // 
            // frmAgregarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 251);
            this.Controls.Add(this.gpcDatosAl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAgregarUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.frmAgregarUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcDatosAl)).EndInit();
            this.gpcDatosAl.ResumeLayout(false);
            this.gpcDatosAl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipousuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kinder2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpcDatosAl;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.SimpleButton btnLimpiar;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.LabelControl lblNombreA;
        private DevExpress.XtraEditors.LabelControl lblFechaNa;
        private DevExpress.XtraEditors.LabelControl lblApellidoA;
        private DevExpress.XtraEditors.LabelControl lblNivel;
        private DevExpress.XtraEditors.LookUpEdit txtEditTipo;
        private db_kinder2 db_kinder2;
        private System.Windows.Forms.BindingSource tbltipousuBindingSource;
        private db_kinder2TableAdapters.tbltipo_usuTableAdapter tbltipo_usuTableAdapter;
    }
}