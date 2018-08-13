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
    public partial class frmReportes : DevExpress.XtraEditors.XtraForm
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_kinder2.SP_Consulta_Pagos' Puede moverla o quitarla según sea necesario.
            this.sP_Consulta_PagosTableAdapter.Fill(this.db_kinder2.SP_Consulta_Pagos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPagos frm = new frmPagos();
            frm.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl1);
        }
        private void ShowGridPreview(DevExpress.XtraGrid.GridControl grid)
        {
            // Check whether or not the Grid Control can be printed. 
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            grid.ShowPrintPreview();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarPagos frm = new frmEditarPagos();
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarPagos frm = new frmEliminarPagos();
            frm.Show();
        }
    }
}