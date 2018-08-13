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
    public partial class frmControlUser : DevExpress.XtraEditors.XtraForm
    {
        public frmControlUser()
        {
            InitializeComponent();
        }

        private void frmControlUser_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_kinder2.SP_Consulta_Users' Puede moverla o quitarla según sea necesario.
            this.sP_Consulta_UsersTableAdapter.Fill(this.db_kinder2.SP_Consulta_Users);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarUser frm = new frmEliminarUser();
            frm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarUser frm = new frmAgregarUser();
            frm.Show();
        }
    }
}