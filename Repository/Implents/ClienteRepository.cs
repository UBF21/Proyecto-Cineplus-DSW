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
    public class ClienteRepository : ICliente
    {
        #region Conexion a la BD

        public string conn = string.Empty;

        public ClienteRepository()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                            (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;

        }
        #endregion
        public int agregar(Cliente cliente)
        {
            int resultado = 0;
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_insertar_cliente", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
                cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                cmd.Parameters.AddWithValue("@email", cliente.email);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);

                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                resultado = 0;
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return resultado;

        }

        public int editar(Cliente cliente)
        {
            int resultado = 0;
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_editar_cliente", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", cliente.id);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
                cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                cmd.Parameters.AddWithValue("@email", cliente.email);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);

                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                resultado = 0;
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return resultado;
        }

        public bool existeCliente(int id)
        {
            bool existe = false;
            existe = listar().Any(item => item.id == id);
            return existe;
        }

        public bool existeEmail(string email)
        {
            bool respuesta = false;
            respuesta = listar().Any((item)=> item.email.Equals(email));
            return respuesta;
        }


        public IEnumerable<Cliente> filtrarPorEstado(string estado)
        {
            List<Cliente> listado = listar().Where((item) => item.estado.Equals(estado)).ToList();

            return listado;
        }

        public IEnumerable<Cliente> listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand cmd = new SqlCommand("usp_listar_Cliente", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            IDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                Cliente obj = new Cliente();
                obj.id = data.GetInt32(0);
                obj.nombre = data.GetString(1);
                obj.telefono = data.GetString(2);
                obj.direccion = data.GetString(3);
                obj.email = data.GetString(4);
                obj.estado = data.GetString(5);

                clientes.Add(obj);

            }


            return clientes;
        }

        public Cliente obtener(int id)
        {
            Cliente cliente = listar().Where((item) => item.id == id).FirstOrDefault();
            return cliente;
        }
    }
}
