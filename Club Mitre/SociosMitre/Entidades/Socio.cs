using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Socio : BusinessEntities
    {
        #region VARIABLES
        
        private int _NroSocio;
        private int _AnioCuota;
        private string _MesCuota;
        private string _Nombre;
        private string _Apellido;
         private int _Dni;
        private DateTime _FechaNac;
        private string _Tipo;
        private string _Categoria;
        private string _UltMes;
        private int _UltAnio;

  
        #endregion


        #region PROPIEDADES
        public int NroSocio
        {
            get { return _NroSocio; }
            set { _NroSocio = value; }
        }

        public int AnioCuota
        {
            get { return _AnioCuota; }
            set { _AnioCuota = value; }
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
       

        public int Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }
        

        public DateTime FechaNac
        {
            get { return _FechaNac; }
            set { _FechaNac = value; }
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


        public string UltMes
        {
            get { return _UltMes; }
            set { _UltMes = value; }
        }


        public int UltAnio
        {
            get { return _UltAnio; }
            set { _UltAnio = value; }
        }


        #endregion


        #region CONSTRUCTOR
        public Socio()
       { 
       }

        public Socio(int nroSoc, int anio_cuota, string mes_cuota, string nombre, string apellido, int doc, DateTime fechanac, string tipo, string categoria, string ultmes, int ultanio)
       {
           this.NroSocio = nroSoc;
           this.AnioCuota = anio_cuota;
           this.MesCuota = mes_cuota;
           this.Nombre = nombre;
           this.Apellido = apellido;
           this.Dni = doc;
           this.FechaNac = fechanac;
           this.Tipo = tipo;
           this.Categoria = categoria;
           this.UltMes = ultmes;
           this.UltAnio = ultanio;

       }

        #endregion
    }
}
