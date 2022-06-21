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
    public class ComestibleRepository : IComestible
    {
        public string conn = string.Empty;
        public ComestibleRepository()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                                 (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;

        }

        public int actualizar(Comestible obj)
        {
            int resultado = 0;
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_actualizar_comestible", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod", obj.idComestible);
                cmd.Parameters.AddWithValue("@descrip", obj.descripcion);
                cmd.Parameters.AddWithValue("@precio", obj.precio);
                cmd.Parameters.AddWithValue("@stockActual", obj.stock);
                cmd.Parameters.AddWithValue("@idTipo", obj.idTipo);
                cmd.Parameters.AddWithValue("@idProveedor", obj.idProveedor);
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

        public int agregar(Comestible obj)
        {
            int resultado = 0;
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_agregar_comestible", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod", obj.idComestible);
                cmd.Parameters.AddWithValue("@descrip", obj.descripcion);
                cmd.Parameters.AddWithValue("@precio", obj.precio);
                cmd.Parameters.AddWithValue("@stockActual", obj.stock);
                cmd.Parameters.AddWithValue("@idTipo", obj.idTipo);
                cmd.Parameters.AddWithValue("@idProveedor", obj.idProveedor);
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

        public IEnumerable<Comestible> comestibleFiltro(int tipo)
        {
            List<Comestible> listado = new List<Comestible>();
            listado = listar().Where((item) => item.idTipo == tipo).ToList();
            return listado;
        }

        public bool existeComestible(string id)
        {
            bool respuesta = false;

            respuesta = listar().Any((item) => item.idComestible.Equals(id));

            return respuesta;
        }

        public IEnumerable<Comestible> listar()
        {
            List<Comestible> lista = new List<Comestible>();

            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_listar_comestible", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            IDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                Comestible obj = new Comestible();
                obj.idComestible = data.GetString(0);
                obj.descripcion = data.GetString(1);
                obj.precio = data.GetDouble(2);
                obj.stock = data.GetInt32(3);
                obj.idTipo = data.GetInt32(4);
                obj.idProveedor = data.GetInt32(5);
                obj.estado = data.GetString(6);

                lista.Add(obj);
            }
            return lista;
        }

        public Comestible obtener(string id)
        {
            Comestible comestible = listar().Where((item) => item.idComestible.Equals(id)).First();
            return comestible;
        }
    }
}
