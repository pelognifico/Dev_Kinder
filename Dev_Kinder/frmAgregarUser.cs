using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Dev_Kinder
{
    public partial class frmAgregarUser : DevExpress.XtraEditors.XtraForm
    {
        public frmAgregarUser()
        {
            InitializeComponent();
        }

        Consultas obDatos = new Consultas();

        private void frmAgregarUser_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_kinder2.tbltipo_usu' Puede moverla o quitarla según sea necesario.
            this.tbltipo_usuTableAdapter.Fill(this.db_kinder2.tbltipo_usu);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tblusuario(nombre, username, password, cod_tipo)VALUES('" + 
                txtNombre.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtEditTipo.EditValue + "')";
            if (obDatos.Insertar_datos(sql))
            {
                MessageBox.Show("Usuario Registrado");
                ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Error al Registrar");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEditTipo.Text = "";
        }
    }
}