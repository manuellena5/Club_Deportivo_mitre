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


        public int nroS;
        string nom,ap,cat,tipo;
        


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

        public void HabilitarDatosSocio (bool val)
        {
            this.txtNroSocio.Visible = val;
            this.lnkBuscarSocio.Visible = val;
            this.lbNroSocio.Visible = val;
            this.lbDatosSocio.Visible = val;
            this.lbNombre.Visible = val;
            this.lbApellidos.Visible = val;
            this.txtApellido.Visible = val;
            this.txtNombre.Visible = val;
            this.txtApellido.Visible = val;

        }

        #endregion




        private void cbAnio_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmVistaPrevRepTickets fr = new frmVistaPrevRepTickets();

            fr.anior = Convert.ToInt32(this.cbAnio.SelectedItem);
            fr.mesr = Convert.ToInt32(this.cbMes.SelectedItem);

            if (Convert.ToString(cbCategorias.SelectedItem) == "UnicoSocio")
            {
                fr.nrosocior = Convert.ToInt32(this.txtNroSocio.Text);
            }
            else
            {
                fr.nrosocior = 0;
            }

            if (Convert.ToString(this.cbCategorias.SelectedItem) != string.Empty)
            {
                if (Convert.ToString(this.cbCategorias.SelectedItem) == "Mayores" || Convert.ToString(this.cbCategorias.SelectedItem) == "Menores")
                {
                    fr.catr = Convert.ToString(this.cbCategorias.SelectedItem);
                }
                else if (Convert.ToString(this.cbCategorias.SelectedItem) == "Club" || Convert.ToString(this.cbCategorias.SelectedItem) == "Mutual")
                {
                    fr.tipr = Convert.ToString(this.cbCategorias.SelectedItem);
                }
                
            }
            
            
            fr.ShowDialog();
        }

        private void lnkBuscarSocio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmListaSocios frm = new frmListaSocios();
            frm.ShowDialog();
            int nroS = frm.nrosoc;
           string nom = frm.nomb;
           string ap = frm.ape;
           this.txtNroSocio.Text = Convert.ToString(nroS);
           this.txtNombre.Text = Convert.ToString(nom);
           this.txtApellido.Text = Convert.ToString(ap);
        }

        private void cbCategorias_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cbCategorias.SelectedItem) == "UnicoSocio")
            {
                this.HabilitarDatosSocio(true);

            }
            else if (Convert.ToString(cbCategorias.SelectedItem) == "Menores")
            {
                cat = "Menores";
                this.HabilitarDatosSocio(false);
            }
            else if (Convert.ToString(cbCategorias.SelectedItem) == "Mayores")
            {
                cat = "Mayores";
                this.HabilitarDatosSocio(false);
            }
            else if (Convert.ToString(cbCategorias.SelectedItem) == "Club")
            {
                tipo = "Club";
                this.HabilitarDatosSocio(false);
            }
            else if (Convert.ToString(cbCategorias.SelectedItem) == "Mutual")
            {
                tipo = "Mutual";
                this.HabilitarDatosSocio(false);
            }
           
        }


    }
}
