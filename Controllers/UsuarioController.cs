
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
    public class UsuarioController : Controller
    {
        #region Acceso a datos

        private IUsuario repoUsuario;
        private ITipoUsuario repoTipoUsuario;

        public UsuarioController()
        {
            repoUsuario = new UsuarioRepository();
            repoTipoUsuario = new TipoUsuarioRepository();
        }
        #endregion

        #region Acceso

        [HttpGet]
        public IActionResult crear()
        {
            ViewBag.usuarios = repoUsuario.listar();
            ViewBag.cantidadUsuarios = repoUsuario.listar().Count();
            ViewBag.tipoUsuarios = new SelectList(repoTipoUsuario.listar(), "codTipoUser", "descripcion");
            return View();
        }

        [HttpPost]
        public IActionResult crear(Usuario obj)
        {
            if (ModelState.IsValid)
            {
                if (repoUsuario.existeUsuario(obj.idUsuario))
                {
                    ViewBag.usuarios = repoUsuario.listar();
                    ViewBag.cantidadUsuarios = repoUsuario.listar().Count();
                    ViewBag.tipoUsuarios = new SelectList(repoTipoUsuario.listar(), "codTipoUser", "descripcion", obj.tipoUsuario);
                    ViewBag.duplicadoID = "El ID ya existe en la BD.";
                    return View(obj);
                }
                else if (repoUsuario.existeEmail(obj.email))
                {
                    ViewBag.usuarios = repoUsuario.listar();
                    ViewBag.cantidadUsuarios = repoUsuario.listar().Count();
                    ViewBag.tipoUsuarios = new SelectList(repoTipoUsuario.listar(), "codTipoUser", "descripcion", obj.tipoUsuario);
                    ViewBag.duplicadoEmail = "El Email ya existe en la BD.";
                    return View(obj);
                }
                else if (obj.estado.Equals("B"))
                {
                    ViewBag.usuarios = repoUsuario.listar();
                    ViewBag.cantidadUsuarios = repoUsuario.listar().Count();
                    ViewBag.tipoUsuarios = new SelectList(repoTipoUsuario.listar(), "codTipoUser", "descripcion");
                    ViewBag.validacionCombo = "Seleccione un estado.";
                    return View(obj);
                }
                else
                {

                    ViewBag.usuarios = repoUsuario.listar();
                    ViewBag.cantidadUsuarios = repoUsuario.listar().Count();
                    ViewBag.tipoUsuarios = new SelectList(repoTipoUsuario.listar(), "codTipoUser", "descripcion");
                    repoUsuario.agregar(obj);
                    return RedirectToAction("crear");
                }

            }

            ViewBag.usuarios = repoUsuario.listar();
            ViewBag.cantidadUsuarios = repoUsuario.listar().Count();
            ViewBag.tipoUsuarios = new SelectList(repoTipoUsuario.listar(), "codTipoUser", "descripcion");
            return View(obj);
        }

        [HttpGet]
        public IActionResult editar(string id)
        {
            Usuario obj = repoUsuario.obtener(id);
            if (obj == null)
            {
                ViewBag.usuarios = repoUsuario.listar();
                ViewBag.cantidadUsuarios = repoUsuario.listar().Count();
                ViewBag.tipoUsuarios = new SelectList(repoTipoUsuario.listar(), "codTipoUser", "descripcion", 1);
                return RedirectToAction("crear");
            }

            ViewBag.usuarios = repoUsuario.listar();
            ViewBag.cantidadUsuarios = repoUsuario.listar().Count();
            ViewBag.tipoUsuarios = new SelectList(repoTipoUsuario.listar(), "codTipoUser", "descripcion", obj.tipoUsuario);
            return View(obj);
        }

        [HttpPost]
        public IActionResult editar(Usuario obj)
        {
            if (ModelState.IsValid)
            {

                ViewBag.usuarios = repoUsuario.listar();
                ViewBag.cantidadUsuarios = repoUsuario.listar().Count();
                ViewBag.tipoUsuarios = new SelectList(repoTipoUsuario.listar(), "codTipoUser", "descripcion", obj.tipoUsuario);
                repoUsuario.actualizar(obj);
                return RedirectToAction("crear");
            }

            ViewBag.usuarios = repoUsuario.listar();
            ViewBag.cantidadUsuarios = repoUsuario.listar().Count();
            ViewBag.tipoUsuarios = new SelectList(repoTipoUsuario.listar(), "codTipoUser", "descripcion", obj.tipoUsuario);
            return View(obj);
        }
        #endregion
    }
}
