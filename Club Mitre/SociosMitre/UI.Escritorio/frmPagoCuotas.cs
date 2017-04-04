using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace UI.Escritorio
{
    public partial class frmPagoCuotas : ApplicationForm
    {
        #region CONSTRUCTOR

        public frmPagoCuotas()
        {
            InitializeComponent();
        }

        #endregion


        #region VARIABLES


        PagoCuotasLogic _pagol = new PagoCuotasLogic();

       
        public int nrosocio;
        public string nom, ape,categoria,tipo;

        #endregion

        #region PROPIEDADES
       
        public PagoCuotasLogic Pagol
        {
            get { return _pagol; }
            set { _pagol = value; }
        }
        
        #endregion



        #region METODOS


        new private void Notificar(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de cuotas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       new private void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, "Registro de cuotas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void Limpiar()
        {
            this.txtNroSocio.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.cbAnio.Text = string.Empty;
            this.txtImporte.Text = string.Empty;
            this.txtCategoria.Text = string.Empty;
            this.txtTipo.Text = string.Empty;
            lbMeses.ClearSelected();
        }


        public void Socios(int nrosocio, string nombre, string apellido,string categoria,string tipo)
        {
            this.txtNroSocio.Text = Convert.ToString(nrosocio);
            this.txtNombre.Text = nombre;
            this.txtApellido.Text = apellido;
            this.txtCategoria.Text = categoria;
            this.txtTipo.Text = tipo;
            nom = nombre;
            ape = apellido;
            
        }


        public void informe(int nro, string nombre, string apellido, string mes, int anio, int importe)
        {
            MessageBox.Show("Nro Socio: " + nro + "\n" + "Socio: " + nombre + " " + apellido + "\n" + "Paga mes: " + mes + "\n" + "Año: " + anio + "\n" + "Importe: " + importe);
        }

        


        #endregion


        #region EVENTOS


        private void linkBuscarSocio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmListaSocios form = new frmListaSocios();
            form.ShowDialog();
            this.Socios(form.par1, form.par2, form.par3,form.par7,form.par6);
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            { 
	

                if (this.lbMeses.Text == string.Empty || this.cbAnio.Text == string.Empty)
                {
                    this.Notificar("Falta ingresar algunos datos");

                }
                else if ((Convert.ToString(this.lbMeses.SelectedItem)) == "AñoCompleto" && this.lbMeses.SelectedItems.Count == 1)
                    {
                        PagoCuotas pago = new PagoCuotas();
                        string mes;
                        mes = lbMeses.SelectedItem.ToString();
                        pago.NroSocio = Convert.ToInt32(this.txtNroSocio.Text);
                        pago.AnioCuota = Convert.ToInt32(this.cbAnio.SelectedItem);
                        pago.Importe = Convert.ToInt32(this.txtImporte.Text);
                        nom = this.txtNombre.Text;
                        ape = this.txtApellido.Text;

                        for (int k = 0; k < 12; k++)
                        {
                            PagoCuotas pago2 = new PagoCuotas();
                            string mess;
                            mess = lbMeses.Items[k].ToString();
                            pago2.NroSocio = Convert.ToInt32(this.txtNroSocio.Text);
                            pago2.MesCuota = mess;
                            pago2.AnioCuota = Convert.ToInt32(this.cbAnio.SelectedItem);
                            pago2.Importe = Convert.ToInt32(this.txtImporte.Text);
                            pago2.Estado = BusinessEntities.Estados.Nuevo;
                            Pagol.Insertar(pago2);
                        }

                        this.informe(pago.NroSocio, nom, ape, "AñoCompleto", pago.AnioCuota, pago.Importe);
                        
                    } 
                    
                else                    
                 {
                    
                    if(this.lbMeses.SelectedItems.Count > 1)
                    {
                        bool salir = false;
                        foreach (var m in lbMeses.SelectedItems)
                        {
                            if ((m.ToString() == "AñoCompleto"))
                            {
                                this.Notificar("Error al seleccionar los meses", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                salir = true;
                                break;
                            }
                            
                        }
                        if (salir == false)
                        {
                            PagoCuotas pago = new PagoCuotas();

                            foreach (var k in lbMeses.SelectedItems)
                            {
                                string mes;
                                mes = k.ToString();
                                pago.NroSocio = Convert.ToInt32(this.txtNroSocio.Text);
                                pago.MesCuota = mes;
                                pago.AnioCuota = Convert.ToInt32(this.cbAnio.SelectedItem);
                                pago.Importe = Convert.ToInt32(this.txtImporte.Text);
                                pago.Estado = BusinessEntities.Estados.Nuevo;
                                Pagol.Insertar(pago);
                                this.informe(pago.NroSocio, nom, ape, pago.MesCuota, pago.AnioCuota, pago.Importe);
                            }    
                        }
                        
                     }

                    
                    else if(this.lbMeses.SelectedItems.Count == 1)
                            {
                                PagoCuotas pago = new PagoCuotas();
                                pago.NroSocio = Convert.ToInt32(this.txtNroSocio.Text);
                                pago.MesCuota = Convert.ToString(lbMeses.SelectedItem);
                                pago.AnioCuota = Convert.ToInt32(this.cbAnio.SelectedItem);
                                pago.Importe = Convert.ToInt32(this.txtImporte.Text);
                                pago.Estado = BusinessEntities.Estados.Nuevo;
                                Pagol.Insertar(pago);
                                this.informe(pago.NroSocio, nom, ape, pago.MesCuota, pago.AnioCuota, pago.Importe);
                            }

                    }
                 }

               

            catch (Exception exp)
            {
                this.Notificar(exp.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }

            this.Limpiar();
        } 


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
       
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }


    }
}
