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
    public partial class frmVistaPrevRepBalance : Form
    {
        public frmVistaPrevRepBalance()
        {
            InitializeComponent();
        }

        public Nullable<int>  anior;
        public string tipor, categoriar;

        private void formReportes_Load(object sender, EventArgs e)
        {
            if (tipor == string.Empty)
            {
                tipor = Convert.ToString(null);
            }
            if (categoriar == string.Empty)
            {
                categoriar = Convert.ToString(null);
            }
            ReporteBalance rep = new ReporteBalance();
            rep.SetParameterValue("@anio", anior);
            rep.SetParameterValue("@categoria", categoriar);
            rep.SetParameterValue("@tipo", tipor);
           

            crystalReportViewer1.ReportSource = rep;
        }


    }
}
