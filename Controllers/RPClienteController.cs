using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using Cineplus_DSW_Proyecto.DataAccess;
using Cineplus_DSW_Proyecto.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Cineplus_DSW_Proyecto.Controllers
{
    public class RPClienteController : Controller
    {
        ClienteAccess clienteAccess = new ClienteAccess();

        public IActionResult reporte(string estado = "")
        {
            HttpContext.Session.SetString("estado",JsonConvert.SerializeObject(estado));
            List<Cliente> listado = clienteAccess.filtrarPorEstado(estado).ToList();
            return View(listado);
        }

        public IActionResult reportePDF()
        {
            string estado = (string) HttpContext.Session.GetString("estado");
            List<Cliente> listado = clienteAccess.filtrarPorEstado(estado).ToList();
            return View();
        }
    }
}
