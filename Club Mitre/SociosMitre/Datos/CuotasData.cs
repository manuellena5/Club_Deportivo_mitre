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
            List<Cuotas> pagCuo = new List<Cuotas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,soc.categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                SqlDataReader drpagos = cmdpagos.ExecuteReader();
                while (drpagos.Read())
                {
                    Cuotas pag = new Cuotas();
                    pag.NroSocio = (int)drpagos["nro_socio"];
                    pag.Nombre = (string)drpagos["nombre"];
                    pag.Apellido = (string)drpagos["apellidos"];
                    pag.Tipo = (string)drpagos["tipo"];
                    pag.Categoria = (string)drpagos["categoria"];
                    pag.MesCuota = (int)drpagos["mes_cuota"];
                    pag.AnioCuota = (int)drpagos["anio_cuota"];
                    pag.Importe = (int)drpagos["importe"];

                    
                    pagCuo.Add(pag);

                }
                drpagos.Close();
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


        public Cuotas GetOne(int id,int mes,int anio)
        {
            Cuotas cuo = new Cuotas();
            try
            {
                this.OpenConnection();
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,soc.categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio where soc.nro_socio = @id and cuo.mes_cuota=@mes and cuo.anio_cuota = @anio order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                cmdpagos.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdpagos.Parameters.Add("@mes", SqlDbType.Int).Value = mes;
                cmdpagos.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
                SqlDataReader drpagos = cmdpagos.ExecuteReader();
                if (drpagos.Read())
                {
                    
                    cuo.NroSocio = (int)drpagos["nro_socio"];
                    cuo.Nombre = (string)drpagos["nombre"];
                    cuo.Apellido = (string)drpagos["apellidos"];
                    cuo.Tipo = (string)drpagos["tipo"];
                    cuo.Categoria = (string)drpagos["categoria"];
                    cuo.MesCuota = (int)drpagos["mes_cuota"];
                    cuo.AnioCuota = (int)drpagos["anio_cuota"];
                    cuo.Importe = (int)drpagos["importe"];
                    

                }
                drpagos.Close();
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
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,soc.categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio where soc.nro_socio = @id order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                cmdpagos.Parameters.Add ("@id", SqlDbType.Int).Value = id;
                SqlDataReader drpagos = cmdpagos.ExecuteReader();
                while (drpagos.Read())
                {
                    Cuotas pag = new Cuotas();
                    pag.NroSocio = (int)drpagos["nro_socio"];
                    pag.Nombre = (string)drpagos["nombre"];
                    pag.Apellido = (string)drpagos["apellidos"];
                    pag.Tipo = (string)drpagos["tipo"];
                    pag.Categoria = (string)drpagos["categoria"];
                    pag.MesCuota = (int)drpagos["mes_cuota"];
                    pag.AnioCuota = (int)drpagos["anio_cuota"];
                    pag.Importe = (int)drpagos["importe"];
                    pagCuo.Add(pag);

                }
                drpagos.Close();
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
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,soc.categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio where cuo.mes_cuota = @mes order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                cmdpagos.Parameters.Add("@mes", SqlDbType.Int).Value = Mes;

                SqlDataReader drpagos = cmdpagos.ExecuteReader();
                while (drpagos.Read())
                {
                    Cuotas pc = new Cuotas();

                    pc.NroSocio = drpagos.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["nro_socio"]));
                    pc.Nombre = drpagos.IsDBNull(1) ? string.Empty : drpagos["nombre"].ToString();
                    pc.Apellido = drpagos.IsDBNull(2) ? string.Empty : drpagos["apellidos"].ToString();
                    pc.Tipo = drpagos.IsDBNull(3) ? string.Empty : drpagos["tipo"].ToString();
                    pc.Categoria = drpagos.IsDBNull(4) ? string.Empty : drpagos["categoria"].ToString();
                    pc.MesCuota = drpagos.IsDBNull(5) ? Convert.ToInt32(string.Empty) : Convert.ToInt32(drpagos["mes_cuota"]);
                    pc.AnioCuota = drpagos.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["anio_cuota"]));
                    pc.Importe = drpagos.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["importe"]));
                    
                    Lista.Add(pc);
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
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,soc.categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio where cuo.mes_cuota = @mes and soc.nro_socio = @id order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                cmdpagos.Parameters.Add("@mes", SqlDbType.Int).Value = Mes;
                cmdpagos.Parameters.Add("@id", SqlDbType.Int).Value = id;

                SqlDataReader drpagos = cmdpagos.ExecuteReader();
                while (drpagos.Read())
                {
                    Cuotas pc = new Cuotas();

                    pc.NroSocio = drpagos.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["nro_socio"]));
                    pc.Nombre = drpagos.IsDBNull(1) ? string.Empty : drpagos["nombre"].ToString();
                    pc.Apellido = drpagos.IsDBNull(2) ? string.Empty : drpagos["apellidos"].ToString();
                    pc.Tipo = drpagos.IsDBNull(3) ? string.Empty : drpagos["tipo"].ToString();
                    pc.Categoria = drpagos.IsDBNull(4) ? string.Empty : drpagos["categoria"].ToString();
                    pc.MesCuota = drpagos.IsDBNull(5) ? Convert.ToInt32(string.Empty) : Convert.ToInt32(drpagos["mes_cuota"]);
                    pc.AnioCuota = drpagos.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["anio_cuota"]));
                    pc.Importe = drpagos.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["importe"]));

                    Lista.Add(pc);
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
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,soc.categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio where cuo.anio_cuota like @textobuscar + '%' order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                cmdpagos.Parameters.Add("@textobuscar", SqlDbType.VarChar, 50).Value = Txtbuscado;

                SqlDataReader drpagos = cmdpagos.ExecuteReader();
                while (drpagos.Read())
                {
                    Cuotas pc = new Cuotas();

                    pc.NroSocio = drpagos.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["nro_socio"]));
                    pc.Nombre = drpagos.IsDBNull(1) ? string.Empty : drpagos["nombre"].ToString();
                    pc.Apellido = drpagos.IsDBNull(2) ? string.Empty : drpagos["apellidos"].ToString();
                    pc.Tipo = drpagos.IsDBNull(3) ? string.Empty : drpagos["tipo"].ToString();
                    pc.Categoria = drpagos.IsDBNull(4) ? string.Empty : drpagos["categoria"].ToString();
                    pc.MesCuota = drpagos.IsDBNull(5) ? Convert.ToInt32(string.Empty) : Convert.ToInt32(drpagos["mes_cuota"]);
                    pc.AnioCuota = drpagos.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["anio_cuota"]));
                    pc.Importe = drpagos.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["importe"]));
                    Lista.Add(pc);
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
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,soc.nombre,soc.apellidos,soc.tipo,soc.categoria,cuo.mes_cuota,cuo.anio_cuota,cuo.importe from Cuotas cuo inner join Socios soc on cuo.nro_socio = soc.nro_socio where cuo.anio_cuota like @textobuscar + '%' and soc.nro_socio = @id order by soc.nombre,soc.apellidos,cuo.anio_cuota,cuo.mes_cuota", SqlConn);
                cmdpagos.Parameters.Add("@textobuscar", SqlDbType.VarChar, 50).Value = Txtbuscado;
                cmdpagos.Parameters.Add("@id", SqlDbType.Int).Value = id;

                SqlDataReader drpagos = cmdpagos.ExecuteReader();
                while (drpagos.Read())
                {
                    Cuotas pc = new Cuotas();

                    pc.NroSocio = drpagos.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["nro_socio"]));
                    pc.Nombre = drpagos.IsDBNull(1) ? string.Empty : drpagos["nombre"].ToString();
                    pc.Apellido = drpagos.IsDBNull(2) ? string.Empty : drpagos["apellidos"].ToString();
                    pc.Tipo = drpagos.IsDBNull(3) ? string.Empty : drpagos["tipo"].ToString();
                    pc.Categoria = drpagos.IsDBNull(4) ? string.Empty : drpagos["categoria"].ToString();
                    pc.MesCuota = drpagos.IsDBNull(5) ? Convert.ToInt32(string.Empty) : Convert.ToInt32(drpagos["mes_cuota"]);
                    pc.AnioCuota = drpagos.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["anio_cuota"]));
                    pc.Importe = drpagos.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["importe"]));
                    Lista.Add(pc);
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

        public List<Cuotas> TraerControl()
        {
            List<Cuotas> Lista = new List<Cuotas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,pc.mes_cuota,pc.anio_cuota,pc.importe from Socios soc left join Cuotas pc on pc.nro_socio = soc.nro_socio", SqlConn);

                SqlDataReader drpagos = cmdpagos.ExecuteReader();
                while (drpagos.Read())
                {
                    Cuotas pc = new Cuotas();
                    
                    pc.NroSocio = drpagos.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["nro_socio"]));
                    pc.MesCuota = drpagos.IsDBNull(1) ? Convert.ToInt32(null) : (int)drpagos["mes_cuota"];
                    pc.AnioCuota = drpagos.IsDBNull(2) ? Convert.ToInt32(null) : (Convert.ToInt32(drpagos["anio_cuota"]));
                    pc.Importe = drpagos.IsDBNull(3) ? Convert.ToInt32(null) : (Convert.ToInt32(drpagos["importe"]));
                    Lista.Add(pc);

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

        protected void Update(Cuotas pago)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("update Cuotas set nro_socio = @nro_socio, mes_cuota=@mes_cuota,anio_cuota=@anio_cuota,importe=@importe where nro_socio=@nro_socio and mes_cuota = @mes_cuota and anio_cuota = @anio_cuota", SqlConn);

                cmdSave.Parameters.Add("@nro_socio", SqlDbType.Int).Value = pago.NroSocio;
                cmdSave.Parameters.Add("@mes_cuota", SqlDbType.Int).Value = pago.MesCuota;
                cmdSave.Parameters.Add("@anio_cuota", SqlDbType.Int).Value = pago.AnioCuota;
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
                cmdSave.Parameters.Add("@mes_cuota", SqlDbType.Int).Value = pago.MesCuota;
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
                this.Delete(pago.NroSocio,pago.MesCuota,pago.AnioCuota);
            }
            else if (pago.Estado == BusinessEntities.Estados.Nuevo)
            {
                this.Insert(pago);
            }

            else if (pago.Estado == BusinessEntities.Estados.Modificar)
            {
                this.Update(pago);
            }
            pago.Estado = BusinessEntities.Estados.No_Modificar;
        }




    }
}
