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
    public class CategoriaData : Adapter
    {
        
        
        public List<Categoria> GetAll()
        {
            List<Categoria> Cat = new List<Categoria>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdcat = new SqlCommand("select * from categoria", SqlConn);
                SqlDataReader drcat = cmdcat.ExecuteReader();
                while (drcat.Read())
                {
                    Categoria cat = new Categoria();
                    cat.Id_categoria = (int)drcat["id_categoria"];
                    cat.Descripcion = (string)drcat["descripcion"];
                    cat.Valor = Convert.ToDouble(drcat["valor"]);
                    cat.Fecha_condicion = (DateTime)drcat["fecha_condicion"];                    

                   
                    Cat.Add(cat);

                }
                drcat.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return Cat;
        }


        public Categoria GetOne(int id)
        {
            Categoria cat = new Categoria();
            try
            {
                this.OpenConnection();
                SqlCommand cmdcat = new SqlCommand("select * from categoria where id_categoria = @id", SqlConn);
                cmdcat.Parameters.Add("@id", SqlDbType.Int).Value = id;
                
                SqlDataReader drcat = cmdcat.ExecuteReader();
                if (drcat.Read())
                {
                    
                    cat.Id_categoria = (int)drcat["id_categoria"];
                    cat.Descripcion = (string)drcat["descripcion"];
                    cat.Valor = (double)drcat["valor"];
                    cat.Fecha_condicion = (DateTime)drcat["fecha_condicion"];
                   

                }
                drcat.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return cat;

        }
        
        protected void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete categoria where id_categoria=@id_categoria", SqlConn);
                cmdDelete.Parameters.Add("@id_categoria", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la categoria", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Categoria cat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("update categoria set descripcion=@descripcion,valor=@valor,fecha_condicion=@fecha_condicion where id_categoria=@id_categoria", SqlConn);

                cmdSave.Parameters.Add("@id_categoria", SqlDbType.Int).Value = cat.Id_categoria;
                cmdSave.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = cat.Descripcion;
                cmdSave.Parameters.Add("@valor", SqlDbType.Decimal, 18).Value = cat.Valor;
                cmdSave.Parameters.Add("@fecha_condicion", SqlDbType.Date).Value = cat.Fecha_condicion;


                Convert.ToInt32(cmdSave.ExecuteNonQuery());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la categoria", Ex);
                throw ExcepcionManejada;
                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Categoria cat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("insert into categoria(descripcion,valor,fecha_condicion)" +
                    "values(@descripcion,@valor,@fecha_condicion)", SqlConn);

                cmdSave.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = cat.Descripcion;
                cmdSave.Parameters.Add("@valor", SqlDbType.Decimal,18).Value = cat.Valor;
                cmdSave.Parameters.Add("@fecha_condicion", SqlDbType.Date).Value = cat.Fecha_condicion;


                Convert.ToInt32(cmdSave.ExecuteNonQuery());

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear la categoria", Ex);
                throw ExcepcionManejada;
                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Categoria cat)
        {
            if (cat.Estado == BusinessEntities.Estados.Eliminar)
            {
                this.Delete(cat.Id_categoria);
            }
            else if (cat.Estado == BusinessEntities.Estados.Nuevo)
            {
                this.Insert(cat);
            }

            else if (cat.Estado == BusinessEntities.Estados.Modificar)
            {
                this.Update(cat);
            }
            cat.Estado = BusinessEntities.Estados.No_Modificar;
        }

    }
}
