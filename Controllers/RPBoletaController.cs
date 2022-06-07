using Cineplus_DSW_Proyecto.DataAccess;
using Cineplus_DSW_Proyecto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    public class RPBoletaController : Controller
    {
        BoletaAccess boletaAccess = new BoletaAccess();
        TipoClienteAccess tipoClienteAccess = new TipoClienteAccess();  

        public IActionResult reporte(int id = 0)
        {
            
            ViewBag.clientes = new SelectList(tipoClienteAccess.listar(), "idCliente", "nombre",id);
            List<Boleta> listado = boletaAccess.filtrarIDCliente(id).ToList();
            return View(listado);
        }

        public IActionResult reportePDF()
        {
           
            return View();
        }
    }
}
