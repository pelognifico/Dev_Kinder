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
    public partial class frmRegistros : DevExpress.XtraEditors.XtraForm
    {
        public frmRegistros()
        {
            InitializeComponent();
        }

        Consultas obDatos = new Consultas();

        private void frmRegistros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_kinder2.SP_consulta' Puede moverla o quitarla según sea necesario.
            this.sP_consultaTableAdapter1.Fill(this.db_kinder2.SP_consulta);
       
            sP_consultaGridControl.Refresh();

        }       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPregunta frm = new frmPregunta();
            frm.Show();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            frmEliminar frm = new frmEliminar();
            frm.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            sP_consultaGridControl.Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditar frm = new frmEditar();
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
    }
}