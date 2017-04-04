using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BusinessEntities
    {
        #region VARIABLES
        private int _ID; 
        private Estados _Estado;
        #endregion


        #region PROPIEDADES
       
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public Estados Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public BusinessEntities()
        {
            this.Estado = Estados.Nuevo;
        }

        public enum Estados
        { 
            Eliminar,
            Nuevo,
            Modificar,
            No_Modificar
        }

        #endregion
    }
}
