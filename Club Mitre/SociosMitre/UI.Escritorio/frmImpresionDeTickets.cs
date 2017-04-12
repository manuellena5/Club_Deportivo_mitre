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
    public partial class frmImpresionDeTickets : Form
    {
        public frmImpresionDeTickets()
        {
            InitializeComponent();
            LlenarCombos();
        }


        enum meses
        {
            Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre
        }


        #region METODOS

        public void LlenarCombos()
        {
            int año = 2015;
            for (int i = 0; i < 100; i++)
            {
                this.cbAnio.Items.Add(año);
                año++;
            }

            this.cbMes.Items.AddRange(typeof(meses).GetEnumNames());
            

        }


        #endregion




        private void cbAnio_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }


    }
}
