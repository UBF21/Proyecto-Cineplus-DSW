using Cineplus_DSW_Proyecto.Models.ModelGraphic;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace Cineplus_DSW_Proyecto.Repository.Implents
{
    public class UsuarioGraphicRepository : IUsuarioGraphic
    {
        #region Conexion a la BD
        public string conn = string.Empty;
        public UsuarioGraphicRepository()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                            (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }
        #endregion
        public IEnumerable<UsuarioGraphic> usuariosDatos()
        {
            List<UsuarioGraphic> usuarios = new List<UsuarioGraphic>();
            SqlConnection connect = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_grafico_usuario", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            IDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                UsuarioGraphic usuario = new UsuarioGraphic();
                usuario.cantidad = data.GetInt32(0);
                usuario.rol = data.GetString(1);

                usuarios.Add(usuario);
            }

            connect.Close();
            return usuarios;
        }
    }
}
