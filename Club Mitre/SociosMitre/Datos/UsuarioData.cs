using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class UsuarioData:Adapter
    {
        public List<Usuarios> GetAll()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            //int op;
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios", SqlConn);
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                while (drUsuarios.Read())
                {
                    Usuarios usr = new Usuarios();
                    usr.Id_Usuario = (int)drUsuarios["id_usuario"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Nombre_Usuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usuarios.Add(usr);

                }
                drUsuarios.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return usuarios;

        }


        public Usuarios GetOne(int ID)
        {

            Usuarios usr = new Usuarios();
            //int op;
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("select usr.id_usuario,usr.nombre_usuario,usr.clave,usr.nombre.usr.apellido from usuarios usr where usr.id_usuario=@ID", SqlConn);
                cmdUsuarios.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                if (drUsuarios.Read())
                {
                    usr.Id_Usuario = (int)drUsuarios["id_usuario"];
                    usr.Nombre_Usuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];


                }
                drUsuarios.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al buscar el usuario", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return usr;


        }

        protected void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete usuarios where id_usuario=@id_usuario", SqlConn);
                cmdDelete.Parameters.Add("@id_usuario", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
       
       protected void Update(Usuarios usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("update usuarios set nombre_usuario=@nombre_usuario,clave=@clave where id_usuario=@id_usuario", SqlConn);

                cmdSave.Parameters.Add("@id_usuario", SqlDbType.Int).Value = usuario.Id_Usuario;
                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.Nombre_Usuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;


                Convert.ToInt32(cmdSave.ExecuteNonQuery());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del usuario", Ex);
                throw ExcepcionManejada;
                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Usuarios usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("insert into usuarios(nombre_usuario,clave)" +
                                                     " values(@nombre_usuario,@clave)", SqlConn);

                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.Nombre_Usuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear usuario", Ex);
                throw ExcepcionManejada;
                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Usuarios usuario)
        {
            if (usuario.Estado == BusinessEntities.Estados.Eliminar)
            {
                this.Delete(usuario.Id_Usuario);
            }
            else if (usuario.Estado == BusinessEntities.Estados.Nuevo)
            {
                this.Insert(usuario);
            }

            else if (usuario.Estado == BusinessEntities.Estados.Modificar)
            {
                this.Update(usuario);
            }
            usuario.Estado = BusinessEntities.Estados.No_Modificar;
        }

        //public DataTable Login(Business.Entities.Usuario lg)
        //{
        //    DataTable dtresul = new DataTable("usuario");
        //    try
        //    {
        //        this.OpenConnection();
        //        SqlCommand cmlogin = new SqlCommand("select usr.id_usuario,per.nombre,per.apellido,usr.habilitado,per.tipo_persona,per.id_persona from usuarios usr inner join personas per on per.id_persona=usr.id_persona where usr.nombre_usuario like @nombre_usuario and usr.clave like @clave", SqlConn);

        //        SqlParameter parame = new SqlParameter();
        //        parame.ParameterName = "nombre_usuario";
        //        parame.SqlDbType = SqlDbType.VarChar;
        //        parame.Size = 50;
        //        parame.Value = lg.Nombre_Usuario;
        //        cmlogin.Parameters.Add(parame);

        //        SqlParameter parausuio = new SqlParameter();
        //        parausuio.ParameterName = "clave";
        //        parausuio.SqlDbType = SqlDbType.VarChar;
        //        parausuio.Size = 50;
        //        parausuio.Value = lg.Clave;
        //        cmlogin.Parameters.Add(parausuio);

        //        SqlDataAdapter drplan = new SqlDataAdapter(cmlogin);
        //        drplan.Fill(dtresul);
        //    }
        //    catch (Exception)
        //    {

        //        dtresul = null;
        //    }
        //    return dtresul;
        //}
    }
}
