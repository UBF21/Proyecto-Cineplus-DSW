using Cineplus_DSW_Proyecto.Models.ModelGraphic;
using Cineplus_DSW_Proyecto.Repository.IModel;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Cineplus_DSW_Proyecto.Repository.Implents
{
    public class ClienteGraphicRepository : IClienteGraphic
    {
        #region Conexion a la BD
        public string conn = string.Empty;
        public ClienteGraphicRepository()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                            (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }
        #endregion
        public IEnumerable<ClienteGraphic> clientesDatos()
        {
           List<ClienteGraphic> clientes = new List<ClienteGraphic>();
            SqlConnection connect = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_grafico_cliente", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();

            IDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                ClienteGraphic cliente = new ClienteGraphic();
                cliente.cantidad = data.GetInt32(0);
                cliente.estado = data.GetString(1);

                clientes.Add(cliente);
            }
         
            return clientes;
        }
    }
}
