using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class SociosLogic : BusinessLogic
    {
         private SociosData _SociosD;

        public SociosData SociosD
        {
            get { return _SociosD; }
            set { _SociosD = value; }
        }

       
        public SociosLogic()
        {
            SociosD = new SociosData();
        }

        public List<Socio> GetAll()
        {
            return SociosD.GetAll();
        }

        public List<Socio> TraerTodosEstadoActual()
        {
            return SociosD.TraerTodosEstadoActual();
        }

        public Socio GetOne(int id)
        {
            return SociosD.GetOne(id);
        }

        public List<Socio> TraerPorApellido(string apellido)
        {
            return SociosD.TraerPorApellido(apellido);
        }

        public List<Socio> TraerPorApellidoEstadoActual(string Txtbuscado)
        {
            return SociosD.TraerPorApellidoEstadoActual(Txtbuscado);
        }


        public void Delete(Socio soc)
        {
            SociosD.Save(soc);
        }
        public void Save(Socio soc)
        {
            SociosD.Save(soc);
        }
        public void Update(Socio soc)
        {
            SociosD.Save(soc);
        }
        public void Insertar(Socio soc)
        {
            SociosD.Save(soc);
        }

    }
}
