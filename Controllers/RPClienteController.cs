using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using Cineplus_DSW_Proyecto.Models;
using Newtonsoft.Json;
using Rotativa.AspNetCore;
using Microsoft.AspNetCore.Http;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Cineplus_DSW_Proyecto.Repository.Implents;

namespace Cineplus_DSW_Proyecto.Controllers
{
    public class RPClienteController : Controller
    {
        private ICliente repoCliente;
        public RPClienteController()
        {
            repoCliente = new ClienteRepository();
        }

        public IActionResult reporte(string estado = "")
        {
            TempData["estado"] = estado;
            List<Cliente> listado = repoCliente.filtrarPorEstado(estado).ToList();
            return View(listado);
        }

        public IActionResult reportePDF()
        {
            string estado = (string)TempData["estado"];
            List<Cliente> listado = repoCliente.filtrarPorEstado(estado).ToList();
            return new ViewAsPdf("reportePDF", listado) 
            {
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape
            };
        }
    }
}
