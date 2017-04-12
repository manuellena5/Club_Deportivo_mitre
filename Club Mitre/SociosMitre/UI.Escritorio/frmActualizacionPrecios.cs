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
    public partial class frmActualizacionPrecios : ApplicationForm
    {
        

        #region VARIABLES
        #endregion

        #region PROPIEDADES
        #endregion


        #region CONSTRUCTOR

        

        public frmActualizacionPrecios()
        {
            InitializeComponent();
            this.dataListado.AutoGenerateColumns = false;
        }

        #endregion


        #region METODOS

        public void listar()
        {
            CategoriaLogic catl = new CategoriaLogic();

            this.dataListado.DataSource = catl.GetAll();

            this.lbContador.Text = "Cantidad de registros: " + Convert.ToString(this.dataListado.RowCount);
           

        }

        #endregion


        #region EVENTOS

        private void frmActualizacionPrecios_Load(object sender, EventArgs e)
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


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAMBcategoria frm = new frmAMBcategoria(ApplicationForm.ModoForm.Alta);
            frm.ShowDialog();
            this.listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Categoria)this.dataListado.SelectedRows[0].DataBoundItem).Id_categoria;
            frmAMBcategoria frm = new frmAMBcategoria(ID, ApplicationForm.ModoForm.Modificacion);
            frm.ShowDialog();
            this.listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //int ID = ((Categoria)this.dataListado.SelectedRows[0].DataBoundItem).Id_categoria;
            //frmAMBcategoria frm = new frmAMBcategoria(ID, ApplicationForm.ModoForm.Baja);
            //frm.BloquearControles(true);
            //frm.ShowDialog();
            //this.listar();

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarAexcel2 exp = new ExportarAexcel2();
            exp.exporta_a_excel(this.dataListado);
        }
       

        #endregion

       


    }
}
