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
    public partial class frmRegistrosUser : DevExpress.XtraEditors.XtraForm
    {
        public frmRegistrosUser()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPregunta frm = new frmPregunta();
            frm.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ShowGridPreview(sP_consultaGridControl);
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

        private void frmRegistrosUser_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_kinder2.SP_consulta' Puede moverla o quitarla según sea necesario.
            this.sP_consultaTableAdapter.Fill(this.db_kinder2.SP_consulta);
        }
    }
}