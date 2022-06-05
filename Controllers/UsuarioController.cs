using Cineplus_DSW_Proyecto.DataAccess;
using Cineplus_DSW_Proyecto.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    [Authorize]
    public class UsuarioController : Controller
    {
        UsuarioAccess usuarioAccess = new UsuarioAccess();
        TipoUsuarioAccess TipoUsuarioAccess = new TipoUsuarioAccess();

        [HttpGet]
        public IActionResult crear()
        {
            ViewBag.usuarios = usuarioAccess.listar();
            ViewBag.cantidadUsuarios = usuarioAccess.listar().Count();
            ViewBag.tipoUsuarios = new SelectList(TipoUsuarioAccess.listar(), "codTipoUser", "descripcion");
            return View();
        }

        [HttpPost]
        public IActionResult crear(Usuario obj) 
        {
            if (ModelState.IsValid)
            {
                ViewBag.usuarios = usuarioAccess.listar();
                ViewBag.cantidadUsuarios = usuarioAccess.listar().Count();
                ViewBag.tipoUsuarios = new SelectList(TipoUsuarioAccess.listar(), "codTipoUser", "descripcion");
                usuarioAccess.agregar(obj);
                return RedirectToAction("crear");

            }

            ViewBag.usuarios = usuarioAccess.listar();
            ViewBag.cantidadUsuarios = usuarioAccess.listar().Count();
            ViewBag.tipoUsuarios = new SelectList(TipoUsuarioAccess.listar(), "codTipoUser", "descripcion");
            return View(obj);
        }

        [HttpGet]
        public IActionResult editar(string id) 
        {
            Usuario obj = usuarioAccess.obtener(id);
            if (obj == null)
            {
                ViewBag.usuarios = usuarioAccess.listar();
                ViewBag.cantidadUsuarios = usuarioAccess.listar().Count();
                ViewBag.tipoUsuarios = new SelectList(TipoUsuarioAccess.listar(), "codTipoUser", "descripcion",1);
                return RedirectToAction("crear");
            }

            ViewBag.usuarios = usuarioAccess.listar();
            ViewBag.cantidadUsuarios = usuarioAccess.listar().Count();
            ViewBag.tipoUsuarios = new SelectList(TipoUsuarioAccess.listar(), "codTipoUser", "descripcion",obj.tipoUsuario);
            return View(obj);
        }

        [HttpPost]
        public IActionResult editar(Usuario obj) 
        {
            if (ModelState.IsValid)
            {

                ViewBag.usuarios = usuarioAccess.listar();
                ViewBag.cantidadUsuarios = usuarioAccess.listar().Count();
                ViewBag.tipoUsuarios = new SelectList(TipoUsuarioAccess.listar(), "codTipoUser", "descripcion", obj.tipoUsuario);
                usuarioAccess.actualizar(obj);
                return RedirectToAction("crear");
            }

            ViewBag.usuarios = usuarioAccess.listar();
            ViewBag.cantidadUsuarios = usuarioAccess.listar().Count();
            ViewBag.tipoUsuarios = new SelectList(TipoUsuarioAccess.listar(), "codTipoUser", "descripcion", obj.tipoUsuario);
            return View(obj);
        }
    }
}
