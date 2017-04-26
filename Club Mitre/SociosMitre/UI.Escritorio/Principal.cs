using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Escritorio
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void aBMSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Socios frm = new Socios();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void ingresarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagoCuotas frm = new frmPagoCuotas();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void historialPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void aBMCCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizacionPrecios frm = new frmActualizacionPrecios();
            frm.ShowDialog();
        }

        private void controlDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSocios frm = new frmListaSocios();
            frm.ShowDialog();
        }

        private void importarDesdeExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargarDatosDesdeExcel frm = new FrmCargarDatosDesdeExcel();
            frm.ShowDialog();
        }

        private void resumenDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void balancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBalance frm = new frmBalance();
            frm.ShowDialog();
        }

        private void impresionDeTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImpresionDeTickets frm = new frmImpresionDeTickets();
            frm.ShowDialog();
        }

        private void historialDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorialPagosXSocio frm = new frmHistorialPagosXSocio();
            frm.ShowDialog();
        }
    }
}
