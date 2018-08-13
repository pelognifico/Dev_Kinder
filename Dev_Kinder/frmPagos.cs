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
    public partial class frmPagos : DevExpress.XtraEditors.XtraForm
    {
        public frmPagos()
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
                    lblComprobante.Enabled = true;
                    txtComprobante.Enabled = true;
                    lblMonto.Enabled = true;
                    txtMonto.Enabled = true;
                    lblTipo.Enabled = true;
                    lueTipo.Enabled = true;
                    lblMes.Enabled = true;
                    lueMes.Enabled = true;
                    lblFecha.Enabled = true;
                    dtiFechaPa.Enabled = true;
                    btnPagar.Enabled = true;
                    btnLimpiar.Enabled = true;
                    gpcDatosPa.Enabled = true;
                    lblNombreRepre.Text = "" + obDatos.leer["nom_representante"].ToString() + " " + obDatos.leer["ape_representante"].ToString() + "";
                    lblNombreRepre.Visible = true;
                }
                else
                {
                    lblComprobante.Enabled = false;
                    txtComprobante.Enabled = false;
                    lblMonto.Enabled = false;
                    txtMonto.Enabled = false;
                    lblTipo.Enabled = false;
                    lueTipo.Enabled = false;
                    lblMes.Enabled = false;
                    lueMes.Enabled = false;
                    lblFecha.Enabled = false;
                    dtiFechaPa.Enabled = false;
                    btnPagar.Enabled = false;
                    btnLimpiar.Enabled = false;
                    gpcDatosPa.Enabled = false;
                    //lblNombreRepre.Text = "" + obDatos.leer["nom_representante"].ToString() + " " + obDatos.leer["ape_representante"].ToString() + "";
                    lblNombreRepre.Visible = false;
                    MessageBox.Show("Cedula no registrada");
                }
                obDatos.cn.Close();
            }
            else
            {
                MessageBox.Show("El campo cedula no puede estar vacio");
                txtCedula.Focus();
            }
        }
            

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblpagos WHERE cod_pago =" + txtComprobante.Text;

            if (!obDatos.Verificar(query))
            {
                string sql = "INSERT INTO tblpagos VALUES('" + txtComprobante.Text + "','" + txtMonto.Text + "','" + dtiFechaPa.EditValue
               + "','" + txtCedula.Text + "','" + lueTipo.EditValue + "','" + lueMes.EditValue + "')";
                if (obDatos.Insertar_datos(sql))
                {
                    MessageBox.Show("Pago Registrado");
                    ActiveForm.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar el pago");
                }
            }
            else
            {
                MessageBox.Show("N° de Comprobante ya registrado");
            }           
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_kinder2.tblmes' Puede moverla o quitarla según sea necesario.
            this.tblmesTableAdapter1.Fill(this.db_kinder2.tblmes);
            // TODO: esta línea de código carga datos en la tabla 'db_kinder2.tbltipo' Puede moverla o quitarla según sea necesario.
            this.tbltipoTableAdapter1.Fill(this.db_kinder2.tbltipo);            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Text = "";
            txtComprobante.Text = "";
            txtMonto.Text = "";
            lueMes.Text = "";
            lueTipo.Text = "";
            dtiFechaPa.Text = "";
        }
    }
}