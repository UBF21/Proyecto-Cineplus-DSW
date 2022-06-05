using Cineplus_DSW_Proyecto.DataAccess;
using Cineplus_DSW_Proyecto.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    [Authorize]
    public class ProveedorController : Controller
    {
        ProveedorAccess proveedorAccess = new ProveedorAccess();

        [HttpGet]
        public IActionResult crear()
        {
            ViewBag.proveedores = proveedorAccess.listar();
            ViewBag.cantidadProveedores = proveedorAccess.listar().Count();
            return View();
        }

        [HttpPost]
        public IActionResult crear(Proveedor obj)
        {
            if (ModelState.IsValid)
            {

                ViewBag.proveedores = proveedorAccess.listar();
                ViewBag.cantidadProveedores = proveedorAccess.listar().Count();
                proveedorAccess.agregar(obj);
                return RedirectToAction("crear");
            }

            ViewBag.proveedores = proveedorAccess.listar();
            ViewBag.cantidadProveedores = proveedorAccess.listar().Count();
            return View(obj);
        }

        [HttpGet]
        public IActionResult editar(int id)
        {
            Proveedor proveedor = proveedorAccess.obtener(id);
            
            if (proveedor == null)
            {
                ViewBag.proveedores = proveedorAccess.listar();
                ViewBag.cantidadProveedores = proveedorAccess.listar().Count();
                return RedirectToAction("crear");
            }

            ViewBag.proveedores = proveedorAccess.listar();
            ViewBag.cantidadProveedores = proveedorAccess.listar().Count();
            return View(proveedor);
        }

        [HttpPost]
        public IActionResult editar(Proveedor obj) 
        {

            if (ModelState.IsValid) 
            {
                ViewBag.proveedores = proveedorAccess.listar();
                ViewBag.cantidadProveedores = proveedorAccess.listar().Count();
                proveedorAccess.actualizar(obj);
                return RedirectToAction("crear");
            }

            ViewBag.proveedores = proveedorAccess.listar();
            ViewBag.cantidadProveedores = proveedorAccess.listar().Count();
            return View(obj);
        }
    }
}
