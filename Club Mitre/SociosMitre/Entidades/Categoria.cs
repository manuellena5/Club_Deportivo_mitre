using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria : BusinessEntities
    {


        #region VARIABLES
        
        private int _Id_Categoria;
        private double _Valor;
        private string _Descripcion;
        private DateTime _Fecha_Condicion;


        

       

  
        #endregion


        #region PROPIEDADES
        
        public int Id_categoria
    {
    get { return _Id_Categoria; }
     set { _Id_Categoria = value; }
    }
        

    public string Descripcion
    {
    get { return _Descripcion; }
    set { _Descripcion = value; }
    }
        

    public double Valor
    {
    get { return _Valor; }
    set { _Valor = value; }
    }
        

    public DateTime Fecha_condicion
    {
     get { return _Fecha_Condicion; }
     set { _Fecha_Condicion = value; }
    }



        #endregion


        #region CONSTRUCTOR
        public Categoria()
       { 
       }

        public Categoria(int id, string descripcion, double valor, DateTime fecha)
       {
           this.Id_categoria = id;
           this.Descripcion = descripcion;
           this.Valor = valor;
           this.Fecha_condicion = fecha;


       }

        #endregion
    }
}
