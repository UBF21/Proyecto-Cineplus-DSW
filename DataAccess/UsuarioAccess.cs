using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Cineplus_DSW_Proyecto.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Cineplus_DSW_Proyecto.DataAccess
{
    public class UsuarioAccess
    {
        public string conn = string.Empty;

        public UsuarioAccess() 
        {
            var builder = new ConfigurationBuilder().SetBasePath
                                 (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }
        
        public IEnumerable<Usuario> listar() 
        {
            List<Usuario> listado = new List<Usuario>();
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_listar_usuarios", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            IDataReader data = cmd.ExecuteReader();

            while (data.Read()) 
            {
                Usuario obj = new Usuario();
                obj.idUsuario = data.GetString(0);
                obj.nombre = data.GetString(1);
                obj.telefono = data.GetString(2);
                obj.direccion = data.GetString(3);
                obj.tipoUsuario = data.GetInt32(4);
                obj.email = data.GetString(5);
                obj.password = data.GetString(6);
                obj.estado = data.GetString(7);
            
                listado.Add(obj);
            }

            return listado;
        }

        public Usuario obtener(string id) 
        {
            Usuario obj = listar().Where((item)=> item.idUsuario.Equals(id)).First();

            return obj;
        }

        public int agregar(Usuario obj) 
        {
            int resultado = 0;
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_agregar_usuario", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",obj.idUsuario);
                cmd.Parameters.AddWithValue("@nombre",obj.nombre);
                cmd.Parameters.AddWithValue("@telefono",obj.telefono);
                cmd.Parameters.AddWithValue("@direccion",obj.direccion);
                cmd.Parameters.AddWithValue("@tipoUser",obj.tipoUsuario);
                cmd.Parameters.AddWithValue("@email",obj.email);
                cmd.Parameters.AddWithValue("@password",obj.password);
                cmd.Parameters.AddWithValue("@estado",obj.estado);
            
                 resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                resultado = 0;
                throw ex;
            }
            finally
            {
                connection.Close();
            
            }
            
            return resultado;
        }

        public int actualizar(Usuario obj) 
        {
            int resultado = 0;
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_actualizar_usuario", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", obj.idUsuario);
                cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                cmd.Parameters.AddWithValue("@telefono", obj.telefono);
                cmd.Parameters.AddWithValue("@direccion", obj.direccion);
                cmd.Parameters.AddWithValue("@tipoUser", obj.tipoUsuario);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@password", obj.password);
                cmd.Parameters.AddWithValue("@estado", obj.estado);

                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                resultado = 0;
                throw ex;
            }
            finally 
            {
            
                connection.Close();
            }
           
            return resultado;

        }
    }
}
