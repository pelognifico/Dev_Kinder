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
    public partial class frmAgregar2 : DevExpress.XtraEditors.XtraForm
    {
        public frmAgregar2()
        {
            InitializeComponent();
        }

        Consultas obDatos = new Consultas();

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if(txtCedula.Text != "")
            {
                string sql = "SELECT cedula_representante, nom_representante, ape_representante FROM tblrepresentante WHERE cedula_representante=" +
                txtCedula.Text;
                obDatos.cn.Open();
                obDatos.cmd = new System.Data.SqlClient.SqlCommand(sql, obDatos.cn);
                obDatos.leer = obDatos.cmd.ExecuteReader();
                if (obDatos.leer.Read() == true)
                {
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
                    btnAgregar.Enabled = true;
                    btnLimpiar.Enabled = true;
                    gpcDatosAl.Enabled = true;
                    lblNombreRepre.Text = "" + obDatos.leer["nom_representante"].ToString() + " " + obDatos.leer["ape_representante"].ToString() + "";
                    lblNombreRepre.Visible = true;
                }
                else
                {
                    lblNombreA.Enabled = false;
                    txtNombreA.Enabled = false;
                    lblApellidoA.Enabled = false;
                    txtApellidoA.Enabled = false;
                    lblEdad.Enabled = false;
                    txtEdad.Enabled = false;
                    lblFechaNa.Enabled = false;
                    dtiNacimiento.Enabled = false;
                    lblNivel.Enabled = false;
                    cbxNiveles.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnLimpiar.Enabled = false;
                    gpcDatosAl.Enabled = false;
                    //lblNombreRepre.Text = "" + obDatos.leer["nom_representante"].ToString() + " " + obDatos.leer["ape_representante"].ToString() + "";
                    lblNombreRepre.Visible = false;
                    MessageBox.Show("Representante no registrado");
                }
                obDatos.cn.Close();
            }
            else
            {
                MessageBox.Show("El campo cedula no puede estar vacio");
                txtCedula.Focus();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tblalumno(nom_alumno, ape_alumno, edad_alumno, fecha_na, cod_nivel, cedula_representante) VALUES('" + 
                txtNombreA.Text + "','" + txtApellidoA.Text + "','" + txtEdad.Text + "','" + dtiNacimiento.Text + "','" + cbxNiveles.EditValue +
                "','" + txtCedula.Text + "')";
            if (obDatos.Insertar_datos(sql))
            {
                MessageBox.Show("Estudiante Registrado");
                ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Error al Registrar");
            }
        }

        private void frmAgregar2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_kinder2.tblniveles' Puede moverla o quitarla según sea necesario.
            this.tblnivelesTableAdapter1.Fill(this.db_kinder2.tblniveles);            
        }
    }
}