using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using Cineplus_DSW_Proyecto.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Cineplus_DSW_Proyecto.DataAccess
{
    public class ComestibleAccess
    {
        public string conn = string.Empty;
        public ComestibleAccess() 
        {
            var builder = new ConfigurationBuilder().SetBasePath
                                 (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
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

        public int agregar(Comestible obj) 
        {

            int resultado = 0;
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_agregar_comestible", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod",obj.idComestible);
                cmd.Parameters.AddWithValue("@descrip",obj.descripcion);
                cmd.Parameters.AddWithValue("@precio",obj.precio);
                cmd.Parameters.AddWithValue("@stockActual",obj.stock);
                cmd.Parameters.AddWithValue("@idTipo",obj.idTipo);
                cmd.Parameters.AddWithValue("@idProveedor",obj.idProveedor);
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
    }
}
