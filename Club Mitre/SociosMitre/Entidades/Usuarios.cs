using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Usuarios : BusinessEntities
    { 
        private int _Id_Usuario;
        private string _Nombre_Usuario;
        private string _Clave;
        private string _Apellido;
        private string _Nombre;

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

                                             
        public int Id_Usuario
        {
            get { return _Id_Usuario; }
            set { _Id_Usuario = value; }
        }


     public string Nombre_Usuario
        {
            get { return _Nombre_Usuario; }
            set { _Nombre_Usuario = value; }
        }
     public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }




       public Usuarios()
       { 
       }
      
       public Usuarios(int id_usuario, string nombre_usuario, string clave,string nombre,string apellido)
       {
           this.Id_Usuario = id_usuario;
           this.Nombre_Usuario = nombre_usuario;
           this.Clave = clave;
           this.Nombre = nombre;
           this.Apellido = apellido;
       }
    }
}
