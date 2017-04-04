using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class PagoCuotas: BusinessEntities
   {
       #region VARIABLES

       private int _NroSocio;
        private string _MesCuota;
        private string _Nombre;
        private string _Apellido;
        private int _AnioCuota;
        private int _Importe;

       #endregion


        #region PROPIEDADES
        public int NroSocio
        {
            get { return _NroSocio; }
            set { _NroSocio = value; }
        }
       

        public string MesCuota
        {
            get { return _MesCuota; }
            set { _MesCuota = value; }
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
        #endregion


        #region CONSTRUCTOR

        public PagoCuotas()
        { }

       public PagoCuotas(int nrosocio,string mes,string nombre,string apellido,int anio,int importe)
       {
           this.NroSocio = nrosocio;
           this.MesCuota = mes;
           this.Nombre = nombre;
           this.Apellido = apellido;
           this.AnioCuota = anio;
           this.Importe = importe;

       }

        #endregion
    }
}
