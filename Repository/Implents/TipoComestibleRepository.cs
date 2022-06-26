using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Repository.Implents
{
    public class TipoComestibleRepository : ITipoComestible
    {
        #region Conexion a la BD
        public string conn = string.Empty;

        public TipoComestibleRepository()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                              (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }
        #endregion

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
