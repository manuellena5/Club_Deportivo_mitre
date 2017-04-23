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
    public partial class frmVistaPrevRepTickets : Form
    {
        public frmVistaPrevRepTickets()
        {
            InitializeComponent();
        }

       public Nullable<int> anior, mesr, nrosocior;
       public string catr, tipr;

       private void frmVistaPrevRepTickets_Load(object sender, EventArgs e)
       {

           

           if (catr == string.Empty)
           {
               catr = Convert.ToString(null);
           }
           if (tipr == string.Empty)
           {
               tipr = Convert.ToString(null);
           }
           ReporteTicket rep = new ReporteTicket();
           rep.SetParameterValue("@nro_soc", nrosocior);
           rep.SetParameterValue("@mes", mesr);
           rep.SetParameterValue("@anio", anior);
           rep.SetParameterValue("@categoria", catr);
           rep.SetParameterValue("@tipo", tipr);
           crystalReportViewer1.ReportSource = rep;

       }


    }
}
