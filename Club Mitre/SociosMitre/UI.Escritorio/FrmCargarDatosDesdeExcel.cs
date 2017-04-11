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
    public partial class FrmCargarDatosDesdeExcel : Form
    {
        public FrmCargarDatosDesdeExcel()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ImportarExcel imp = new ImportarExcel();
            imp.importarExcel(this.dataListado, "Control 2016");
        }


    }
}
