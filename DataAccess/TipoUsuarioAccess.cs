using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Cineplus_DSW_Proyecto.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Cineplus_DSW_Proyecto.DataAccess
{
    public class TipoUsuarioAccess
    {
        public string conn = string.Empty;
        public TipoUsuarioAccess() 
        {
            var builder = new ConfigurationBuilder().SetBasePath
                                    (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;

        }

        public IEnumerable<TipoUsuario> listar()
        { 
            List<TipoUsuario> lista = new List<TipoUsuario>();

            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_listar_tipoUsuarios", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            IDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                TipoUsuario tipoUsuario = new TipoUsuario();
                tipoUsuario.codTipoUser = data.GetInt32(0);
                tipoUsuario.descripcion = data.GetString(1);
            
                lista.Add(tipoUsuario);
            }
            return lista;
        }
    }
}
