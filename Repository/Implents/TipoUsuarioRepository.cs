using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Cineplus_DSW_Proyecto.Repository.Implents
{
    public class TipoUsuarioRepository : ITipoUsuario
    {

        #region Conexion a la BD
        public string conn = string.Empty;
        public TipoUsuarioRepository()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                                   (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }
        #endregion

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
