using Cineplus_DSW_Proyecto.DataAccess;
using Cineplus_DSW_Proyecto.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    [Authorize]
    public class ComestibleController : Controller
    {
        ComestibleAccess comestibleAccess = new ComestibleAccess();
        TipoProveedorAccess tipoProveedorAccess = new TipoProveedorAccess();
        TipoComestibleAccess tipoComestibleAccess = new TipoComestibleAccess();


        [HttpGet]
        public IActionResult crear()
        {
            ViewBag.comestibles = comestibleAccess.listar();
            ViewBag.cantidadComestibles = comestibleAccess.listar().Count();
            ViewBag.tiposComestibles = new SelectList(tipoComestibleAccess.listar(), "id", "descripcion");
            ViewBag.proveedores = new SelectList(tipoProveedorAccess.listar(), "id", "nombre");
            return View();
        }

        [HttpPost]
        public IActionResult crear(Comestible obj)
        {
            if (ModelState.IsValid)
            {
                ViewBag.comestibles = comestibleAccess.listar();
                ViewBag.cantidadComestibles = comestibleAccess.listar().Count();
                ViewBag.tiposComestibles = new SelectList(tipoComestibleAccess.listar(), "id", "descripcion");
                ViewBag.proveedores = new SelectList(tipoProveedorAccess.listar(), "id", "nombre");
                comestibleAccess.agregar(obj);
                return RedirectToAction("crear");
            }

            ViewBag.comestibles = comestibleAccess.listar();
            ViewBag.cantidadComestibles = comestibleAccess.listar().Count();
            ViewBag.tiposComestibles = new SelectList(tipoComestibleAccess.listar(), "id", "descripcion");
            ViewBag.proveedores = new SelectList(tipoProveedorAccess.listar(), "id", "nombre");
            return View(obj);
        }

        [HttpGet]
        public IActionResult editar(string id)
        {
            Comestible obj = comestibleAccess.obtener(id);
            if (obj == null)
            {
                ViewBag.comestibles = comestibleAccess.listar();
                ViewBag.cantidadComestibles = comestibleAccess.listar().Count();
                ViewBag.tiposComestibles = new SelectList(tipoComestibleAccess.listar(), "id", "descripcion",1);
                ViewBag.proveedores = new SelectList(tipoProveedorAccess.listar(), "id", "nombre",1);
                return RedirectToAction("crear");
            }
            ViewBag.comestibles = comestibleAccess.listar();
            ViewBag.cantidadComestibles = comestibleAccess.listar().Count();
            ViewBag.tiposComestibles = new SelectList(tipoComestibleAccess.listar(), "id", "descripcion",obj.idTipo);
            ViewBag.proveedores = new SelectList(tipoProveedorAccess.listar(), "id", "nombre",obj.idProveedor);
            return View(obj);
        }

        [HttpPost]
        public IActionResult editar(Comestible obj)
        {
            if (ModelState.IsValid)
            {
                ViewBag.comestibles = comestibleAccess.listar();
                ViewBag.cantidadComestibles = comestibleAccess.listar().Count();
                ViewBag.tiposComestibles = new SelectList(tipoComestibleAccess.listar(), "id", "descripcion",obj.idTipo);
                ViewBag.proveedores = new SelectList(tipoProveedorAccess.listar(), "id", "nombre",obj.idProveedor);
                comestibleAccess.actualizar(obj);
            }

            ViewBag.comestibles = comestibleAccess.listar();
            ViewBag.cantidadComestibles = comestibleAccess.listar().Count();
            ViewBag.tiposComestibles = new SelectList(tipoComestibleAccess.listar(), "id", "descripcion",obj.idTipo);
            ViewBag.proveedores = new SelectList(tipoProveedorAccess.listar(), "id", "nombre",obj.idProveedor);
            return View(obj);
        }
    }
}
