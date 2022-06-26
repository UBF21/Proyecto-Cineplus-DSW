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
using Microsoft.AspNetCore.Authorization;

namespace Cineplus_DSW_Proyecto.Controllers
{
    [Authorize(Roles = "Administrador,Supervisor")]
    public class RPClienteController : Controller
    {
        #region Acceso a datos

        private ICliente repoCliente;
        public RPClienteController()
        {
            repoCliente = new ClienteRepository();
        }
        #endregion

        #region Acciones
        
        public IActionResult reporte(string estado)
        {
            if (string.IsNullOrEmpty(estado)) estado = string.Empty;

            if (estado.Equals("B"))
            {
                ViewBag.validacion = "Seleccione un estado.";
                List<Cliente> listado = repoCliente.listar().ToList();
                return View(listado);
            }
            TempData["estado"] = estado;
            List<Cliente> listadofiltrado = repoCliente.filtrarPorEstado(estado).ToList();
            return View(listadofiltrado);
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
        #endregion

    }
}
