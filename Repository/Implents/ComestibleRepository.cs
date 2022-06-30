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
        #region Conexion a la BD
        public string conn = string.Empty;
        public ComestibleRepository()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                                 (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;

        }
        #endregion

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

        public int buscarTipoComestible(string comestible)
        {
            int respuesta = 0;
            Comestible obj = listar().FirstOrDefault(item => item.descripcionComestible.Equals(comestible));
            respuesta = obj.idTipo;
            return respuesta;
        }

        public int buscarTipoProveedor(string proveedor)
        {
            int respuesta = 0;
            Comestible obj = listar().FirstOrDefault(item => item.descripcionProveedor.Equals(proveedor));
            respuesta = obj.idProveedor;
            return respuesta;
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
                obj.descripcionComestible = data.GetString(7);
                obj.descripcionProveedor = data.GetString(8);

                lista.Add(obj);
            }
            return lista;
        }

        public Comestible obtener(string id)
        {
            Comestible comestible = listar().Where((item) => item.idComestible.Equals(id)).First();
            return comestible;
        }

        public bool transaccionPedido(Comestible obj, int cantidad)
        {
            bool respuesta = false;

            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlTransaction tr = connect.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                SqlCommand cmd = new SqlCommand("usp_agregar_pedido", connect, tr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod_Com", obj.idComestible);
                cmd.Parameters.AddWithValue("@descrip", obj.descripcion);
                cmd.Parameters.AddWithValue("@precio", obj.precio);
                cmd.Parameters.AddWithValue("@id_tipo", obj.idTipo);
                cmd.Parameters.AddWithValue("@id_proveedor", obj.idProveedor);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                bool transacion1 = cmd.ExecuteNonQuery() > 0;



                SqlCommand cmd2 = new SqlCommand("usp_actualizar_stockComestible", connect, tr);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@cantidad", cantidad);
                cmd2.Parameters.AddWithValue("@id", obj.idComestible);

                bool transacion2 = cmd2.ExecuteNonQuery() > 0;

                if (transacion1 == true && transacion2 == true)
                {
                    respuesta = true;
                    tr.Commit();
                }
                else
                {
                    respuesta = false;
                }
            }
            catch (Exception ex)
            {

                tr.Rollback();
                throw ex;
            }
            finally
            {
                connect.Close();
            }

            return respuesta;
        }
   

    }
}
