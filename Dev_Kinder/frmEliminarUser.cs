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
    public partial class frmEliminarUser : DevExpress.XtraEditors.XtraForm
    {
        public frmEliminarUser()
        {
            InitializeComponent();
        }

        Consultas obDatos = new Consultas();

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (obDatos.Eliminar_datos("tblusuario", "id= " + txtCedula.Text))
            {
                MessageBox.Show("Se ha eliminado con exito");
                ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Error al Eliminar");
            }
        }
    }
}