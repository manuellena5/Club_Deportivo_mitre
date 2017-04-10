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
        private int _Habilitado;
        private string _Nombre_categoria;
        private string _EstadoCategoria;

        

  
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

    public int Habilitado
    {
        get { return _Habilitado; }
        set { _Habilitado = value; }
    }


    public string Nombre_categoria
    {
        get { return _Nombre_categoria; }
        set { _Nombre_categoria = value; }
    }

    public string EstadoCategoria
    {
        get { return _EstadoCategoria; }
        set { _EstadoCategoria = value; }
    }
        #endregion


        #region CONSTRUCTOR
        public Categoria()
       { 
       }

        public Categoria(int id, string descripcion, double valor, DateTime fecha,int estadoCategoria,int habilitado,string nombre_categoria)
       {
           this.Id_categoria = id;
           this.Descripcion = descripcion;
           this.Valor = valor;
           this.Fecha_condicion = fecha;
           this.Habilitado = estadoCategoria;
           this.Nombre_categoria = nombre_categoria;
           this.Habilitado = habilitado;


       }

        #endregion
    }
}
