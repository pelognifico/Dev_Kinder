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
    public partial class frmPregunta : DevExpress.XtraEditors.XtraForm
    {
        public frmPregunta()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAgregar frm = new frmAgregar();
            frmPregunta.ActiveForm.Close();
            frm.Show();
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            frmAgregar2 frm = new frmAgregar2();
            frmPregunta.ActiveForm.Close();
            frm.Show();
        }
    }
}