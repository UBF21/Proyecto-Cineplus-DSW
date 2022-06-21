
using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Cineplus_DSW_Proyecto.Repository.Implents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    [Authorize(Roles = "Administrador,Supervisor")]
    public class RPVentaController : Controller
    {
       

        private IBoleta repoBoleta;
        public RPVentaController()
        {
            repoBoleta = new BoletaRepository();
        }
        
        public IActionResult reporte(int year = 0)
        {
            TempData["year"] = year;
            List<Boleta> listado = repoBoleta.filtrarPorFecha(year).ToList();

            return View(listado);
        }

        public IActionResult reportePDF()
        {
            int year = (int)TempData["year"];
            List<Boleta> listado = repoBoleta.filtrarPorFecha(year).ToList();
            return new ViewAsPdf("reportePDF", listado)
            {
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape
            };
        }
    }
}
