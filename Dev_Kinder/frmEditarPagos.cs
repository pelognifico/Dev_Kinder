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
    public partial class frmEditarPagos : DevExpress.XtraEditors.XtraForm
    {
        public frmEditarPagos()
        {
            InitializeComponent();
        }

        Consultas obDatos = new Consultas();

        private void frmEditarPagos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_kinder2.tblmes' Puede moverla o quitarla según sea necesario.
            this.tblmesTableAdapter.Fill(this.db_kinder2.tblmes);
            // TODO: esta línea de código carga datos en la tabla 'db_kinder2.tbltipo' Puede moverla o quitarla según sea necesario.
            this.tbltipoTableAdapter.Fill(this.db_kinder2.tbltipo);

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string sql = "DECLARE @codigo int =" + txtCedula.Text + " EXEC SP_Consulta_Pagos_Single @codigo";
            obDatos.cn.Open();
            obDatos.cmd = new System.Data.SqlClient.SqlCommand(sql, obDatos.cn);
            obDatos.leer = obDatos.cmd.ExecuteReader();
            if (obDatos.leer.Read() == true)
            {
                lblMonto.Enabled = true;
                txtMonto.Enabled = true;
                lblTipo.Enabled = true;
                txtEditTipo.Enabled = true;
                lblMes.Enabled = true;
                txtEditMes.Enabled = true;
                lblFecha.Enabled = true;
                dttFecha.Enabled = true;
                btnModificar.Enabled = true;
                btnLimpiar.Enabled = true;
                gpcDatosPa.Enabled = true;

                //LLeno los campos
                txtMonto.Text = obDatos.leer["monto_pago"].ToString();
                txtEditTipo.Text = obDatos.leer["tipo"].ToString();
                txtEditMes.Text = obDatos.leer["mes"].ToString();
                dttFecha.Text = obDatos.leer["fecha_pago"].ToString();

                MessageBox.Show("Pago Encontrado");
            }
            else
            {
                MessageBox.Show("Pago No encontrado");
            }
            obDatos.cn.Close();            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string campos = "monto_pago=" + txtMonto.Text + ", cod_tipo=" + txtEditTipo.EditValue
                + ", cod_mes=" + txtEditMes.EditValue + ", fecha_pago='" + dttFecha.EditValue + "'";

            if (obDatos.Actualizar_datos("tblpagos", campos, "cod_pago=" + txtCedula.Text))
            {
                MessageBox.Show("El Pago se ha modificado con exito");
            }
            else
            {
                MessageBox.Show("Error al modificar el pago");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Text = "";
            txtEditMes.Text = "";
            txtEditTipo.Text = "";
            txtMonto.Text = "";
            dttFecha.Text = "";
        }
    }
}