using Cineplus_DSW_Proyecto.Models.ModelGraphic;
using Cineplus_DSW_Proyecto.Repository.IModel;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Cineplus_DSW_Proyecto.Repository.Implents
{
    public class PeliculaGraphicRepository : IPeliculaGraphic
    {
        #region Conexion a la BD
        public string conn = string.Empty;

        public PeliculaGraphicRepository() 
        {
            var builder = new ConfigurationBuilder().SetBasePath
                            (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }
        #endregion
        public IEnumerable<PeliculaGraphic> peliculasDatos()
        {
            List<PeliculaGraphic> peliculas = new List<PeliculaGraphic>();
            SqlConnection connect = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_grafico_pelicula", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            IDataReader data = cmd.ExecuteReader();

            while (data.Read()) 
            {
                PeliculaGraphic pelicula = new PeliculaGraphic();
                pelicula.cantidad = data.GetInt32(0);
                pelicula.tipo = data.GetString(1);

                peliculas.Add(pelicula);
            }

            connect.Close();
            return peliculas;
        }
    }
}
