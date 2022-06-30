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
    public class ProveedorRepository : IProveedor
    {

        #region Conexion a la BD
        public string conn = string.Empty;

        public ProveedorRepository()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                           (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }
        #endregion
        public int actualizar(Proveedor obj)
        {
            int resultado = 0;

            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_actualizar_proveedor", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", obj.idProveedor);
                cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                cmd.Parameters.AddWithValue("@telefono", obj.telefono);
                cmd.Parameters.AddWithValue("@direccion", obj.direccion);

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

        public int agregar(Proveedor obj)
        {
            int resultado = 0;

            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_agregar_proveedor", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                cmd.Parameters.AddWithValue("@telefono", obj.telefono);
                cmd.Parameters.AddWithValue("@direccion", obj.direccion);

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

        public int eliminar(int id)
        {
            int respuesta = 0;
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_eliminar_proveedor", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                respuesta = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                respuesta = 0;
                throw ex;
            }
            finally
            {
                connection.Close();

            }


            return respuesta;
        }

        public IEnumerable<Proveedor> listar()
        {
            List<Proveedor> lista = new List<Proveedor>();
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_listar_proveedor", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            IDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                Proveedor obj = new Proveedor();
                obj.idProveedor = data.GetInt32(0);
                obj.nombre = data.GetString(1);
                obj.telefono = data.GetString(2);
                obj.direccion = data.GetString(3);

                lista.Add(obj);
            }
            return lista;
        }

        public Proveedor obtener(int id)
        {
            Proveedor obj = listar().Where((item) => item.idProveedor == id).First();
            return obj;
        }
    }
}
