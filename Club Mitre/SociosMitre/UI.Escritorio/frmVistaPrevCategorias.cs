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
    public partial class frmVistaPrevCategorias : Form
    {
        public frmVistaPrevCategorias()
        {
            InitializeComponent();
        }

        private void frmVistaPrevCategorias_Load(object sender, EventArgs e)
        {
            ReporteCategorias rep = new ReporteCategorias();
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
