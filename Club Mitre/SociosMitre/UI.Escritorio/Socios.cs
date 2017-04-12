using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace UI.Escritorio
{
    public partial class Socios : Form
    {
       

        #region VARIABLES
        #endregion

        #region PROPIEDADES
        #endregion



        #region CONSTRUCTOR

        public Socios()
        {
            InitializeComponent();
            this.dgvSocios.AutoGenerateColumns = false;
        }

        #endregion


        #region METODOS

        public void listar()
        {
            SociosLogic socl = new SociosLogic();

            this.dgvSocios.DataSource = socl.TraerTodosEstadoActual();
            this.lbContador.Text = "Cantidad de registros: " + Convert.ToString(this.dgvSocios.RowCount);
           

        }

        #endregion

        #region EVENTOS
        
        private void Socios_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ABMSocios frmsoc = new ABMSocios(ApplicationForm.ModoForm.Alta);
            frmsoc.ShowDialog();
            this.listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Socio)this.dgvSocios.SelectedRows[0].DataBoundItem).NroSocio;
            ABMSocios frmsoc = new ABMSocios(ID, ApplicationForm.ModoForm.Modificacion);
            frmsoc.ShowDialog();
            this.listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Socio)this.dgvSocios.SelectedRows[0].DataBoundItem).NroSocio;
            ABMSocios frmsoc = new ABMSocios(ID, ApplicationForm.ModoForm.Baja);
            frmsoc.BloquearControles(true);
            frmsoc.ShowDialog();           
            this.listar();

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SociosLogic soc = new SociosLogic();
            dgvSocios.DataSource = soc.TraerPorApellidoEstadoActual(this.txtBuscar.Text);
            this.lbContador.Text = "Cantidad de registros: " + Convert.ToString(this.dgvSocios.RowCount);
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarAexcel2 exp = new ExportarAexcel2();
            exp.exporta_a_excel(this.dgvSocios);

        }


        #endregion





        private void tscSocios_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        

        


    }
}
