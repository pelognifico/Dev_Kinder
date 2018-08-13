namespace Dev_Kinder
{
    partial class frmDatosAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosAl));
            this.btnConsulta = new DevExpress.XtraEditors.SimpleButton();
            this.txtCedula = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gcpConsultar = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpConsultar)).BeginInit();
            this.gcpConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConsulta.AppearanceHovered.Options.UseBackColor = true;
            this.btnConsulta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnConsulta.Location = new System.Drawing.Point(726, 33);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(92, 37);
            this.btnConsulta.TabIndex = 52;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.EnterMoveNextControl = true;
            this.txtCedula.Location = new System.Drawing.Point(585, 41);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtCedula.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCedula.Properties.Mask.EditMask = "d";
            this.txtCedula.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCedula.Size = new System.Drawing.Size(100, 22);
            this.txtCedula.TabIndex = 51;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(529, 41);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 18);
            this.labelControl6.TabIndex = 50;
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
            this.gcpConsultar.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.gcpConsultar.Controls.Add(this.btnConsulta);
            this.gcpConsultar.Controls.Add(this.txtCedula);
            this.gcpConsultar.Controls.Add(this.labelControl6);
            this.gcpConsultar.Location = new System.Drawing.Point(12, 12);
            this.gcpConsultar.Name = "gcpConsultar";
            this.gcpConsultar.Size = new System.Drawing.Size(823, 85);
            this.gcpConsultar.TabIndex = 53;
            this.gcpConsultar.Text = "Consultar Registro";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 103);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(823, 317);
            this.gridControl1.TabIndex = 54;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // frmDatosAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 432);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gcpConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDatosAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcpConsultar)).EndInit();
            this.gcpConsultar.ResumeLayout(false);
            this.gcpConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnConsulta;
        private DevExpress.XtraEditors.TextEdit txtCedula;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl gcpConsultar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}