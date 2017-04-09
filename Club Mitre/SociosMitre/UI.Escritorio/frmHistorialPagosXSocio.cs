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
    public partial class frmHistorialPagosXSocio : Form
    {

        #region CONSTRUCTOR

        public frmHistorialPagosXSocio()
        {
            InitializeComponent();
            this.dataListado.AutoGenerateColumns = false;
            

        }

        #endregion


        #region VARIABLES

        int id = 0;
        int[] arreglo = new int[100];
        string nom, ape;


        enum meses
        {
            Enero=1,Febrero,Marzo,Abril,Mayo,Junio,Julio,Agosto,Septiembre,Octubre,Noviembre,Diciembre
        }

        #endregion



        #region METODOS

        

        public void Listar()
        {
            CuotasLogic cuo = new CuotasLogic();
            this.dataListado.DataSource = cuo.GetAll();

        }


        public void LlenarGrid (int nroSocio)
        {
            CuotasLogic cuo = new CuotasLogic();
            this.dataListado.DataSource = cuo.TraerPorSocio(nroSocio);

        }


        #endregion


        #region EVENTOS


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (this.btnBuscar.Text == "Listar")
            {
                this.Listar();
                this.btnBuscar.Text = "Buscar";
            }
            else
            {
                //this.Buscar();
            }
        }


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            
            frmListaSocios frm = new frmListaSocios();
            frm.ShowDialog();
            this.LlenarGrid(frm.par1);
            id = frm.par1;
            nom = frm.par2;
            ape = frm.par3;
            this.lbSocio.Text = nom + " " + ape;
            

            
        }



        private void frmHistorialPagosXSocio_Load(object sender, EventArgs e)
        {
            Listar();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void cbListaBusqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            CuotasLogic cuo = new CuotasLogic();
            int mes = Convert.ToInt32(cbListaBusqueda.SelectedIndex) + 1; ;
            if (cbFiltro.SelectedItem.ToString() == "Año")
            {
                if (id == 0)
                {
                    dataListado.DataSource = cuo.TraerPorAño(cbListaBusqueda.SelectedItem.ToString());
                }
                else
                {

                    dataListado.DataSource = cuo.TraerPorAñoParaSocio(cbListaBusqueda.SelectedItem.ToString(), id);
                }
            }

            else
            {
                if (id == 0)
                {
                    
                    dataListado.DataSource = cuo.TraerPorMes(mes);
                }
                else
                {

                    dataListado.DataSource = cuo.TraerPorMesParaSocio(mes, id);
                }

            }
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
            id = 0;
            this.lbSocio.Text = "";

        }



        private void cbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            cbListaBusqueda.Items.Clear();
            if (cbFiltro.SelectedItem.ToString() == "Año")
            {
                int año = 2015;
                for (int i = 0; i < 100; i++)
                {
                    cbListaBusqueda.Items.Add(año);
                    año++;
                }

            }
            else
            {
                cbListaBusqueda.Items.AddRange(typeof(meses).GetEnumNames());
                //cbListaBusqueda.Items.Add("Enero");
                //cbListaBusqueda.Items.Add("Febrero");
                //cbListaBusqueda.Items.Add("Marzo");
                //cbListaBusqueda.Items.Add("Abril");
                //cbListaBusqueda.Items.Add("Mayo");
                //cbListaBusqueda.Items.Add("Junio");
                //cbListaBusqueda.Items.Add("Julio");
                //cbListaBusqueda.Items.Add("Agosto");
                //cbListaBusqueda.Items.Add("Septiembre");
                //cbListaBusqueda.Items.Add("Octubre");
                //cbListaBusqueda.Items.Add("Noviembre");
                //cbListaBusqueda.Items.Add("Diciembre");

            }
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }



        #endregion

       

        



        private void tlpHistorialxSocio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            int nroSoc = ((Cuotas)this.dataListado.SelectedRows[0].DataBoundItem).NroSocio;
            int mes = ((Cuotas)this.dataListado.SelectedRows[0].DataBoundItem).MesCuota;
            int anio = ((Cuotas)this.dataListado.SelectedRows[0].DataBoundItem).AnioCuota;
            frmPagoCuotas frm = new frmPagoCuotas(nroSoc, mes, anio, ApplicationForm.ModoForm.Modificacion);
            
            frm.ShowDialog();
            this.Listar();
            
            
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int nroSoc = ((Cuotas)this.dataListado.SelectedRows[0].DataBoundItem).NroSocio;
            int mes = ((Cuotas)this.dataListado.SelectedRows[0].DataBoundItem).MesCuota;
            int anio = ((Cuotas)this.dataListado.SelectedRows[0].DataBoundItem).AnioCuota;
            frmPagoCuotas frm = new frmPagoCuotas(nroSoc, mes, anio, ApplicationForm.ModoForm.Baja);
            frm.BloquearControles(true);
            frm.ShowDialog();
            this.Listar();
        }

        

        

        



    }
}
