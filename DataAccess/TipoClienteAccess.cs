using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using Cineplus_DSW_Proyecto.Models;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Cineplus_DSW_Proyecto.DataAccess
{
    public class TipoClienteAccess
    {
        public string conn = string.Empty;
        public TipoClienteAccess()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                        (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }

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
