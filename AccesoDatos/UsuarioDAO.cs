using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CapaSoporte.Cache;
using System.ComponentModel.Design;

namespace CapaAccesoDatos
{
    public class UsuarioDAO : ConexionConSQL
    {
       /* public bool login(string user, string pass)
        {
            using (var conecction = GetConexion())
            {
                conecction.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conecction;

                    SqlDataReader reader = comand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UsuarioCache.ID_Producto = reader.GetInt32(0);
                            UsuarioCache.Descripcion = reader.GetString(1);
                            UsuarioCache.Existencia = reader.GetInt32(2);
                            UsuarioCache.Fabricante = reader.GetString(3);
                            UsuarioCache.Nombre = reader.GetString(4);
                            UsuarioCache.Modelo = reader.GetString(5);
                            
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        */

        /*
        public void InsertaUsuario(int idUsuario, int id_tipoUsuario, string nombre, string apaterno, string amaterno, string usuario, string pass)
        {
            using (var connection = GetConexion())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert Into Usuarios Values(" + idUsuario + ", " + id_tipoUsuario + ",'" + nombre + "', '" + apaterno + "', '" + amaterno + "', '" + usuario + "','" + pass + "','" + 1 + "')";
                    command.ExecuteNonQuery();
                }
            }
        }
        public void borraUsuario(int idUsuario)
        {
            using (var connection = GetConexion())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    string Activo = "false";
                    command.Connection = connection;
                    command.CommandText = "Update Usuarios Set Activo = '"+Activo +"' Where ID_Usuario = "+ idUsuario+" ";
                    command.ExecuteNonQuery();
                }
            }
        }
        public void EditarUsuario(int idUsuario, int id_tipoUsuario, string nombre, string apaterno, string amaterno, string usuario, string pass, bool Activo)
        {
            using (var connection = GetConexion())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Update Usuarios Set IDUsuarios=" + idUsuario + ", ID_TipoUsuario= " + id_tipoUsuario + ",Nombre= '" + nombre + "', Apaterno= '" + apaterno + "', Amaterno= '" + amaterno + "', Usuario= '" + usuario + "',Pasword= '" + pass + "', Activo= "+Activo+" Where IDUsuario= "+idUsuario+"";
                    command.ExecuteNonQuery();
                }
            }
        }
        public bool VerificaUsuario(string Nombre, string Apaterno, string Amaterno)
        {
            
                using (var conecction = GetConexion())
                {
                    conecction.Open();
                    using (var comand = new SqlCommand())
                    {
                        comand.Connection = conecction;
                        comand.CommandText = "select * from Usuarios where Nombre = @Nombre and Apaterno=@apaterno and Amaterno=@Amaterno";
                        comand.Parameters.AddWithValue("@Nombre", Nombre);
                        comand.Parameters.AddWithValue("@Apaterno", Apaterno);
                        comand.Parameters.AddWithValue("@Amaterno", Amaterno);
                        comand.CommandType = CommandType.Text;
                        SqlDataReader reader = comand.ExecuteReader();
                        if (reader.HasRows)
                        {
                         
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            */
    }
}
