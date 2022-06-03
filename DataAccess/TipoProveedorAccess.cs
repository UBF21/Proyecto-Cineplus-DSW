using Microsoft.Extensions.Configuration;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Cineplus_DSW_Proyecto.Models;

namespace Cineplus_DSW_Proyecto.DataAccess
{
    public class TipoProveedorAccess
    {
        public string conn = string.Empty;
        public TipoProveedorAccess()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                                 (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }

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
