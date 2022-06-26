using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Cineplus_DSW_Proyecto.Models.ModelGraphic;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Cineplus_DSW_Proyecto.Repository.Implents
{
    public class ComestibleGraphicRepository : IComestibleGraphic
    {

        #region Conexion a la BD
        
        public string conn = string.Empty;

        public ComestibleGraphicRepository()
        {

            var builder = new ConfigurationBuilder().SetBasePath
                            (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }
        #endregion
        public IEnumerable<ComestibleGraphic> comestiblesDatos()
        {
            List<ComestibleGraphic> comestibles = new List<ComestibleGraphic>();
            SqlConnection connect = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_grafico_comestible", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            IDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                ComestibleGraphic comestible = new ComestibleGraphic();
                comestible.cantidad = data.GetInt32(0);
                comestible.tipo = data.GetString(1);

                comestibles.Add(comestible);
            }

            connect.Close();
            return comestibles;
        }
    }
}
