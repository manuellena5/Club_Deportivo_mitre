﻿using System;
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
    public partial class ABMSocios : ApplicationForm
    {
        

        #region VARIABLES

        private Socio _socioactual;

        #endregion


        #region PROPIEDADES

        public Socio Socioactual
        {
            get { return _socioactual; }
            set { _socioactual = value; }
        }
       

        #endregion


        #region CONSTRUCTOR

        public ABMSocios()
        {
            InitializeComponent();
        }
       

        public ABMSocios(ModoForm modo):this()
        {
            Modo = modo;
        }

        public ABMSocios(int ID, ModoForm modo):this() 
        {
            SociosLogic soc = new SociosLogic();
            Modo = modo;
            Socioactual = soc.GetOne(ID);
            MapearDeDatos();

        }


        #endregion


        #region METODOS

        public override void MapearDeDatos()
        {

            this.txtNroSocio.Text = Convert.ToString(this.Socioactual.NroSocio);
            this.txtNombre.Text = this.Socioactual.Nombre;
            this.txtApellido.Text = this.Socioactual.Apellido;
            this.txtDni.Text = Convert.ToString(this.Socioactual.Dni);
            this.dtFecha.Value = Convert.ToDateTime(this.Socioactual.FechaNac);
            this.cbTipo.Text = Convert.ToString(this.Socioactual.Tipo);
            this.cbCategoria.Text = Convert.ToString(this.Socioactual.Categoria);
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
                    Socio soc = new Socio();
                    Socioactual = soc;
                    Socioactual.Nombre = this.txtNombre.Text;
                    Socioactual.Apellido = this.txtApellido.Text;
                    Socioactual.Dni = Convert.ToInt32(this.txtDni.Text);
                    Socioactual.FechaNac = this.dtFecha.Value;
                    Socioactual.Tipo = Convert.ToString(this.cbTipo.SelectedItem);
                    Socioactual.Categoria = Convert.ToString(this.cbCategoria.SelectedItem);
                    Socioactual.Estado = BusinessEntities.Estados.Nuevo;

                    break;

                case ModoForm.Baja:
                    Socioactual.Estado = BusinessEntities.Estados.Eliminar;
                    break;

                case ModoForm.Modificacion:
                    Socioactual.NroSocio = Convert.ToInt32(this.txtNroSocio.Text);
                    Socioactual.Nombre = this.txtNombre.Text;
                    Socioactual.Apellido = this.txtApellido.Text;
                    Socioactual.Dni = Convert.ToInt32(this.txtDni.Text);
                    Socioactual.FechaNac = this.dtFecha.Value;
                    Socioactual.Tipo = Convert.ToString(this.cbTipo.SelectedItem);
                    Socioactual.Categoria = Convert.ToString(this.cbCategoria.SelectedItem);
                    Socioactual.Estado = BusinessEntities.Estados.Modificar;
                    break;

                case ModoForm.Consulta:
                    Socioactual.Estado = BusinessEntities.Estados.No_Modificar;

                    break;

                default:
                    break;
            }


        }


        public override void GuardarCambios()
        {
            MapearADatos();
            SociosLogic soc = new SociosLogic();
            soc.Save(Socioactual);

        }


        public override bool Validar()
        {
            if (this.txtApellido.Text != string.Empty && this.txtNombre.Text != string.Empty && this.cbTipo.Text != string.Empty && this.cbCategoria.Text != string.Empty)
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
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtDni.Text = string.Empty;
            this.dtFecha.Text = string.Empty;
            this.cbCategoria.Text = string.Empty;
            this.cbTipo.Text = string.Empty;
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

       
        
      
        
        
        #region METODOS NO IMPLEMENTADOS

        private void txtNroSocio_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        

    }
}
