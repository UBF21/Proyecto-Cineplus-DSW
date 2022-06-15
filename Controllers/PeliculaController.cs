
using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Cineplus_DSW_Proyecto.Repository.Implents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    [Authorize]
    public class PeliculaController : Controller
    {

        private IPelicula repoPelicula;
        private ITipoPelicula repoTipoPelicula;
        public PeliculaController()
        { 
            repoPelicula = new PeliculaRepository();
            repoTipoPelicula = new TipoPeliculaRepository();
        }
        
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
                ViewBag.peliculasCantidad = repoPelicula.listar().Count();
                ViewBag.peliculas = repoPelicula.listar().Count();
                ViewBag.tipoPeliculas = new SelectList(repoTipoPelicula.listar(), "codTipo", "descrip");
                repoPelicula.crear(obj);
                return RedirectToAction("crear");
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
    }
}
