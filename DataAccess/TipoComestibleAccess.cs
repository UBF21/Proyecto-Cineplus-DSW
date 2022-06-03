using Microsoft.Extensions.Configuration;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Cineplus_DSW_Proyecto.Models;

namespace Cineplus_DSW_Proyecto.DataAccess
{
    public class TipoComestibleAccess
    {
        public string conn = string.Empty;

        public TipoComestibleAccess()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                               (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }

        public IEnumerable<TipoComestible> listar()
        {
            List<TipoComestible> lista = new List<TipoComestible>();
            
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_listar_tipoComestibles", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            IDataReader data = cmd.ExecuteReader();
            while (data.Read()) 
            {
                TipoComestible obj = new TipoComestible();
                
                obj.id = data.GetInt32(0);
                obj.descripcion = data.GetString(1);
                
                lista.Add(obj);
            }
            return lista;
        }
    }
}
