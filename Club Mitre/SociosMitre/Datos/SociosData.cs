﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Datos
{
    public class SociosData : Adapter
    {

        enum meses
        {
            Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre,No_ha_abonado
        }


        public List<Socio> GetAll()
        {
            List<Socio> socios = new List<Socio>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdSocios = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.dni,soc.fecha_nac,soc.tipo,cat.nombre_categoria,soc.estado from Socios soc inner join categoria cat on cat.id_categoria = soc.id_categoria order by soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,cat.nombre_categoria", SqlConn);
                SqlDataReader drSocios = cmdSocios.ExecuteReader();
                while (drSocios.Read())
                {
                    Socio soc = new Socio();
                    soc.NroSocio = (int)drSocios["nro_socio"];
                    soc.Nombre = (string)drSocios["nombre"];
                    soc.Apellido = (string)drSocios["apellidos"];
                    soc.Dni = (int)drSocios["dni"];
                    soc.FechaNac = (DateTime)drSocios["fecha_nac"];
                    soc.Tipo = (string)drSocios["tipo"];
                    soc.Categoria = (string)drSocios["nombre_categoria"];

                    soc.Habilitado = Convert.ToInt32(drSocios["estado"]);

                    if ((Convert.ToInt32(drSocios["estado"])) == 0)
                    {
                        soc.EstadoSocio = "Inactivo";
                    }
                    else
                    {
                        soc.EstadoSocio = "Activo";
                    }
                    socios.Add(soc);

                }
                drSocios.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return socios;

        }


        public List<Socio> TraerTodosEstadoActual()
        {
            
            List<Socio> socios = new List<Socio>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdSocios = new SqlCommand("select * from [dbo].[vwListadoEstadoActualSocios]", SqlConn);
                SqlDataReader drSocios = cmdSocios.ExecuteReader();
                while (drSocios.Read())
                {
                    int bandera = 0;
                    Socio soc = new Socio();

                    soc.NroSocio = drSocios.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drSocios["nro_socio"]));
                    soc.Nombre = drSocios.IsDBNull(1) ? string.Empty : drSocios["nombre"].ToString();
                    soc.Apellido = drSocios.IsDBNull(2) ? string.Empty : ((string)drSocios["apellidos"]);
                    soc.Dni = drSocios.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drSocios["dni"]));
                    soc.FechaNac = drSocios.IsDBNull(4) ? Convert.ToDateTime(string.Empty) : Convert.ToDateTime(drSocios["fecha_nac"]);
                    soc.Tipo = drSocios.IsDBNull(5) ? string.Empty : drSocios["tipo"].ToString();
                    soc.Categoria = drSocios.IsDBNull(6) ? string.Empty : drSocios["nombre_categoria"].ToString();
                    soc.UltAnio = drSocios.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drSocios["anio_cuota"]));


                    foreach (int mes in Enum.GetValues(typeof(meses)))
                    {
                        if (mes == (int)drSocios["mes_cuota"])
                        {
                            soc.UltMes = Enum.GetName(typeof(meses),mes);
                            bandera = 1;
                            break;
                        }
                       
                    }
                    if (bandera == 0)
                    {
                        soc.UltMes = "No ha abonado";
                        soc.UltAnio = DateTime.Now.Year;
                        
                    }

                    soc.Habilitado = Convert.ToInt32(drSocios["estado"]);

                    if ((Convert.ToInt32(drSocios["estado"])) == 0)
                    {
                        soc.EstadoSocio = "Inactivo";
                    }
                    else
                    {
                        soc.EstadoSocio = "Activo";
                    }
                    socios.Add(soc);

                }
                drSocios.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return socios;

        }


        public List<Socio> TraerPorApellido(string Txtbuscado) 
        {

            List<Socio> Lista = new List<Socio>();
           try
           {
               this.OpenConnection();
               SqlCommand cmdsocios = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.dni,soc.fecha_nac,soc.tipo,cat.nombre_categoria,soc.estado from Socios soc inner join categoria cat on cat.id_categoria = soc.id_categoria where soc.apellidos like @textobuscar + '%' order by soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,cat.nombre_categoria", SqlConn);
               cmdsocios.Parameters.Add("@textobuscar", SqlDbType.VarChar, 50).Value = Txtbuscado;

               SqlDataReader drSocios = cmdsocios.ExecuteReader();
               while (drSocios.Read())
               {

                   Socio soc = new Socio();

                   soc.NroSocio = drSocios.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drSocios["nro_socio"]));
                   soc.Nombre = drSocios.IsDBNull(1) ? string.Empty : drSocios["nombre"].ToString();
                   soc.Apellido = drSocios.IsDBNull(2) ? string.Empty : ((string)drSocios["apellidos"]);
                   soc.Dni = drSocios.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drSocios["dni"]));
                   soc.FechaNac = drSocios.IsDBNull(4) ? Convert.ToDateTime(string.Empty) : Convert.ToDateTime(drSocios["fecha_nac"]);
                   soc.Tipo = drSocios.IsDBNull(5) ? string.Empty : drSocios["tipo"].ToString();
                   soc.Categoria = drSocios.IsDBNull(6) ? string.Empty : drSocios["nombre_categoria"].ToString();

                   soc.Habilitado = Convert.ToInt32(drSocios["estado"]);

                   if ((Convert.ToInt32(drSocios["estado"])) == 0)
                   {
                       soc.EstadoSocio = "Inactivo";
                   }
                   else
                   {
                       soc.EstadoSocio = "Activo";
                   }


                   Lista.Add(soc);
               }
           }
           catch (Exception ex)
           {
               Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
           }
           finally
           {
               this.CloseConnection();
           }
           return Lista;
            }


        public List<Socio> TraerPorApellidoEstadoActual(string Txtbuscado)
        {
            List<Socio> Lista = new List<Socio>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdsocios = new SqlCommand("select * from [dbo].[vwListadoEstadoActualSocios] where apellidos like @textobuscar + '%'", SqlConn);
                cmdsocios.Parameters.Add("@textobuscar", SqlDbType.VarChar, 50).Value = Txtbuscado;

                SqlDataReader drSocios = cmdsocios.ExecuteReader();
                while (drSocios.Read())
                {
                    Socio soc = new Socio();

                    int bandera = 0;

                    soc.NroSocio = drSocios.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drSocios["nro_socio"]));
                    soc.Nombre = drSocios.IsDBNull(1) ? string.Empty : drSocios["nombre"].ToString();
                    soc.Apellido = drSocios.IsDBNull(2) ? string.Empty : ((string)drSocios["apellidos"]);
                    soc.Dni = drSocios.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drSocios["dni"]));
                    soc.FechaNac = drSocios.IsDBNull(4) ? Convert.ToDateTime(string.Empty) : Convert.ToDateTime(drSocios["fecha_nac"]);
                    soc.Tipo = drSocios.IsDBNull(5) ? string.Empty : drSocios["tipo"].ToString();
                    soc.Categoria = drSocios.IsDBNull(6) ? string.Empty : drSocios["nombre_categoria"].ToString();
                    soc.UltAnio = drSocios.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drSocios["anio_cuota"]));
                    

                    foreach (int mes in Enum.GetValues(typeof(meses)))
                    {
                        if (mes == (int)drSocios["mes_cuota"])
                        {
                            soc.UltMes = Enum.GetName(typeof(meses), mes);
                            bandera = 1;
                            break;
                        }

                    }
                    if (bandera == 0)
                    {
                        soc.UltMes = "No ha abonado";
                        soc.UltAnio = DateTime.Now.Year;
                    }

                    soc.Habilitado = Convert.ToInt32(drSocios["estado"]);

                    if ((Convert.ToInt32(drSocios["estado"])) == 0)
                    {
                        soc.EstadoSocio = "Inactivo";
                    }
                    else
                    {
                        soc.EstadoSocio = "Activo";
                    }


                    Lista.Add(soc);
                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return Lista;
        }



        public Socio GetOne(int ID)
        {

            Socio soc = new Socio();
            //int op;
            try
            {
                this.OpenConnection();
                SqlCommand cmdSocios = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.dni,soc.fecha_nac,soc.tipo,cat.nombre_categoria,soc.estado,soc.id_categoria from Socios soc inner join categoria cat on cat.id_categoria = soc.id_categoria where soc.nro_socio =@ID order by soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,cat.nombre_categoria", SqlConn);
                cmdSocios.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                SqlDataReader drSocios = cmdSocios.ExecuteReader();
                if (drSocios.Read())
                {

                    soc.NroSocio = drSocios.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drSocios["nro_socio"]));
                    soc.Nombre = drSocios.IsDBNull(1) ? string.Empty : drSocios["nombre"].ToString();
                    soc.Apellido = drSocios.IsDBNull(2) ? string.Empty : ((string)drSocios["apellidos"]);
                    soc.Dni = drSocios.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drSocios["dni"]));
                    soc.FechaNac = drSocios.IsDBNull(4) ? Convert.ToDateTime(string.Empty) : Convert.ToDateTime(drSocios["fecha_nac"]);
                    soc.Tipo = drSocios.IsDBNull(5) ? string.Empty : drSocios["tipo"].ToString();
                    soc.Categoria = drSocios.IsDBNull(6) ? string.Empty : drSocios["nombre_categoria"].ToString();                  
                    soc.Habilitado = Convert.ToInt32(drSocios["estado"]);
                    soc.Id_categoria = Convert.ToInt32(drSocios["id_categoria"]);
                    
                    if ((Convert.ToInt32(drSocios["estado"])) == 0)
                    {
                        soc.EstadoSocio = "Inactivo";
                    }
                    else
                    {
                        soc.EstadoSocio = "Activo";
                    }

                }
                drSocios.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al buscar el socio", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return soc;


        }

        


        protected void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete socios where nro_socio=@nro_socio", SqlConn);
                cmdDelete.Parameters.Add("@nro_socio", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el socio", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Socio socio)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("update socios set nombre=@nombre,apellidos=@apellido,dni=@dni,fecha_nac=@fecha_nac,tipo=@tipo,estado=@estado,id_categoria=@id_categoria where nro_socio=@nro_socio", SqlConn);

                cmdSave.Parameters.Add("@nro_socio", SqlDbType.Int).Value = socio.NroSocio;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = socio.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = socio.Apellido;
                cmdSave.Parameters.Add("@dni", SqlDbType.Int).Value = socio.Dni;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.Date).Value = socio.FechaNac;
                cmdSave.Parameters.Add("@tipo", SqlDbType.VarChar, 50).Value = socio.Tipo;                
                cmdSave.Parameters.Add("@estado", SqlDbType.Bit).Value = socio.Habilitado;
                cmdSave.Parameters.Add("@id_categoria", SqlDbType.Int).Value = socio.Id_categoria;


                Convert.ToInt32(cmdSave.ExecuteNonQuery());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del socio", Ex);
                throw ExcepcionManejada;
                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Socio socio)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("insert into socios(nombre,apellidos,dni,fecha_nac,tipo,estado,id_categoria)" + 
                    "values(@nombre,@apellidos,@dni,@fecha_nac,@tipo,@estado,@id_categoria)", SqlConn);

                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = socio.Nombre;
                cmdSave.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = socio.Apellido;
                cmdSave.Parameters.Add("@dni", SqlDbType.Int).Value = socio.Dni;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.Date).Value = socio.FechaNac;
                cmdSave.Parameters.Add("@tipo", SqlDbType.VarChar, 50).Value = socio.Tipo;               
                cmdSave.Parameters.Add("@estado", SqlDbType.Bit).Value = socio.Habilitado;
                cmdSave.Parameters.Add("@id_categoria", SqlDbType.Int).Value = socio.Id_categoria;

                Convert.ToInt32(cmdSave.ExecuteNonQuery());

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear el socio", Ex);
                throw ExcepcionManejada;
                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Socio socio)
        {
            if (socio.Estado == BusinessEntities.Estados.Eliminar)
            {
                this.Delete(socio.NroSocio);
            }
            else if (socio.Estado == BusinessEntities.Estados.Nuevo)
            {
                this.Insert(socio);
            }

            else if (socio.Estado == BusinessEntities.Estados.Modificar)
            {
                this.Update(socio);
            }
            socio.Estado = BusinessEntities.Estados.No_Modificar;
        }



    }
}
