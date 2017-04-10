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
    public partial class frmAMBcategoria : ApplicationForm
    {
        
        
        
        #region VARIABLES

        private Categoria _categoriaactual;

        #endregion


        #region PROPIEDADES

        public Categoria Categoriaactual
        {
            get { return _categoriaactual; }
            set { _categoriaactual = value; }
        }
       

        #endregion


        #region CONSTRUCTOR



        public frmAMBcategoria()
        {
            InitializeComponent();
        }


        public frmAMBcategoria(ModoForm modo):this()
        {
            Modo = modo;
        }

        public frmAMBcategoria(int ID, ModoForm modo):this() 
        {
            CategoriaLogic cat = new CategoriaLogic();
            Modo = modo;
            Categoriaactual = cat.GetOne(ID);
            MapearDeDatos();

        }


        #endregion


        #region METODOS

        public override void MapearDeDatos()
        {

            this.txtId_categoria.Text = Convert.ToString(this.Categoriaactual.Id_categoria);
            this.txtDescripcion.Text = this.Categoriaactual.Descripcion;
            this.txtValor.Text = Convert.ToString(this.Categoriaactual.Valor);
            
            this.dtFecha_condicion.Value = Convert.ToDateTime(this.Categoriaactual.Fecha_condicion);
    
            switch (Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Guardar";
                    break;

                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;

                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;

                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    break;

                default:
                    break;
            }


        }


        public override void MapearADatos()
        {
            switch (this.Modo)
            {

                case ModoForm.Alta:
                    Categoria cat = new Categoria();
                    Categoriaactual = cat;
                    Categoriaactual.Descripcion = this.txtDescripcion.Text;
                    Categoriaactual.Valor = Convert.ToDouble(this.txtValor.Text);                   
                    Categoriaactual.Fecha_condicion = this.dtFecha_condicion.Value;                  
                    Categoriaactual.Estado = BusinessEntities.Estados.Nuevo;

                    break;

                case ModoForm.Baja:
                    Categoriaactual.Estado = BusinessEntities.Estados.Eliminar;
                    break;

                case ModoForm.Modificacion:
                    Categoriaactual.Id_categoria = Convert.ToInt32(this.txtId_categoria.Text);
                    Categoriaactual.Descripcion = this.txtDescripcion.Text;
                    Categoriaactual.Valor = Convert.ToDouble(this.txtValor.Text);                   
                    Categoriaactual.Fecha_condicion = this.dtFecha_condicion.Value;   
                    Categoriaactual.Estado = BusinessEntities.Estados.Modificar;
                    break;

                case ModoForm.Consulta:
                    Categoriaactual.Estado = BusinessEntities.Estados.No_Modificar;

                    break;

                default:
                    break;
            }


        }


        public override void GuardarCambios()
        {
            MapearADatos();
            CategoriaLogic cat = new CategoriaLogic();
            cat.Save(Categoriaactual);

        }


        public override bool Validar()
        {
            if (this.txtDescripcion.Text != string.Empty && this.txtValor.Text != string.Empty && this.dtFecha_condicion.Text != string.Empty )
            {
                return true;
            }
            else
            {
                Notificar("Faltan ingresar datos o ingresó datos incorrectos", "Revise la informacion ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }


        new public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        // para unificar el mecanismo de avisos al usuario


        new public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }


        public void Limpiar ()
        {
            this.txtDescripcion.Text = string.Empty;
            this.txtValor.Text = string.Empty;
           this.txtEdad.Text = string.Empty
            this.dtFecha_condicion.Text = string.Empty;
            this.txtId_categoria.Text = string.Empty;
           
        }


        public void BloquearControles(bool valor)
        {
            this.txtDescripcion.Enabled = !valor;
            this.txtValor.Enabled = !valor;;

            this.dtFecha_condicion.Enabled = !valor; ;
            

        }

        #endregion



        #region EVENTOS

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }


        #endregion

        private void dtFecha_condicion_ValueChanged(object sender, EventArgs e)
        {
            string edad = Convert.ToString(DateTime.Now.AddTicks(-dtFecha_condicion.Value.Ticks).Year - 1);
            this.txtEdad.Text = edad; 
        }


    }
}
