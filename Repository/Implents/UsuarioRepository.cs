using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Repository.Implents
{
    public class UsuarioRepository : IUsuario
    {
        #region Conexion a la BD
        public string conn = string.Empty;

        public UsuarioRepository()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                                (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }

        #endregion

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

        public int agregar(Usuario obj)
        {
            int resultado = 0;
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_agregar_usuario", connection);
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

        public bool existeEmail(string email)
        {
            bool respuesta = false;
            respuesta = listar().Any((item) => item.email.Equals(email));
            return respuesta;
        }

        public bool existeUsuario(string id)
        {
            bool respuesta = false;
            respuesta = listar().Any((item) => item.idUsuario.Equals(id));
            return respuesta;
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
                obj.descrip_tipo = data.GetString(8);

                listado.Add(obj);
            }

            return listado;
        }

        public Usuario obtener(string id)
        {
            Usuario obj = listar().Where((item) => item.idUsuario.Equals(id)).First();

            return obj;
        }

        public string obtenerRol(int rol)
        {
            string resultado = string.Empty;
            switch (rol)
            {
                case 1:
                    return resultado = "Administrador";
                case 2:
                    return resultado = "Supervisor";
                default:
                    return resultado = "No existe";
            }
        }

        public IEnumerable<Usuario> usuariosFiltrado(int tipo)
        {
            List<Usuario> listado = new List<Usuario>();
            listado = listar().Where((item)=> item.tipoUsuario == tipo).ToList();
            return listado;
        }
    }
}
