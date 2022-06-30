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
    public class PeliculaRepository : IPelicula
    {
        #region Conexion a la BD
        public string conn = string.Empty;

        public PeliculaRepository()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                            (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }
        #endregion

        public int actualizar(Pelicula obj)
        {
            int resultado = 0;
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_actualizar_pelicula", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod", obj.codPelicula);
                cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                cmd.Parameters.AddWithValue("@tipoPeli", obj.tipoPelicula);
                cmd.Parameters.AddWithValue("@fechaEstreno", obj.fechaEstreno);
                cmd.Parameters.AddWithValue("@fechaFinal", obj.fechaFinal);
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

        public int crear(Pelicula obj)
        {
            int resultado = 0;
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_agregar_pelicula", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod", obj.codPelicula);
                cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                cmd.Parameters.AddWithValue("@tipoPeli", obj.tipoPelicula);
                cmd.Parameters.AddWithValue("@fechaEstreno", obj.fechaEstreno);
                cmd.Parameters.AddWithValue("@fechaFinal", obj.fechaFinal);
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

        public bool existePelicula(string id)
        {
            bool respuesta = false;

            respuesta = listar().Any((item) => item.codPelicula.Equals(id));
            return respuesta;
        }

        public IEnumerable<Pelicula> listar()
        {
            List<Pelicula> lista = new List<Pelicula>();
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_listar_pelicula", connection);
            connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            IDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                Pelicula pelicula = new Pelicula();
                pelicula.codPelicula = data.GetString(0);
                pelicula.nombre = data.GetString(1);
                pelicula.tipoPelicula = data.GetInt32(2);
                pelicula.fechaEstreno = data.GetDateTime(3);
                pelicula.fechaFinal = data.GetDateTime(4);
                pelicula.estado = data.GetString(5);
                pelicula.descripcionTipo = data.GetString(6);
                lista.Add(pelicula);
            }
            return lista;
        }

        public Pelicula obtener(string id)
        {
            Pelicula obj = listar().Where((item) => item.codPelicula.Equals(id)).First();
            return obj;
        }
    }
}
