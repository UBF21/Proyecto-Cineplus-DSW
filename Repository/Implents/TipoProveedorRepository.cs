using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Cineplus_DSW_Proyecto.Repository.Implents
{
    public class TipoProveedorRepository : ITipoProveedor
    {
        #region Conexion a la BD
        public string conn = string.Empty;

        public TipoProveedorRepository()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                                (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }
        #endregion

        public IEnumerable<TipoProveedor> listar()
        {
            List<TipoProveedor> lista = new List<TipoProveedor>();

            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_listar_proveedores", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            IDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                TipoProveedor obj = new TipoProveedor();
                obj.id = data.GetInt32(0);
                obj.nombre = data.GetString(1);

                lista.Add(obj);
            }

            return lista;
        }
    }
}
