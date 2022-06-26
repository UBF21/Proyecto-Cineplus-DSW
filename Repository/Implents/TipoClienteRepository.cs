using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Cineplus_DSW_Proyecto.Repository.Implents
{
    public class TipoClienteRepository : ITipoCliente
    {

        #region Conexion a la BD
        public string conn = string.Empty;
        public TipoClienteRepository()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                        (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }
        #endregion

        public IEnumerable<TipoCliente> listar()
        {
            List<TipoCliente> lista = new List<TipoCliente>();
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_listar_TipoCliente", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            IDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                TipoCliente tipoCliente = new TipoCliente();
                tipoCliente.idCliente = data.GetInt32(0);
                tipoCliente.nombre = data.GetString(1);

                lista.Add(tipoCliente);
            }
            return lista;
        }
    }
}
