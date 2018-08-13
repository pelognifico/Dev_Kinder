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
    public partial class frmAgregar : DevExpress.XtraEditors.XtraForm
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        Consultas obDatos = new Consultas();

        public new Size Size { get; set; }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_kinder2.tblniveles' Puede moverla o quitarla según sea necesario.
            this.tblnivelesTableAdapter1.Fill(this.db_kinder2.tblniveles);
            // TODO: esta línea de código carga datos en la tabla 'db_kinderDataSet.tblniveles' Puede moverla o quitarla según sea necesario.
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpio los campos de texto
            txtNombre.ResetText();
            txtApellido.ResetText();            
            txtCedula.ResetText();
            txtDireccion.ResetText();            
            txtTelef1.ResetText();
            txtTelef2.ResetText();
            //Se pone el cursor al principio
            txtNombre.Focus();
        }

        private void btnAgregarRe_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblrepresentante WHERE cedula_representante =" + txtCedula.Text;

            if (!obDatos.Verificar(query))
            {
                string sql1 = "INSERT INTO tblrepresentante VALUES('" + txtCedula.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtDireccion.Text + "','" +
                txtTelef1.Text + "','" + txtTelef2.Text + "',1)";
                if (obDatos.Insertar_datos(sql1))
                {
                    MessageBox.Show("Registro Insertado");
                    ActiveForm.Size = new Size(664, 542);
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtCedula.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelef1.Enabled = false;
                    txtTelef2.Enabled = false;
                    btnAgregarRe.Enabled = false;
                    btnLimpiar.Enabled = false;
                    ActiveForm.Location = new Point(400, 100);
                }
                else
                {
                    MessageBox.Show("Error al Insertar");
                }
            }
            else
            {
                MessageBox.Show("Cedula Ya Registrada");
            }
        }

        private void btnAgregarEs_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tblalumno(nom_alumno, ape_alumno, edad_alumno, fecha_na, cod_nivel, cedula_representante) VALUES('" + txtNombre1.Text + "','" + txtApellido1.Text + "','" + txtEdad.Text + "','" +
                dtiNacimiento.Text + "','" + cbxNiveles.EditValue + "','" + txtCedula.Text + "')";
            if (obDatos.Insertar_datos(sql))
            {
                MessageBox.Show("Estudiante Registrado");
                ActiveForm.Size = new Size(664, 312);
                ActiveForm.Location = new Point(400, 50);
                ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Error al Insertar");
            }
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            //Limpio los campos de texto
            txtNombre1.ResetText();
            txtApellido1.ResetText();
            txtEdad.ResetText();
            dtiNacimiento.ResetText();
            cbxNiveles.ResetText();
            //Se pone el cursor al principio
            txtNombre.Focus();
        }

        private void gpcDatosRe_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}