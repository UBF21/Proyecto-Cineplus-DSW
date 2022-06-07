using Cineplus_DSW_Proyecto.DataAccess;
using Cineplus_DSW_Proyecto.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    public class RPVentaController : Controller
    {
        BoletaAccess boletaAccess = new BoletaAccess();
        public IActionResult reporte(int year = 0)
        {
            List<Boleta> listado = boletaAccess.filtrarPorFecha(year).ToList();

            return View(listado);
        }
    }
}
