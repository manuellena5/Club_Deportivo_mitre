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
            this.lbContador.Text ="Cantidad de registros: " + Convert.ToString(this.dataListado.RowCount);
            this.lbSocio.Text = "";

        }


        public void LlenarGrid (int nroSocio)
        {
            CuotasLogic cuo = new CuotasLogic();
            this.dataListado.DataSource = cuo.TraerPorSocio(nroSocio);
            this.lbContador.Text = "Cantidad de registros: " + Convert.ToString(this.dataListado.RowCount);

        }


        #endregion


        #region EVENTOS


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            
            frmListaSocios frm = new frmListaSocios();
            frm.ShowDialog();
            this.LlenarGrid(frm.nrosoc);
            id = frm.nrosoc;
            nom = frm.nomb;
            ape = frm.ape;
            this.lbSocio.Text = nom + " " + ape;
            
            
        }



        private void frmHistorialPagosXSocio_Load(object sender, EventArgs e)
        {
            this.Listar();
        }




        private void cbListaBusqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbListaBusqueda.SelectedIndex) > -1)
            {
                
            
            CuotasLogic cuo = new CuotasLogic();
            int mes = Convert.ToInt32(cbListaBusqueda.SelectedIndex) + 1; ;
            if (cbFiltro.SelectedItem.ToString() == "Año")
            {
                if (id == 0)
                {
                    dataListado.DataSource = cuo.TraerPorAño(cbListaBusqueda.SelectedItem.ToString());
                    this.lbContador.Text = "Cantidad de registros: " + Convert.ToString(this.dataListado.RowCount);
                }
                else
                {

                    dataListado.DataSource = cuo.TraerPorAñoParaSocio(cbListaBusqueda.SelectedItem.ToString(), id);
                    this.lbContador.Text = "Cantidad de registros: " + Convert.ToString(this.dataListado.RowCount);
                }
            }

            else
            {
                if (id == 0)
                {
                    
                    dataListado.DataSource = cuo.TraerPorMes(mes);
                    this.lbContador.Text = "Cantidad de registros: " + Convert.ToString(this.dataListado.RowCount);
                }
                else
                {

                    dataListado.DataSource = cuo.TraerPorMesParaSocio(mes, id);
                    this.lbContador.Text = "Cantidad de registros: " + Convert.ToString(this.dataListado.RowCount);
                }

            }
        }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
            id = 0;
            this.lbSocio.Text = "";
            this.cbListaBusqueda.SelectedIndex = -1;
            this.cbFiltro.SelectedIndex = -1;

        }



        private void cbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbFiltro.SelectedIndex) > -1 )
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

            }
            }
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void tsbEditar_Click(object sender, EventArgs e)
        {

            int nroSoc = ((Cuotas)this.dataListado.SelectedRows[0].DataBoundItem).NroSocio;
            int mes = ((Cuotas)this.dataListado.SelectedRows[0].DataBoundItem).NroMesCuota;
            int anio = ((Cuotas)this.dataListado.SelectedRows[0].DataBoundItem).AnioCuota;
            frmPagoCuotas frm = new frmPagoCuotas(nroSoc, mes, anio, ApplicationForm.ModoForm.Modificacion);

            frm.ShowDialog();
            this.Listar();


        }


        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int nroSoc = ((Cuotas)this.dataListado.SelectedRows[0].DataBoundItem).NroSocio;
            int mes = ((Cuotas)this.dataListado.SelectedRows[0].DataBoundItem).NroMesCuota;
            int anio = ((Cuotas)this.dataListado.SelectedRows[0].DataBoundItem).AnioCuota;
            frmPagoCuotas frm = new frmPagoCuotas(nroSoc, mes, anio, ApplicationForm.ModoForm.Baja);
            frm.BloquearControles(true);
            frm.ShowDialog();
            this.Listar();
        }


        

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            frmVistaPrevHistorialPagos frm = new frmVistaPrevHistorialPagos();

            if (cbFiltro.SelectedItem.ToString() == "Año")
            {
                frm.anior = Convert.ToInt32(cbListaBusqueda.SelectedItem);
                frm.mesr = 0;
            }
            else
            {
                
                frm.mesr = Convert.ToInt32(cbListaBusqueda.SelectedIndex) + 1;
                frm.anior = 0;
            }

            frm.nro_socior = this.id;
            frm.ShowDialog();
        }

        private void tsbExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarAexcel2 exportar = new ExportarAexcel2();
            exportar.exporta_a_excel(this.dataListado);
        }

        private void tsbRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion







        private void btnExportar_Click(object sender, EventArgs e)
        {

        }


       



        

       

        

        

        



    }
}
