namespace Dev_Kinder
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnEntrar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // separatorControl1
            // 
            this.separatorControl1.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(322, 73);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(31, 293);
            this.separatorControl1.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(405, 164);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Properties.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("txtUsername.Properties.Appearance.Image")));
            this.txtUsername.Properties.Appearance.Options.UseBackColor = true;
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Properties.Appearance.Options.UseForeColor = true;
            this.txtUsername.Properties.Appearance.Options.UseImage = true;
            this.txtUsername.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtUsername.Properties.ContextImageOptions.Image")));
            this.txtUsername.Size = new System.Drawing.Size(221, 36);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(405, 223);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Properties.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("txtPassword.Properties.Appearance.Image")));
            this.txtPassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtPassword.Properties.Appearance.Options.UseImage = true;
            this.txtPassword.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtPassword.Properties.ContextImageOptions.Image")));
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(221, 36);
            this.txtPassword.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(191, 235);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Sistema de Incripción";
            // 
            // btnEntrar
            // 
            this.btnEntrar.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEntrar.AppearanceHovered.Options.UseBackColor = true;
            this.btnEntrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnEntrar.Location = new System.Drawing.Point(534, 282);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(92, 37);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(97, 190);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(210, 39);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "My Control Sys";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(504, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(122, 23);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Iniciar Sección";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(674, 438);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.separatorControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresa";
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnEntrar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}