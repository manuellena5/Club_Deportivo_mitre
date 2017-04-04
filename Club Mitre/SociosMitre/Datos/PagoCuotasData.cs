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
    public class PagoCuotasData:Adapter
    {
        public List<PagoCuotas> GetAll()
        {
            List<PagoCuotas> pagCuo = new List<PagoCuotas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdpagos = new SqlCommand("select * from PagoCuotas", SqlConn);
                SqlDataReader drpagos = cmdpagos.ExecuteReader();
                while (drpagos.Read())
                {
                    PagoCuotas pag = new PagoCuotas();
                    pag.NroSocio = (int)drpagos["nro_socio"];
                    pag.MesCuota = (string)drpagos["mes_cuota"];
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


        public List<PagoCuotas> TraerPorMes(string Txtbuscado)
        {
            List<PagoCuotas> Lista = new List<PagoCuotas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdpagos = new SqlCommand("select pc.nro_socio,pc.mes_cuota,pc.anio_cuota,pc.importe from pagocuotas pc where pc.mes_cuota like @textobuscar + '%'", SqlConn);
                cmdpagos.Parameters.Add("@textobuscar", SqlDbType.VarChar, 50).Value = Txtbuscado;

                SqlDataReader drpagos = cmdpagos.ExecuteReader();
                while (drpagos.Read())
                {
                    PagoCuotas pc = new PagoCuotas();

                    pc.NroSocio = drpagos.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["nro_socio"]));
                    pc.MesCuota = drpagos.IsDBNull(1) ? string.Empty : drpagos["mes_cuota"].ToString();
                    pc.AnioCuota = drpagos.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["anio_cuota"]));
                    pc.Importe = drpagos.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["importe"]));
                    
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

        public List<PagoCuotas> TraerControl()
        {
            List<PagoCuotas> Lista = new List<PagoCuotas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdpagos = new SqlCommand("select soc.nro_socio,pc.mes_cuota,pc.anio_cuota,pc.importe from Socios soc left join PagoCuotas pc on pc.nro_socio = soc.nro_socio", SqlConn);

                SqlDataReader drpagos = cmdpagos.ExecuteReader();
                while (drpagos.Read())
                {
                    PagoCuotas pc = new PagoCuotas();
                    
                    pc.NroSocio = drpagos.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drpagos["nro_socio"])); 
                    pc.MesCuota = drpagos.IsDBNull(1) ? Convert.ToString(null) : (string)drpagos["mes_cuota"];
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


        protected void Delete(int ID,string mes,int anio)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete pagocuotas where nro_socio=@nro_socio and mes_cuota=@mes_cuota and anio_cuota=@anio_cuota", SqlConn);
                cmdDelete.Parameters.Add("@nro_socio", SqlDbType.Int).Value = ID;
                cmdDelete.Parameters.Add("@mes_cuota", SqlDbType.VarChar,50).Value = mes;
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

        protected void Update(PagoCuotas pago)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("update pagocuotas set mes_cuota=@mes_cuota,anio_cuota=@anio_cuota,importe=@importe where nro_socio=@nro_socio", SqlConn);

                cmdSave.Parameters.Add("@nro_socio", SqlDbType.Int).Value = pago.NroSocio;
                cmdSave.Parameters.Add("@mes_cuota", SqlDbType.VarChar, 50).Value = pago.MesCuota;
                cmdSave.Parameters.Add("@anio_cuota", SqlDbType.Int).Value = pago.AnioCuota;
                cmdSave.Parameters.Add("@importe", SqlDbType.Int).Value = pago.Importe;


                Convert.ToInt32(cmdSave.ExecuteNonQuery());
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

        protected void Insert(PagoCuotas pago)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("insert into pagocuotas(nro_socio,mes_cuota,anio_cuota,importe)" +
                    "values(@nro_socio,@mes_cuota,@anio_cuota,@importe)", SqlConn);

                cmdSave.Parameters.Add("@nro_socio", SqlDbType.Int).Value = pago.NroSocio;
                cmdSave.Parameters.Add("@mes_cuota", SqlDbType.VarChar, 50).Value = pago.MesCuota;
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

        public void Save(PagoCuotas pago)
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
