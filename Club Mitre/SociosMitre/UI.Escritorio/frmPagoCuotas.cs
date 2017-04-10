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
            llenarListBox();
        }


         public frmPagoCuotas(ModoForm modo):this()
        {
            Modo = modo;
        }



        public frmPagoCuotas(int ID,int mes,int anio, ModoForm modo):this() 
        {
            CuotasLogic cuo = new CuotasLogic();
            Modo = modo;
            mesOld = mes;
            anioOld = anio;
            CuotaActual = cuo.GetOne(ID,mes,anio);
            MapearDeDatos();
        }


        #endregion


        #region VARIABLES


        Cuotas _cuo = new Cuotas();


        public int nrosocio, bandera = 0, anioOld,mesOld;
        public string nom, ape,categoria,tipo,mensaje;

        enum Meses
        {
            Enero=1,Febrero,Marzo,Abril,Mayo,Junio,Julio,Agosto,Septiembre,Octubre,Noviembre,Diciembre,AñoCompleto
        }

        #endregion



        #region PROPIEDADES
       
        public Cuotas CuotaActual
        {
            get { return _cuo; }
            set { _cuo = value; }
        }
        
        #endregion



        #region METODOS

        public void llenarListBox()
        {
            lbMeses.Items.AddRange(typeof(Meses).GetEnumNames());
        }


        new private void Notificar(string mensaje)
        {
          MessageBox.Show(mensaje, "Registro de cuotas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private DialogResult NotificarYesNo(string  mensaje, string titulo, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            DialogResult result = MessageBox.Show(mensaje, "Registro de cuotas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            return result;
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

        public override void MapearDeDatos()
        {
            int ind = this.CuotaActual.NroMesCuota - 1;
            this.txtNroSocio.Text = Convert.ToString(this.CuotaActual.NroSocio);
            this.txtNombre.Text = this.CuotaActual.Nombre;
            this.txtApellido.Text = this.CuotaActual.Apellido;
            this.txtTipo.Text = Convert.ToString(this.CuotaActual.Tipo);
            this.txtCategoria.Text = Convert.ToString(this.CuotaActual.Categoria);
            this.lbMeses.SelectedIndex = ind;
            this.cbAnio.Text = Convert.ToString(this.CuotaActual.AnioCuota);
            this.txtImporte.Text = Convert.ToString(this.CuotaActual.Importe);
            
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
                    
                    

                    if (this.lbMeses.SelectedItems.Count > 1 || (Convert.ToString(this.lbMeses.SelectedItem)) == "AñoCompleto")
                     {
                         bandera = 1; 
                         break;
                     }
                     else
                            {

                                int indice = Convert.ToInt32(lbMeses.SelectedIndex) + 1;
                                CuotaActual.NroSocio = Convert.ToInt32(this.txtNroSocio.Text);
                                CuotaActual.NroMesCuota = indice;
                                CuotaActual.Nombre = this.txtNombre.Text;
                                CuotaActual.Apellido = this.txtApellido.Text;
                                CuotaActual.AnioCuota = Convert.ToInt32(this.cbAnio.SelectedItem);
                                CuotaActual.Importe = Convert.ToInt32(this.txtImporte.Text);
                                CuotaActual.Estado = BusinessEntities.Estados.Nuevo;
                                mensaje = "Se va a registrar el pago la cuota del socio: ";
                                
                            }

                   break; 

                case ModoForm.Baja:
                    CuotaActual.Estado = BusinessEntities.Estados.Eliminar;
                    mensaje = "Se va a eliminar el pago de la cuota del socio: ";
                    break;

                case ModoForm.Modificacion:
                    CuotaActual.NroSocio = Convert.ToInt32(this.txtNroSocio.Text);
                    CuotaActual.Nombre = this.txtNombre.Text;
                    CuotaActual.Apellido = this.txtApellido.Text;
                    CuotaActual.Tipo = this.txtTipo.Text;
                    CuotaActual.Categoria = this.txtCategoria.Text;
                    int indic = Convert.ToInt32(lbMeses.SelectedIndex) + 1;
                    CuotaActual.NroMesCuota = indic;
                    CuotaActual.AnioCuota = Convert.ToInt32(this.cbAnio.SelectedItem);
                    CuotaActual.Importe = Convert.ToInt32(this.txtImporte.Text);
                    CuotaActual.Estado = BusinessEntities.Estados.Modificar;
                    mensaje = "Se va a editar el pago la cuota del socio: ";
                    break;

                case ModoForm.Consulta:
                    CuotaActual.Estado = BusinessEntities.Estados.No_Modificar;

                    break;

                default:
                    break;
            }    }



        public void MapeoCompuesto ()
        {
            Cuotas cuo = new Cuotas();
            

            if ((Convert.ToString(this.lbMeses.SelectedItem)) == "AñoCompleto" && this.lbMeses.SelectedItems.Count == 1)
            {
                CuotasLogic cuoact = new CuotasLogic();
                cuo.NroSocio = Convert.ToInt32(this.txtNroSocio.Text);
                cuo.AnioCuota = Convert.ToInt32(this.cbAnio.SelectedItem);
                cuo.Importe = Convert.ToInt32(this.txtImporte.Text);
                cuo.Nombre = this.txtNombre.Text;
                cuo.Apellido = this.txtApellido.Text;

                mensaje = "Se va a registrar el pago de la cuota del socio: " + "\n" + "Nro Socio: " + cuo.NroSocio + "\n" + "Nombre: " + cuo.Nombre + " " + cuo.Apellido + "\n";

                mensaje = mensaje + "Mes: " + Meses.AñoCompleto.ToString() + "\n" + "Año: " + CuotaActual.AnioCuota + "\n" + "Importe: " + CuotaActual.Importe;

                DialogResult resultado = NotificarYesNo(mensaje, "Pago de cuota", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultado == DialogResult.No)
                    {
                        
                    }
                else
                {
                    for (int k = 1; k <= 12; k++)
                    {
                        Cuotas pago2 = new Cuotas();
                        //string mess;
                        //mess = lbMeses.Items[k].ToString();
                        pago2.NroSocio = Convert.ToInt32(this.txtNroSocio.Text);
                        pago2.NroMesCuota = k;
                        pago2.AnioCuota = Convert.ToInt32(this.cbAnio.SelectedItem);
                        pago2.Importe = Convert.ToInt32(this.txtImporte.Text);
                        pago2.Estado = BusinessEntities.Estados.Nuevo;

                        cuoact.Insertar(pago2);


                    }
                }
               

                
            }

            else if (this.lbMeses.SelectedItems.Count > 1)
            {
                CuotasLogic cuoact = new CuotasLogic();
                foreach (var k in lbMeses.SelectedIndices)
                {
                    int indice = Convert.ToInt32(k) + 1;
                    string mesPago;
                    mesPago = lbMeses.Items[Convert.ToInt32(k)].ToString();
                    cuo.NroSocio = Convert.ToInt32(this.txtNroSocio.Text);
                    cuo.NroMesCuota = indice;
                    cuo.AnioCuota = Convert.ToInt32(this.cbAnio.SelectedItem);
                    cuo.Importe = Convert.ToInt32(this.txtImporte.Text);
                    cuo.Nombre = this.txtNombre.Text;
                    cuo.Apellido = this.txtApellido.Text;
                    cuo.Estado = BusinessEntities.Estados.Nuevo;

                    mensaje = "Se va a registrar el pago de la cuota del socio: " + "\n" + "Nro Socio: " + cuo.NroSocio + "\n" + "Nombre: " + cuo.Nombre + " " + cuo.Apellido + "\n";

                    mensaje = mensaje + "Mes: " + mesPago + "\n" + "Año: " + cuo.AnioCuota + "\n" + "Importe: " + cuo.Importe;
                    
                    DialogResult resultado = NotificarYesNo(mensaje, "Pago de cuota", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resultado == DialogResult.No)
                    {
                        break;
                    }
                    else
                    {
                        cuoact.Insertar(cuo);
                    }

                }
            }
                  
        }
        


        public override void GuardarCambios()
        {
            
            
                MapearADatos();
                if (bandera == 0)
                {
                    CuotasLogic cuo = new CuotasLogic();
                    mensaje = mensaje + "\n" + "Nro Socio: " + CuotaActual.NroSocio + "\n" + "Nombre: " + CuotaActual.Nombre + " " + CuotaActual.Apellido + "\n" + "Mes: " + lbMeses.SelectedItem.ToString() + "\n" + "Año: " + CuotaActual.AnioCuota + "\n" + "Importe: " + CuotaActual.Importe;
                    switch (CuotaActual.Estado)
                    {
                        case BusinessEntities.Estados.Eliminar:

                            DialogResult resultado1 = NotificarYesNo(mensaje,"Eliminar cuota", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (resultado1 == DialogResult.No)
                            {
                                break;
                            }
                            else
                            {
                                cuo.Save(CuotaActual);
                            }                            

                            break;
                        case BusinessEntities.Estados.Nuevo:
                            DialogResult resultado2 = NotificarYesNo(mensaje, "Pago de cuota", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (resultado2 == DialogResult.No)
                            {
                                break;
                            }
                            else
                            {
                                cuo.Save(CuotaActual);
                            }   

                            break;
                        case BusinessEntities.Estados.Modificar:

                             DialogResult resultado3 = NotificarYesNo(mensaje,"Edicion de cuota", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (resultado3 == DialogResult.No)
                            {
                                break;
                            }
                            else
                            {   
                                cuo.Update(CuotaActual,anioOld,mesOld);
                            }  


                            break;
                        case BusinessEntities.Estados.No_Modificar:
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    MapeoCompuesto();
                }
                
            
            

        }


        public override bool Validar()
        {
            if (this.lbMeses.SelectedItems.Count == 0 || this.cbAnio.Text == string.Empty)
                {
                    
                Notificar("Faltan ingresar datos o ingresó datos incorrectos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;

                }
           
            else if(this.lbMeses.SelectedItems.Count > 1)
                    {
                        foreach (var m in lbMeses.SelectedItems)
                        {
                            if ((m.ToString() == "AñoCompleto"))
                            {
                                this.Notificar("Error al seleccionar los meses", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                               
                            }
                            break;
                            
                        }
                    }
            
                return true;    
            
                
            }

               

        public void BloquearControles (bool valor)
        {
            this.txtImporte.Enabled = !valor;
            this.cbAnio.Enabled = !valor;
            this.lbMeses.Enabled = !valor;

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
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        } 


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }



       
        #endregion

       
        
        
        
        
        
        
        
        
        
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        


    }
}
