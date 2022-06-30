
using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Cineplus_DSW_Proyecto.Repository.Implents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    [Authorize(Roles = "Administrador,Supervisor")]
    public class RPBoletaController : Controller
    {
        #region Acceso a datos

        private IBoleta repoBoleta;
        private ITipoCliente repoCliente;
        public RPBoletaController()
        {
            repoBoleta = new BoletaRepository();
            repoCliente = new TipoClienteRepository();
        }

        #endregion

        #region Acciones
        public IActionResult reporte(int id = 0)
        {
      
                TempData["id"] = (int)id;
                ViewBag.clientes = new SelectList(repoCliente.listar(), "idCliente", "nombre", id);
                List<Boleta> listado = repoBoleta.filtrarIDCliente(id).ToList();
                return View(listado);
            
        }
        public IActionResult reportePDF()
        {
            int id = 0;
            id = (int)TempData["id"];

            List<Boleta> listado = repoBoleta.filtrarIDCliente(id).ToList();
            return new ViewAsPdf("reportePDF", listado)
            {
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape,

            };
        }

        #endregion

    }
}
