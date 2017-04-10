using System;
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
    public class CuotasData:Adapter
    {

        enum meses
        {
            Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre, No_ha_abonado
        }


        public List<Cuotas> GetAll()
        {
            List<Cuotas> Cuo = new List<Cuotas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,cat.nombre_categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio inner join categoria cat on cat.id_categoria = soc.id_categoria order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                SqlDataReader drcuotas = cmdpagos.ExecuteReader();
                while (drcuotas.Read())
                {
                    int bandera = 0;
                    Cuotas cuo = new Cuotas();

                    cuo.NroSocio = drcuotas.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["nro_socio"]));
                    cuo.Nombre = drcuotas.IsDBNull(1) ? string.Empty : drcuotas["nombre"].ToString();
                    cuo.Apellido = drcuotas.IsDBNull(2) ? string.Empty : drcuotas["apellidos"].ToString();
                    cuo.Tipo = drcuotas.IsDBNull(3) ? string.Empty : drcuotas["tipo"].ToString();
                    cuo.Categoria = drcuotas.IsDBNull(4) ? string.Empty : drcuotas["nombre_categoria"].ToString();
                    cuo.NroMesCuota = drcuotas.IsDBNull(5) ? Convert.ToInt32(string.Empty) : Convert.ToInt32(drcuotas["mes_cuota"]);
                    cuo.AnioCuota = drcuotas.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["anio_cuota"]));
                    cuo.Importe = drcuotas.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["importe"]));

                    foreach (int mes in Enum.GetValues(typeof(meses)))
                    {
                        if (mes == (int)drcuotas["mes_cuota"])
                        {
                            cuo.Mes = Enum.GetName(typeof(meses), mes);
                            bandera = 1;
                            break;
                        }

                    }
                    if (bandera == 0)
                    {
                        cuo.Mes = "No ha abonado";
                       
                    }

                    
                    Cuo.Add(cuo);

                }
                drcuotas.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return Cuo;

        }


        public Cuotas GetOne(int id,int mes,int anio)
        {
            Cuotas cuo = new Cuotas();
            try
            {
                this.OpenConnection();
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,cat.nombre_categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio inner join categoria cat on cat.id_categoria = soc.id_categoria where soc.nro_socio = @id and cuo.mes_cuota=@mes and cuo.anio_cuota = @anio order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                cmdpagos.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdpagos.Parameters.Add("@mes", SqlDbType.Int).Value = mes;
                cmdpagos.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
                SqlDataReader drcuotas = cmdpagos.ExecuteReader();
                if (drcuotas.Read())
                {
                    int bandera = 0;
                    cuo.NroSocio = drcuotas.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["nro_socio"]));
                    cuo.Nombre = drcuotas.IsDBNull(1) ? string.Empty : drcuotas["nombre"].ToString();
                    cuo.Apellido = drcuotas.IsDBNull(2) ? string.Empty : drcuotas["apellidos"].ToString();
                    cuo.Tipo = drcuotas.IsDBNull(3) ? string.Empty : drcuotas["tipo"].ToString();
                    cuo.Categoria = drcuotas.IsDBNull(4) ? string.Empty : drcuotas["nombre_categoria"].ToString();
                    cuo.NroMesCuota = drcuotas.IsDBNull(5) ? Convert.ToInt32(string.Empty) : Convert.ToInt32(drcuotas["mes_cuota"]);
                    cuo.AnioCuota = drcuotas.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["anio_cuota"]));
                    cuo.Importe = drcuotas.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["importe"]));

                    foreach (int mes1 in Enum.GetValues(typeof(meses)))
                    {
                        if (mes1 == (int)drcuotas["mes_cuota"])
                        {
                            cuo.Mes = Enum.GetName(typeof(meses), mes1);
                            bandera = 1;
                            break;
                        }

                    }
                    if (bandera == 0)
                    {
                        cuo.Mes = "No ha abonado";
                    }
                    

                }
                drcuotas.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return cuo;

        }


        public List<Cuotas> TraerPorSocio(int id)
        {
            List<Cuotas> pagCuo = new List<Cuotas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,cat.nombre_categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio inner join categoria cat on cat.id_categoria = soc.id_categoria where soc.nro_socio = @id order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                cmdpagos.Parameters.Add ("@id", SqlDbType.Int).Value = id;
                SqlDataReader drcuotas = cmdpagos.ExecuteReader();
                while (drcuotas.Read())
                {
                    int bandera = 0;
                    Cuotas cuo = new Cuotas();
                    cuo.NroSocio = drcuotas.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["nro_socio"]));
                    cuo.Nombre = drcuotas.IsDBNull(1) ? string.Empty : drcuotas["nombre"].ToString();
                    cuo.Apellido = drcuotas.IsDBNull(2) ? string.Empty : drcuotas["apellidos"].ToString();
                    cuo.Tipo = drcuotas.IsDBNull(3) ? string.Empty : drcuotas["tipo"].ToString();
                    cuo.Categoria = drcuotas.IsDBNull(4) ? string.Empty : drcuotas["nombre_categoria"].ToString();
                    cuo.NroMesCuota = drcuotas.IsDBNull(5) ? Convert.ToInt32(string.Empty) : Convert.ToInt32(drcuotas["mes_cuota"]);
                    cuo.AnioCuota = drcuotas.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["anio_cuota"]));
                    cuo.Importe = drcuotas.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["importe"]));
                    foreach (int mes in Enum.GetValues(typeof(meses)))
                    {
                        if (mes == (int)drcuotas["mes_cuota"])
                        {
                            cuo.Mes = Enum.GetName(typeof(meses), mes);
                            bandera = 1;
                            break;
                        }

                    }
                    if (bandera == 0)
                    {
                        cuo.Mes = "No ha abonado";
                    }
                    pagCuo.Add(cuo);

                }
                drcuotas.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return pagCuo;

        }


        public List<Cuotas> TraerPorMes(int Mes)
        {
            List<Cuotas> Lista = new List<Cuotas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,cat.nombre_categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio inner join categoria cat on cat.id_categoria = soc.id_categoria where cuo.mes_cuota = @mes order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                cmdpagos.Parameters.Add("@mes", SqlDbType.Int).Value = Mes;

                SqlDataReader drcuotas = cmdpagos.ExecuteReader();
                while (drcuotas.Read())
                {
                    int bandera = 0;
                    Cuotas cuo = new Cuotas();

                    cuo.NroSocio = drcuotas.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["nro_socio"]));
                    cuo.Nombre = drcuotas.IsDBNull(1) ? string.Empty : drcuotas["nombre"].ToString();
                    cuo.Apellido = drcuotas.IsDBNull(2) ? string.Empty : drcuotas["apellidos"].ToString();
                    cuo.Tipo = drcuotas.IsDBNull(3) ? string.Empty : drcuotas["tipo"].ToString();
                    cuo.Categoria = drcuotas.IsDBNull(4) ? string.Empty : drcuotas["nombre_categoria"].ToString();
                    cuo.NroMesCuota = drcuotas.IsDBNull(5) ? Convert.ToInt32(string.Empty) : Convert.ToInt32(drcuotas["mes_cuota"]);
                    cuo.AnioCuota = drcuotas.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["anio_cuota"]));
                    cuo.Importe = drcuotas.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["importe"]));

                    foreach (int mes in Enum.GetValues(typeof(meses)))
                    {
                        if (mes == (int)drcuotas["mes_cuota"])
                        {
                            cuo.Mes = Enum.GetName(typeof(meses), mes);
                            bandera = 1;
                            break;
                        }

                    }
                    if (bandera == 0)
                    {
                        cuo.Mes = "No ha abonado";
                    }

                    Lista.Add(cuo);
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


        public List<Cuotas> TraerPorMesParaSocio(int Mes,int id)
        {
            List<Cuotas> Lista = new List<Cuotas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,cat.nombre_categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio inner join categoria cat on cat.id_categoria = soc.id_categoria where cuo.mes_cuota = @mes and soc.nro_socio = @id order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                cmdpagos.Parameters.Add("@mes", SqlDbType.Int).Value = Mes;
                cmdpagos.Parameters.Add("@id", SqlDbType.Int).Value = id;

                SqlDataReader drcuotas = cmdpagos.ExecuteReader();
                while (drcuotas.Read())
                {
                    int bandera = 0;
                    Cuotas cuo = new Cuotas();

                    cuo.NroSocio = drcuotas.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["nro_socio"]));
                    cuo.Nombre = drcuotas.IsDBNull(1) ? string.Empty : drcuotas["nombre"].ToString();
                    cuo.Apellido = drcuotas.IsDBNull(2) ? string.Empty : drcuotas["apellidos"].ToString();
                    cuo.Tipo = drcuotas.IsDBNull(3) ? string.Empty : drcuotas["tipo"].ToString();
                    cuo.Categoria = drcuotas.IsDBNull(4) ? string.Empty : drcuotas["nombre_categoria"].ToString();
                    cuo.NroMesCuota = drcuotas.IsDBNull(5) ? Convert.ToInt32(string.Empty) : Convert.ToInt32(drcuotas["mes_cuota"]);
                    cuo.AnioCuota = drcuotas.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["anio_cuota"]));
                    cuo.Importe = drcuotas.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["importe"]));

                    foreach (int mes in Enum.GetValues(typeof(meses)))
                    {
                        if (mes == (int)drcuotas["mes_cuota"])
                        {
                            cuo.Mes = Enum.GetName(typeof(meses), mes);
                            bandera = 1;
                            break;
                        }

                    }
                    if (bandera == 0)
                    {
                        cuo.Mes = "No ha abonado";
                    }
                    Lista.Add(cuo);
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


        public List<Cuotas> TraerPorAño(string Txtbuscado)
        {
            List<Cuotas> Lista = new List<Cuotas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,cat.nombre_categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio inner join categoria cat on cat.id_categoria = soc.id_categoria where cuo.anio_cuota like @textobuscar + '%' order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                cmdpagos.Parameters.Add("@textobuscar", SqlDbType.VarChar, 50).Value = Txtbuscado;

                SqlDataReader drcuotas = cmdpagos.ExecuteReader();
                while (drcuotas.Read())
                {
                    int bandera = 0;
                    Cuotas cuo = new Cuotas();

                    cuo.NroSocio = drcuotas.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["nro_socio"]));
                    cuo.Nombre = drcuotas.IsDBNull(1) ? string.Empty : drcuotas["nombre"].ToString();
                    cuo.Apellido = drcuotas.IsDBNull(2) ? string.Empty : drcuotas["apellidos"].ToString();
                    cuo.Tipo = drcuotas.IsDBNull(3) ? string.Empty : drcuotas["tipo"].ToString();
                    cuo.Categoria = drcuotas.IsDBNull(4) ? string.Empty : drcuotas["nombre_categoria"].ToString();
                    cuo.NroMesCuota = drcuotas.IsDBNull(5) ? Convert.ToInt32(string.Empty) : Convert.ToInt32(drcuotas["mes_cuota"]);
                    cuo.AnioCuota = drcuotas.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["anio_cuota"]));
                    cuo.Importe = drcuotas.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["importe"]));

                    foreach (int mes in Enum.GetValues(typeof(meses)))
                    {
                        if (mes == (int)drcuotas["mes_cuota"])
                        {
                            cuo.Mes = Enum.GetName(typeof(meses), mes);
                            bandera = 1;
                            break;
                        }

                    }
                    if (bandera == 0)
                    {
                        cuo.Mes = "No ha abonado";
                    }

                    Lista.Add(cuo);
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


        public List<Cuotas> TraerPorAñoParaSocio(string Txtbuscado,int id)
        {
            List<Cuotas> Lista = new List<Cuotas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,cat.nombre_categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio inner join categoria cat on cat.id_categoria = soc.id_categoria where cuo.anio_cuota like @textobuscar + '%' and soc.nro_socio = @id order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                cmdpagos.Parameters.Add("@textobuscar", SqlDbType.VarChar, 50).Value = Txtbuscado;
                cmdpagos.Parameters.Add("@id", SqlDbType.Int).Value = id;

                SqlDataReader drcuotas = cmdpagos.ExecuteReader();
                while (drcuotas.Read())
                {
                    int bandera = 0;
                    Cuotas cuo = new Cuotas();

                    cuo.NroSocio = drcuotas.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["nro_socio"]));
                    cuo.Nombre = drcuotas.IsDBNull(1) ? string.Empty : drcuotas["nombre"].ToString();
                    cuo.Apellido = drcuotas.IsDBNull(2) ? string.Empty : drcuotas["apellidos"].ToString();
                    cuo.Tipo = drcuotas.IsDBNull(3) ? string.Empty : drcuotas["tipo"].ToString();
                    cuo.Categoria = drcuotas.IsDBNull(4) ? string.Empty : drcuotas["nombre_categoria"].ToString();
                    cuo.NroMesCuota = drcuotas.IsDBNull(5) ? Convert.ToInt32(string.Empty) : Convert.ToInt32(drcuotas["mes_cuota"]);
                    cuo.AnioCuota = drcuotas.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["anio_cuota"]));
                    cuo.Importe = drcuotas.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drcuotas["importe"]));

                    foreach (int mes in Enum.GetValues(typeof(meses)))
                    {
                        if (mes == (int)drcuotas["mes_cuota"])
                        {
                            cuo.Mes = Enum.GetName(typeof(meses), mes);
                            bandera = 1;
                            break;
                        }

                    }
                    if (bandera == 0)
                    {
                        cuo.Mes = "No ha abonado";
                    }


                    Lista.Add(cuo);
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

       


        protected void Delete(int ID, int mes, int anio)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete Cuotas where nro_socio=@nro_socio and mes_cuota=@mes_cuota and anio_cuota=@anio_cuota", SqlConn);
                cmdDelete.Parameters.Add("@nro_socio", SqlDbType.Int).Value = ID;
                cmdDelete.Parameters.Add("@mes_cuota", SqlDbType.Int).Value = mes;
                cmdDelete.Parameters.Add("@anio_cuota", SqlDbType.Int).Value = anio;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el pago", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Cuotas pago,int anioOld,int mesOld)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("update Cuotas set nro_socio = @nro_socio, mes_cuota=@mes_cuota,anio_cuota=@anio_cuota,importe=@importe where nro_socio=@nro_socio and mes_cuota = @mesold and anio_cuota = @anioold", SqlConn);

                cmdSave.Parameters.Add("@nro_socio", SqlDbType.Int).Value = pago.NroSocio;
                cmdSave.Parameters.Add("@mes_cuota", SqlDbType.Int).Value = pago.NroMesCuota;
                cmdSave.Parameters.Add("@anio_cuota", SqlDbType.Int).Value = pago.AnioCuota;
                cmdSave.Parameters.Add("@mesold", SqlDbType.Int).Value = mesOld;
                cmdSave.Parameters.Add("@anioold", SqlDbType.Int).Value = anioOld;
                cmdSave.Parameters.Add("@importe", SqlDbType.Int).Value = pago.Importe;


               cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del pago", Ex);
                throw ExcepcionManejada;
                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Cuotas pago)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("insert into Cuotas(nro_socio,mes_cuota,anio_cuota,importe)" +
                    "values(@nro_socio,@mes_cuota,@anio_cuota,@importe)", SqlConn);

                cmdSave.Parameters.Add("@nro_socio", SqlDbType.Int).Value = pago.NroSocio;
                cmdSave.Parameters.Add("@mes_cuota", SqlDbType.Int).Value = pago.NroMesCuota;
                cmdSave.Parameters.Add("@anio_cuota", SqlDbType.Int).Value = pago.AnioCuota;
                cmdSave.Parameters.Add("@importe", SqlDbType.Int).Value = pago.Importe;

                Convert.ToInt32(cmdSave.ExecuteNonQuery());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear el pago", Ex);
                throw ExcepcionManejada;
                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Cuotas pago)
        {
            if (pago.Estado == BusinessEntities.Estados.Eliminar)
            {
                this.Delete(pago.NroSocio,pago.NroMesCuota,pago.AnioCuota);
            }
            else if (pago.Estado == BusinessEntities.Estados.Nuevo)
            {
                this.Insert(pago);
            }
            else
            {
                pago.Estado = BusinessEntities.Estados.No_Modificar;
            }
            
           
        }

        public void Editar (Cuotas pago,int anioOld,int mesOld)
        {
            if (pago.Estado == BusinessEntities.Estados.Modificar)
            {
                this.Update(pago,anioOld,mesOld);
            }
        }




    }
}
