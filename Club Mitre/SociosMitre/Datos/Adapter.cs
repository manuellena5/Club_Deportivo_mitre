﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class Adapter
    {
        SqlConnection sqlConn = new SqlConnection();

        public SqlConnection SqlConn
        {
            get { return sqlConn; }
            set { sqlConn = value; }
        }

        public void OpenConnection()
        {
            sqlConn.ConnectionString = conexionSQL.sqlcon;
            sqlConn.Open();
            //throw new Exception("Metodo no implementado");

        }

        public void CloseConnection()
        {
            //sqlConn.ConnectionString = conexionsql.sqlcon;
            if (SqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
            }

            //throw new Exception("Metodo no implementado");

        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }

        
    }
}
