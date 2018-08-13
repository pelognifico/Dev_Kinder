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
    public partial class frmEliminarPagos : DevExpress.XtraEditors.XtraForm
    {
        public frmEliminarPagos()
        {
            InitializeComponent();
        }

        Consultas obDatos = new Consultas();

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (obDatos.Eliminar_datos("tblpagos", "cod_pago= " + txtCodigo.Text))
            {
                MessageBox.Show("Se ha eliminado con exito");
                ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Error al Eliminar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}