using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dev_Kinder
{
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public frmPrincipal(string nombre)
        {
            InitializeComponent();
            lblNombreUser.Text = nombre;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmPregunta frm = new frmPregunta();
            frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmRegistros frm = new frmRegistros();
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmPagos frm = new frmPagos();
            frm.Show();
        }

        private void bbtNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAgregar frm = new frmAgregar();
            frm.Show();
        }

        private void bbtEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEliminar frm = new frmEliminar();
            frm.Show();
        }

        private void bbtSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActiveForm.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void bbtRegular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAgregar2 frm = new frmAgregar2();
            frm.Show();
        }

        private void bbtDatosA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDatosAl frm = new frmDatosAl();
            frm.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
            frm.Show();
        }

        private void bbtControlU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmControlUser frm = new frmControlUser();
            frm.Show();        
        }

        private void bbtAcerca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAcercaDe frm = new frmAcercaDe();
            frm.Show();
        }
    }
}
