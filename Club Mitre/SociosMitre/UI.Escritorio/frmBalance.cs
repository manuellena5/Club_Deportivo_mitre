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
    public partial class frmBalance : Form
    {
        

        #region VARIABLES

        #endregion


        #region CONSTRUCTOR
        
          public frmBalance()
        {
            InitializeComponent();
            this.dataListado.AutoGenerateColumns = false;
            this.cargarCombos();
        }

        #endregion


        #region METODOS

          public void Listar()
          {
              CuotasLogic cuo = new CuotasLogic();
              this.dataListado.DataSource = cuo.TraerBalanceClubMutualAñoActual();
              this.Limpiar();
              this.LabelVisibles(false);
              

          }

            public void LabelVisibles(bool val)
          {
              this.lbCategoria.Visible = val;
              this.lbAnio.Visible = val;
              this.lbTipo.Visible = val;

          }
            public void cargarCombos()
            {
                 int año = 2015;
                for (int i = 0; i < 100; i++)
                {
                    cbAnio.Items.Add(año);
                    año++;
                }

                CategoriaLogic cat = new CategoriaLogic();
                cbCategoria.DataSource = cat.TraerCategorias();
                this.Limpiar();
            }

            public void Limpiar()
            {
                cbAnio.SelectedItem = null;
                cbCategoria.SelectedItem = null;
                cbTipo.SelectedItem = null;

            }

        #endregion


        #region EVENTOS

          private void frmBalance_Load(object sender, EventArgs e)
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

          private void btnTraerBalance_Click(object sender, EventArgs e)
          {
              CuotasLogic cl = new CuotasLogic();
             this.dataListado.DataSource = cl.TraerBalanceClubMutual(Convert.ToInt32(cbAnio.SelectedItem),Convert.ToString(cbTipo.SelectedItem),Convert.ToString(cbCategoria.SelectedItem));


             this.LabelVisibles(true);
             lbAnio.Text = Convert.ToString(cbAnio.SelectedItem);
             lbTipo.Text = Convert.ToString(cbTipo.SelectedItem);
             lbCategoria.Text = Convert.ToString(cbCategoria.SelectedItem);
          }

          private void btnExportar_Click(object sender, EventArgs e)
          {


              frmVistaPrevRepBalance fr = new frmVistaPrevRepBalance();
              
              fr.anior = Convert.ToInt32(this.cbAnio.SelectedItem);
              fr.tipor = Convert.ToString(this.cbTipo.SelectedItem);
              fr.categoriar = Convert.ToString(this.cbCategoria.SelectedItem);
              fr.ShowDialog();

              //ExportarAexcel2 exp = new ExportarAexcel2();
              //exp.exporta_a_excel(this.dataListado);
          }

          private void btnLimpiar_Click(object sender, EventArgs e)
          {
              this.Limpiar();
          }

    }
}
