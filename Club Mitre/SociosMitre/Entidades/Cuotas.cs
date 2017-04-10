using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Cuotas: BusinessEntities
   {


       #region VARIABLES

       private int _NroSocio;
       private int _NroMesCuota;
        private string _Nombre;
        private string _Apellido;
        private string _Tipo;
        private string _Categoria;
        private int _AnioCuota;
        private int _Importe;
        private string _Mes;

        

       #endregion


        #region PROPIEDADES
        public int NroSocio
        {
            get { return _NroSocio; }
            set { _NroSocio = value; }
        }


        public int NroMesCuota
        {
            get { return _NroMesCuota; }
            set { _NroMesCuota = value; }
        }
        
       public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

       public string Apellido
       {
           get { return _Apellido; }
           set { _Apellido = value; }
       }

       public string Tipo
       {
           get { return _Tipo; }
           set { _Tipo = value; }
       }

       public string Categoria
       {
           get { return _Categoria; }
           set { _Categoria = value; }
       }

        public int AnioCuota
        {
            get { return _AnioCuota; }
            set { _AnioCuota = value; }
        }


        public int Importe
        {
            get { return _Importe; }
            set { _Importe = value; }
        }

        public string Mes
        {
            get { return _Mes; }
            set { _Mes = value; }
        }


        #endregion


        #region CONSTRUCTOR

        public Cuotas()
        { }

        public Cuotas(int nrosocio, int nromes, string nombre, string apellido, int anio, int importe,string mes)
       {
           this.NroSocio = nrosocio;
           this.NroMesCuota = nromes;
           this.Nombre = nombre;
           this.Apellido = apellido;
           this.AnioCuota = anio;
           this.Importe = importe;
           this.Mes = mes;

       }

        #endregion
    }
}
