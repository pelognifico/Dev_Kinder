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
    public partial class frmDatosAl : DevExpress.XtraEditors.XtraForm
    {
        public frmDatosAl()
        {
            InitializeComponent();   
        }

        Consultas obDatos = new Consultas();

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (obDatos.Verificar("SELECT cedula_representante FROM tblrepresentante WHERE cedula_representante =" + txtCedula.Text))
            {
                string sql = "SELECT cod_alumno, nom_alumno, ape_alumno, fecha_na, nivel, cedula_representante FROM tblalumno a JOIN tblniveles n ON(a.cod_nivel = n.cod_nivel) WHERE cedula_representante =" + txtCedula.Text;
                obDatos.Consultar_datos(sql, "tblalumno");
                gridControl1.DataSource = obDatos.ds.Tables["tblalumno"];
            }
            else
            {
                MessageBox.Show("Representante no registrado");
            }
        }
    }
}