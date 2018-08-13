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
    public partial class frmEditar : DevExpress.XtraEditors.XtraForm
    {
        public frmEditar()
        {
            InitializeComponent();
        }

        Consultas obDatos = new Consultas();

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string sql = "DECLARE @cedula int =" + txtCedula.Text + " EXEC SP_Consulta_All_Re_Al @cedula";
            obDatos.cn.Open();
            obDatos.cmd = new System.Data.SqlClient.SqlCommand(sql, obDatos.cn);
            obDatos.leer = obDatos.cmd.ExecuteReader();
            if (obDatos.leer.Read() == true)
            {                            
                //LLeno los campos
                txtNombre.Text = obDatos.leer["nom_representante"].ToString();
                txtApellido.Text = obDatos.leer["ape_representante"].ToString();
                txtDireccion.Text = obDatos.leer["direccion_representante"].ToString();
                txtTelef1.Text = obDatos.leer["telcasa"].ToString();
                txtTelef2.Text = obDatos.leer["telmovil"].ToString();
                txtNombreA.Text = obDatos.leer["nom_alumno"].ToString();
                txtApellidoA.Text = obDatos.leer["ape_alumno"].ToString();
                txtEdad.Text = obDatos.leer["edad_alumno"].ToString();
                dtiNacimiento.Text = obDatos.leer["fecha_na"].ToString();
                cbxNiveles.Text = obDatos.leer["cod_nivel"].ToString();
                MessageBox.Show("Registro Encontrado");
            }
            else
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                txtTelef1.Text = "";
                txtTelef2.Text = "";
                txtNombreA.Text = "";
                txtApellidoA.Text = "";
                txtEdad.Text = "";
                dtiNacimiento.Text = "";
                cbxNiveles.Text = "";
                MessageBox.Show("No existe el registro");
            }
            obDatos.cn.Close();         
        }

        private void btnModificarRe_Click(object sender, EventArgs e)
        {
            string campos = "nom_representante='" + txtNombre.Text + "', ape_representante='" + txtApellido.Text
                + "', direccion_representante='" + txtDireccion.Text + "', telcasa=" + txtTelef1.Text + ", telmovil=" + txtTelef2.Text;

            if (obDatos.Actualizar_datos("tblrepresentante", campos, "cedula_representante=" + txtCedula.Text))
            {
                MessageBox.Show("El registro se ha modificado con exito");
            }
            else
            {
                MessageBox.Show("Error al modificar el registro");
            }
        }

        private void chkRe_CheckedChanged(object sender, EventArgs e)
        {
            //Activo los controles
            gpcDatosRe.Enabled = true;
            lblNombre.Enabled = true;
            txtNombre.Enabled = true;
            lblApellido.Enabled = true;
            txtApellido.Enabled = true;
            lblDireccion.Enabled = true;
            txtDireccion.Enabled = true;
            lblTel1.Enabled = true;
            txtTelef1.Enabled = true;
            lblTel2.Enabled = true;
            txtTelef2.Enabled = true;
            btnModificarRe.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void chkAl_CheckedChanged(object sender, EventArgs e)
        {
            //Activo los controles
            gpcDatosAl.Enabled = true;
            lblNombreA.Enabled = true;
            txtNombreA.Enabled = true;
            lblApellidoA.Enabled = true;
            txtApellidoA.Enabled = true;
            lblEdad.Enabled = true;
            txtEdad.Enabled = true;
            lblFechaNa.Enabled = true;
            dtiNacimiento.Enabled = true;
            lblNivel.Enabled = true;
            cbxNiveles.Enabled = true;
            btnModificarEs.Enabled = true;
            btnLimpiar2.Enabled = true;
        }

        private void btnModificarEs_Click(object sender, EventArgs e)
        {
            string campos = "nom_alumno='" + txtNombreA.Text + "', ape_alumno='" + txtApellidoA.Text
                + "', edad_alumno='" + txtEdad.Text + "', fecha_na=" + dtiNacimiento.Text + ", cod_nivel=" + cbxNiveles.Text;

            if (obDatos.Actualizar_datos("tblalumno", campos, "cedula_representante=" + txtCedula.Text))
            {
                MessageBox.Show("El registro se ha modificado con exito");                
            }
            else
            {
                MessageBox.Show("Error al modificar el registro");
            }
        }
    }
}