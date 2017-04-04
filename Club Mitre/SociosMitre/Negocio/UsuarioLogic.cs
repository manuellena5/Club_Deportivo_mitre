using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class UsuarioLogic: BusinessLogic
    {

        private UsuarioData _UsuarioD;

        public UsuarioData UsuarioD
        {
            get { return _UsuarioD; }
            set { _UsuarioD = value; }
        }

       
        public UsuarioLogic()
        {
            UsuarioD = new UsuarioData();
        }

        public List<Usuarios> GetAll()
        {
            return UsuarioD.GetAll();
        }


        public Usuarios GetOne(int id)
        {
            return UsuarioD.GetOne(id);
        }
        public void Delete(Usuarios usur)
        {
            UsuarioD.Save(usur);
        }
        public void Save(Usuarios usur)
        {
            UsuarioD.Save(usur);
        }
        public void Update(Usuarios usur)
        {
            UsuarioD.Save(usur);
        }
        public void Insertar(Usuarios usur)
        {
            UsuarioD.Save(usur);
        }

        //public static DataTable Login(string usuario, string password)
        //{
        //    Usuario usr = new Usuario();
        //    UsuarioAdapter usradap = new UsuarioAdapter();
        //    usr.Nombre_Usuario = usuario;
        //    usr.Clave = password;
        //    return usradap.Login(usr);
        //}


    }
}
