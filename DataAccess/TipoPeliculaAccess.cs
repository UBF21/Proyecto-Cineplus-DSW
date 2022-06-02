using Cineplus_DSW_Proyecto.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Cineplus_DSW_Proyecto.DataAccess
{
    public class TipoPeliculaAccess
    {
        public string conn = string.Empty;
        public TipoPeliculaAccess()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                            (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }

        public IEnumerable<TipoPelicula> listar() 
        {
            List<TipoPelicula> listar = new List<TipoPelicula>();
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_listar_tipoPelicula", connection);
            connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            IDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                TipoPelicula tipoPelicula = new TipoPelicula();
                tipoPelicula.codTipo = data.GetInt32(0);
                tipoPelicula.descrip = data.GetString(1);
                listar.Add(tipoPelicula);
            }
            return listar;
        }
    }
}
