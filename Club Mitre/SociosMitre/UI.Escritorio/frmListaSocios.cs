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
        public frmListaSocios()
        {
            InitializeComponent();
            this.dataListado.AutoGenerateColumns = false;
            
        }

        public string par2, par3, par4, par5,par6,par7;
        public int par1;

        public void Listar()
        {
            SociosLogic soc = new SociosLogic();
            this.dataListado.DataSource = soc.GetAll();

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

        private void dgvListaSocios_DoubleClick(object sender, EventArgs e)
        {
            par1 = Convert.ToInt32(this.dataListado.CurrentRow.Cells["NroSocio"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Nombre"].Value);
            par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["Apellido"].Value);
            par4 = Convert.ToString(this.dataListado.CurrentRow.Cells["Dni"].Value);
            par5 = Convert.ToString(this.dataListado.CurrentRow.Cells["FechaNac"].Value);
            par6 = Convert.ToString(this.dataListado.CurrentRow.Cells["Tipo"].Value);
            par7 = Convert.ToString(this.dataListado.CurrentRow.Cells["Categoria"].Value);
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


    }
}
