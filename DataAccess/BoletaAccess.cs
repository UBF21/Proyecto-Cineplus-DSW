﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using Cineplus_DSW_Proyecto.Models;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Cineplus_DSW_Proyecto.DataAccess
{
    public class BoletaAccess
    {
        public string conn = string.Empty;
        public BoletaAccess()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                        (Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            conn = builder.GetSection("ConnectionStrings:conectionCinePlus").Value;
        }
        public IEnumerable<Boleta> filtrarIDCliente(int id)
        {
            List<Boleta> lista = new List<Boleta>();
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_filtrar_idCliente", connection);
            connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            IDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                Boleta boleta = new Boleta();
                boleta.codBoleta = data.GetString(0);
                boleta.idCliente = data.GetInt32(1);
                boleta.nombre = data.GetString(2);
                boleta.email = data.GetString(3);
                boleta.fechaBoleta = data.GetDateTime(4);
                boleta.precioTotal = data.GetDouble(5);

                lista.Add(boleta);

            }

            return lista;

        }

        public IEnumerable<Boleta> listar()
        {
            List<Boleta> listado = new List<Boleta>();
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("usp_listar_boleta", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            IDataReader data = cmd.ExecuteReader();

            while (data.Read()) 
            {
                Boleta boleta = new Boleta();
                boleta.codBoleta = data.GetString(0);
                boleta.idCliente = data.GetInt32(1);
                boleta.nombre = data.GetString(2);
                boleta.email = data.GetString(3);
                boleta.fechaBoleta = data.GetDateTime(4);
                boleta.precioTotal = data.GetDouble(5);

                listado.Add(boleta);
            }

            return listado;
        }

        public IEnumerable<Boleta> filtrarPorFecha(int year)
        { 
            List<Boleta> listado = listar().Where((item)=> item.fechaBoleta.Year == year).ToList();
            return listado;
        }
    }
}
