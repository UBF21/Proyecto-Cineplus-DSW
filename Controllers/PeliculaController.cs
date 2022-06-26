
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
    public class PeliculaController : Controller
    {

        #region Acceso a datos
        private IPelicula repoPelicula;
        private ITipoPelicula repoTipoPelicula;
        public PeliculaController()
        {
            repoPelicula = new PeliculaRepository();
            repoTipoPelicula = new TipoPeliculaRepository();
        }
        #endregion

        #region Acciones

        [HttpGet]
        public IActionResult crear()
        {
            ViewBag.peliculas = repoPelicula.listar();
            ViewBag.peliculasCantidad = repoPelicula.listar().Count();
            ViewBag.tipoPeliculas = new SelectList(repoTipoPelicula.listar(), "codTipo", "descrip");
            return View();
        }

        [HttpPost]
        public IActionResult crear(Pelicula obj)
        {
            if (ModelState.IsValid)
            {
                if (repoPelicula.existePelicula(obj.codPelicula))
                {
                    ViewBag.peliculasCantidad = repoPelicula.listar().Count();
                    ViewBag.peliculas = repoPelicula.listar();
                    ViewBag.tipoPeliculas = new SelectList(repoTipoPelicula.listar(), "codTipo", "descrip",obj.tipoPelicula);
                    ViewBag.duplicado = "El ID ya existe en la BD";
                    return View(obj);
                }
                else if (obj.estado.Equals("B"))
                {
                    ViewBag.peliculasCantidad = repoPelicula.listar().Count();
                    ViewBag.peliculas = repoPelicula.listar();
                    ViewBag.tipoPeliculas = new SelectList(repoTipoPelicula.listar(), "codTipo", "descrip",obj.tipoPelicula);
                    ViewBag.validacion = "Seleccione el estado.";
                    return View(obj);
                }
                else
                {

                    ViewBag.peliculasCantidad = repoPelicula.listar().Count();
                    ViewBag.peliculas = repoPelicula.listar();
                    ViewBag.tipoPeliculas = new SelectList(repoTipoPelicula.listar(), "codTipo", "descrip");
                    repoPelicula.crear(obj);
                    return RedirectToAction("crear");
                }
            }

            ViewBag.peliculasCantidad = repoPelicula.listar().Count();
            ViewBag.tipoPeliculas = new SelectList(repoTipoPelicula.listar(), "codTipo", "descrip");
            ViewBag.peliculas = repoPelicula.listar();
            return View(obj);
        }

        [HttpGet]
        public IActionResult editar(string id)
        {
            Pelicula obj = repoPelicula.obtener(id);

            if (obj == null)
            {
                ViewBag.peliculasCantidad = repoPelicula.listar().Count();
                ViewBag.tipoPeliculas = new SelectList(repoTipoPelicula.listar(), "codTipo", "descrip", obj.tipoPelicula);
                ViewBag.peliculas = repoPelicula.listar();
                return RedirectToAction("crear");
            }
            ViewBag.peliculasCantidad = repoPelicula.listar().Count();
            ViewBag.tipoPeliculas = new SelectList(repoTipoPelicula.listar(), "codTipo", "descrip", 1);
            ViewBag.peliculas = repoPelicula.listar();
            return View(obj);
        }

        [HttpPost]
        public IActionResult editar(Pelicula obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.estado.Equals("B"))
                {
                    ViewBag.peliculasCantidad = repoPelicula.listar().Count();
                    ViewBag.peliculas = repoPelicula.listar();
                    ViewBag.tipoPeliculas = new SelectList(repoTipoPelicula.listar(), "codTipo", "descrip",obj.tipoPelicula);
                    ViewBag.validacion = "Seleccione el estado.";
                    return View(obj);
                }
                ViewBag.peliculasCantidad = repoPelicula.listar().Count();
                ViewBag.tipoPeliculas = new SelectList(repoTipoPelicula.listar(), "codTipo", "descrip", obj.tipoPelicula);
                ViewBag.peliculas = repoPelicula.listar();
                repoPelicula.actualizar(obj);
                return RedirectToAction("crear");
            }

            ViewBag.peliculasCantidad = repoPelicula.listar().Count();
            ViewBag.tipoPeliculas = new SelectList(repoTipoPelicula.listar(), "codTipo", "descrip", obj.tipoPelicula);
            ViewBag.peliculas = repoPelicula.listar();
            return View(obj);
        }
        #endregion
    }
}
