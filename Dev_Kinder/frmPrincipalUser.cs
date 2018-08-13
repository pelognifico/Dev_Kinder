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
    public partial class frmPrincipalUser : DevExpress.XtraEditors.XtraForm
    {
        public frmPrincipalUser(string nombre)
        {
            InitializeComponent();
            lblNombreUser.Text = nombre;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPregunta frm = new frmPregunta();
            frm.Show();
        }
        private void btnVerRegistro_Click_1(object sender, EventArgs e)
        {
            frmRegistrosUser frm = new frmRegistrosUser();
            frm.Show();
        }
        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            frmPagos frm = new frmPagos();
            frm.Show();
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportesUser frm = new frmReportesUser();
            frm.Show();
        }
        private void bbtNuevo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAgregar frm = new frmAgregar();
            frm.Show();
        }

        private void bbtRegular_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAgregar2 frm = new frmAgregar2();
            frm.Show();
        }

        private void bbtSalir_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActiveForm.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void bbtDatosA_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDatosAl frm = new frmDatosAl();
            frm.Show();
        }

        private void bbtAcerca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAcercaDe frm = new frmAcercaDe();
            frm.Show();
        }
    }
}