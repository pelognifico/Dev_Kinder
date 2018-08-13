namespace Dev_Kinder
{
    partial class frmPregunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregunta));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnRegular = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.btnRegular);
            this.groupControl1.Controls.Add(this.btnNuevo);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(389, 173);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "¿Qué desea agregar?";
            // 
            // btnRegular
            // 
            this.btnRegular.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegular.AppearanceHovered.Options.UseBackColor = true;
            this.btnRegular.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnRegular.Location = new System.Drawing.Point(231, 68);
            this.btnRegular.Name = "btnRegular";
            this.btnRegular.Size = new System.Drawing.Size(92, 37);
            this.btnRegular.TabIndex = 31;
            this.btnRegular.Text = "Alumno Regular";
            this.btnRegular.Click += new System.EventHandler(this.btnRegular_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNuevo.AppearanceHovered.Options.UseBackColor = true;
            this.btnNuevo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnNuevo.Location = new System.Drawing.Point(60, 68);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 37);
            this.btnNuevo.TabIndex = 31;
            this.btnNuevo.Text = "Nuevo Ingreso";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 197);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnRegular;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
    }
}