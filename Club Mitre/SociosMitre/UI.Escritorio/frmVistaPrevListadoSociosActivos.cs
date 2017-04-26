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
    public partial class frmVistaPrevListadoSociosActivos : Form
    {
        public frmVistaPrevListadoSociosActivos()
        {
            InitializeComponent();
        }

        private void frmVistaPrevListadoSociosActivos_Load(object sender, EventArgs e)
        {
            ReporteListaSociosActivos rep = new ReporteListaSociosActivos();
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
