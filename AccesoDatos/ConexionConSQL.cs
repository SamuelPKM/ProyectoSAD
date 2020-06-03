using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
     public abstract class ConexionConSQL
    {
        private readonly string connectionString;
        public ConexionConSQL() {
            connectionString = "Data Source=(local)\\SQLEXPRESS; DataBase=ProyectoSAD; integrated security=true";
        }
        protected SqlConnection GetConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}
