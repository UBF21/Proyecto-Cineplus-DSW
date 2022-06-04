using Cineplus_DSW_Proyecto.DataAccess;
using Cineplus_DSW_Proyecto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    public class PeliculaController : Controller
    {
        PeliculaAccess peliculaAccess = new PeliculaAccess();
        TipoPeliculaAccess tipoPeliculaAccess = new TipoPeliculaAccess();
        [HttpGet]
        public IActionResult crear()
        {
            ViewBag.peliculas = peliculaAccess.listar();
            ViewBag.peliculasCantidad = peliculaAccess.listar().Count();
            ViewBag.tipoPeliculas = new SelectList(tipoPeliculaAccess.listar(), "codTipo", "descrip");
            return View();
        }

        [HttpPost]
        public IActionResult crear(Pelicula obj)
        {
            if (ModelState.IsValid)
            {
                ViewBag.peliculasCantidad = peliculaAccess.listar().Count();
                ViewBag.peliculas = peliculaAccess.listar().Count();
                ViewBag.tipoPeliculas = tipoPeliculaAccess.listar();
                ViewBag.tipoPeliculas = new SelectList(tipoPeliculaAccess.listar(), "codTipo", "descrip");
                peliculaAccess.crear(obj);
                return RedirectToAction("crear");
            }

            ViewBag.peliculasCantidad = peliculaAccess.listar().Count();
            ViewBag.tipoPeliculas = new SelectList(tipoPeliculaAccess.listar(), "codTipo", "descrip");
            ViewBag.peliculas = peliculaAccess.listar();
            return View(obj);
        }

        [HttpGet]
        public IActionResult editar(string id)
        {
            Pelicula obj = peliculaAccess.obtener(id);

            if (obj == null)
            {
                ViewBag.peliculasCantidad = peliculaAccess.listar().Count();
                ViewBag.tipoPeliculas = new SelectList(tipoPeliculaAccess.listar(), "codTipo", "descrip", obj.tipoPelicula);
                ViewBag.peliculas = peliculaAccess.listar();
                return RedirectToAction("crear");
            }
            ViewBag.peliculasCantidad = peliculaAccess.listar().Count();
            ViewBag.tipoPeliculas = new SelectList(tipoPeliculaAccess.listar(), "codTipo", "descrip", 1);
            ViewBag.peliculas = peliculaAccess.listar();
            return View(obj);
        }

        [HttpPost]
        public IActionResult editar(Pelicula obj) 
        {
            if (ModelState.IsValid)
            {
                ViewBag.peliculasCantidad = peliculaAccess.listar().Count();
                ViewBag.tipoPeliculas = new SelectList(tipoPeliculaAccess.listar(), "codTipo", "descrip", obj.tipoPelicula);
                ViewBag.peliculas = peliculaAccess.listar();
                peliculaAccess.actualizar(obj);
                return RedirectToAction("crear");
            }

            ViewBag.peliculasCantidad = peliculaAccess.listar().Count();
            ViewBag.tipoPeliculas = new SelectList(tipoPeliculaAccess.listar(), "codTipo", "descrip", obj.tipoPelicula);
            ViewBag.peliculas = peliculaAccess.listar();
            return View(obj);
        }
    }
}
