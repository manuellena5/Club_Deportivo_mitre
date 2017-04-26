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
    public partial class frmVistaPrevHistorialPagos : Form
    {
        public frmVistaPrevHistorialPagos()
        {
            InitializeComponent();
        }

        public int anior, mesr, nro_socior;

        private void frmVistaPrevHistorialPagos_Load(object sender, EventArgs e)
        {
            ReporteHistorialPagos rep = new ReporteHistorialPagos();

            rep.SetParameterValue("@anio", anior);
            rep.SetParameterValue("@mes", mesr);
            rep.SetParameterValue("@nro_socio", nro_socior);

            crystalReportViewer1.ReportSource = rep;
        }
    }
}
