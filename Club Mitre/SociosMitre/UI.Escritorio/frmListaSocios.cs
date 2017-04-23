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
    public partial class frmListaSocios : Form
    {
        #region VARIABLES

        public string nomb, ape, doc, fnac, tip, cat;
        public int nrosoc;

        //par1 = NroSocio
        //    par2 = Nombre
        //        par3=Apellido
        //            par4 = Dni
        //                par5 = FechaNac
        //                    par6 = Tipo
        //                        par7 = Categoria


        #endregion


        #region CONSTRUCTOR

        public frmListaSocios()
        {
            InitializeComponent();
            this.dataListado.AutoGenerateColumns = false;

        }

        #endregion


        #region METODOS

        public void Listar()
        {
            SociosLogic soc = new SociosLogic();
            this.dataListado.DataSource = soc.GetAll();
            this.lbContador.Text = "Cantidad de registros: " + Convert.ToString(dataListado.RowCount);

        }



        public void Buscar()
        {
            SociosLogic soc = new SociosLogic();
            if (txtBuscar.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un socio a buscar");

            }
            else
            {
                this.dataListado.DataSource = soc.TraerPorApellido(this.txtBuscar.Text);

                this.btnBuscar.Text = "Listar";
            }
        }

        #endregion


        #region EVENTOS


        private void dgvListaSocios_DoubleClick(object sender, EventArgs e)
        {
            nrosoc = Convert.ToInt32(this.dataListado.CurrentRow.Cells["NroSocio"].Value);
            nomb = Convert.ToString(this.dataListado.CurrentRow.Cells["Nombre"].Value);
            ape = Convert.ToString(this.dataListado.CurrentRow.Cells["Apellido"].Value);
            doc = Convert.ToString(this.dataListado.CurrentRow.Cells["Dni"].Value);
            fnac = Convert.ToString(this.dataListado.CurrentRow.Cells["FechaNac"].Value);
            tip = Convert.ToString(this.dataListado.CurrentRow.Cells["Tipo"].Value);
            cat = Convert.ToString(this.dataListado.CurrentRow.Cells["Categoria"].Value);
            this.Hide();


        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (this.btnBuscar.Text == "Listar")
            {
                this.Listar();
                this.btnBuscar.Text = "Buscar";
            }
            else
            {
                this.Buscar();
            }
        }

        private void frmListaSocios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarAexcel2 exp1 = new ExportarAexcel2();
            exp1.exporta_a_excel(this.dataListado);
        }
       

        #endregion

        


    }
}
