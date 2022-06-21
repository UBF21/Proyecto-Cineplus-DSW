
using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Cineplus_DSW_Proyecto.Repository.Implents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class ComestibleController : Controller
    {

        private IComestible repoComestible;
        private ITipoComestible repoTipoComestible;
        private ITipoProveedor repoTipoProveedor;

        public ComestibleController()
        {
            repoComestible = new ComestibleRepository();
            repoTipoComestible = new TipoComestibleRepository();
            repoTipoProveedor = new TipoProveedorRepository();
        }

        [HttpGet]
        public IActionResult crear()
        {
            ViewBag.comestibles = repoComestible.listar();
            ViewBag.cantidadComestibles = repoComestible.listar().Count();
            ViewBag.tiposComestibles = new SelectList(repoTipoComestible.listar(), "id", "descripcion");
            ViewBag.proveedores = new SelectList(repoTipoProveedor.listar(), "id", "nombre");
            return View();
        }

        [HttpPost]
        public IActionResult crear(Comestible obj)
        {
            if (ModelState.IsValid)
            {
                if (repoComestible.existeComestible(obj.idComestible))
                {
                    ViewBag.comestibles = repoComestible.listar();
                    ViewBag.cantidadComestibles = repoComestible.listar().Count();
                    ViewBag.tiposComestibles = new SelectList(repoTipoComestible.listar(), "id", "descripcion",obj.idTipo);
                    ViewBag.proveedores = new SelectList(repoTipoProveedor.listar(), "id", "nombre",obj.idProveedor);
                    ViewBag.duplicado = "El ID ya existe en la BD";
                    return View(obj);
                }
                else if (obj.estado.Equals("B"))
                {
                    ViewBag.comestibles = repoComestible.listar();
                    ViewBag.cantidadComestibles = repoComestible.listar().Count();
                    ViewBag.tiposComestibles = new SelectList(repoTipoComestible.listar(), "id", "descripcion", obj.idTipo);
                    ViewBag.proveedores = new SelectList(repoTipoProveedor.listar(), "id", "nombre", obj.idProveedor);
                    ViewBag.validacion = "Seleccione un estado.";
                    return View(obj);
                }

                ViewBag.comestibles = repoComestible.listar();
                ViewBag.cantidadComestibles = repoComestible.listar().Count();
                ViewBag.tiposComestibles = new SelectList(repoTipoComestible.listar(), "id", "descripcion");
                ViewBag.proveedores = new SelectList(repoTipoProveedor.listar(), "id", "nombre");
                repoComestible.agregar(obj);
                return RedirectToAction("crear");
            }

            ViewBag.comestibles = repoComestible.listar();
            ViewBag.cantidadComestibles = repoComestible.listar().Count();
            ViewBag.tiposComestibles = new SelectList(repoTipoComestible.listar(), "id", "descripcion");
            ViewBag.proveedores = new SelectList(repoTipoProveedor.listar(), "id", "nombre");
            return View(obj);
        }

        [HttpGet]
        public IActionResult editar(string id)
        {
            Comestible obj = repoComestible.obtener(id);
            if (obj == null)
            {
                ViewBag.comestibles = repoComestible.listar();
                ViewBag.cantidadComestibles = repoComestible.listar().Count();
                ViewBag.tiposComestibles = new SelectList(repoTipoComestible.listar(), "id", "descripcion",1);
                ViewBag.proveedores = new SelectList(repoTipoProveedor.listar(), "id", "nombre",1);
                return RedirectToAction("crear");
            }
            ViewBag.comestibles = repoComestible.listar();
            ViewBag.cantidadComestibles = repoComestible.listar().Count();
            ViewBag.tiposComestibles = new SelectList(repoTipoComestible.listar(), "id", "descripcion",obj.idTipo);
            ViewBag.proveedores = new SelectList(repoTipoProveedor.listar(), "id", "nombre",obj.idProveedor);
            return View(obj);
        }

        [HttpPost]
        public IActionResult editar(Comestible obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.estado.Equals("B"))
                {

                    ViewBag.comestibles = repoComestible.listar();
                    ViewBag.cantidadComestibles = repoComestible.listar().Count();
                    ViewBag.tiposComestibles = new SelectList(repoTipoComestible.listar(), "id", "descripcion", obj.idTipo);
                    ViewBag.proveedores = new SelectList(repoTipoProveedor.listar(), "id", "nombre", obj.idProveedor);
                    ViewBag.validacion = "Seleccione un estado.";
                    return View(obj);
                }
                ViewBag.comestibles = repoComestible.listar();
                ViewBag.cantidadComestibles = repoComestible.listar().Count();
                ViewBag.tiposComestibles = new SelectList(repoTipoComestible.listar(), "id", "descripcion",obj.idTipo);
                ViewBag.proveedores = new SelectList(repoTipoProveedor.listar(), "id", "nombre",obj.idProveedor);
                repoComestible.actualizar(obj);
                return RedirectToAction("crear");
            }

            ViewBag.comestibles = repoComestible.listar();
            ViewBag.cantidadComestibles = repoComestible.listar().Count();
            ViewBag.tiposComestibles = new SelectList(repoTipoComestible.listar(), "id", "descripcion",obj.idTipo);
            ViewBag.proveedores = new SelectList(repoTipoProveedor.listar(), "id", "nombre",obj.idProveedor);
            return View(obj);
        }
    }
}
