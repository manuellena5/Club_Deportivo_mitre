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
    public partial class frmVistaPrevListadoEstadoActualSociosActivos : Form
    {
        public frmVistaPrevListadoEstadoActualSociosActivos()
        {
            InitializeComponent();
        }

        private void frmVistaPrevListadoEstadoActualSociosActivos_Load(object sender, EventArgs e)
        {
            ReporteEstadoActualSocios rep = new ReporteEstadoActualSocios();
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
