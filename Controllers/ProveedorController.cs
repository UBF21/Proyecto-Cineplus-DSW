
using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Cineplus_DSW_Proyecto.Repository.Implents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class ProveedorController : Controller
    {
        #region Acceso a datos

        private IProveedor repoProveedor;
        public ProveedorController()
        {
            repoProveedor = new ProveedorRepository();
        }
        #endregion

        #region Acciones

        [HttpGet]
        public IActionResult crear()
        {
            ViewBag.proveedores = repoProveedor.listar();
            ViewBag.cantidadProveedores = repoProveedor.listar().Count();
            return View();
        }

        [HttpPost]
        public IActionResult crear(Proveedor obj)
        {
            if (ModelState.IsValid)
            {

                ViewBag.proveedores = repoProveedor.listar();
                ViewBag.cantidadProveedores = repoProveedor.listar().Count();
                repoProveedor.agregar(obj);
                return RedirectToAction("crear");
            }

            ViewBag.proveedores = repoProveedor.listar();
            ViewBag.cantidadProveedores = repoProveedor.listar().Count();
            return View(obj);
        }

        [HttpGet]
        public IActionResult editar(int id)
        {
            Proveedor proveedor = repoProveedor.obtener(id);

            if (proveedor == null)
            {
                ViewBag.proveedores = repoProveedor.listar();
                ViewBag.cantidadProveedores = repoProveedor.listar().Count();
                return RedirectToAction("crear");
            }

            ViewBag.proveedores = repoProveedor.listar();
            ViewBag.cantidadProveedores = repoProveedor.listar().Count();
            return View(proveedor);
        }

        [HttpPost]
        public IActionResult editar(Proveedor obj)
        {

            if (ModelState.IsValid)
            {
                ViewBag.proveedores = repoProveedor.listar();
                ViewBag.cantidadProveedores = repoProveedor.listar().Count();
                repoProveedor.actualizar(obj);
                return RedirectToAction("crear");
            }

            ViewBag.proveedores = repoProveedor.listar();
            ViewBag.cantidadProveedores = repoProveedor.listar().Count();
            return View(obj);
        }

        [HttpGet]
        public IActionResult eliminar(int id)
        {
            if (id != 0)
            {
                int respuesta = repoProveedor.eliminar(id);
                if (respuesta > 0)
                {
                    return RedirectToAction("crear");

                }
                else 
                { 
                    return RedirectToAction("crear");
                }
            }
            return View();
        }
        #endregion
    }
}
