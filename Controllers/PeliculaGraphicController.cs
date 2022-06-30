using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Models.ModelGraphic;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Cineplus_DSW_Proyecto.Repository.Implents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    [Authorize(Roles = "Supervisor")]
    public class PeliculaGraphicController : Controller
    {
        #region Acceso a datos
        private IPeliculaGraphic peliculaGraphicRepo;
        private IPelicula peliculaRepo;
        private ITipoPelicula tipoPeliculaRepo;
        public PeliculaGraphicController()
        {
            peliculaGraphicRepo = new PeliculaGraphicRepository();
            peliculaRepo = new PeliculaRepository();
            tipoPeliculaRepo = new TipoPeliculaRepository();
        }

        #endregion

        #region Acciones
        public IActionResult datos(int id = 0)
        {
            if (id == 0)
            {
                List<Pelicula> listado = peliculaRepo.listar().ToList();
                ViewBag.peliculas = new SelectList(tipoPeliculaRepo.listar(), "codTipo", "descrip");
                return View(listado);

            }
            else
            {

                List<Pelicula> listado = peliculaRepo.listar().Where(item => item.tipoPelicula == id).ToList();
                ViewBag.peliculas = new SelectList(tipoPeliculaRepo.listar(), "codTipo", "descrip");
                return View(listado);
            }
        }

        public List<PeliculaGraphic> peliculaDatos()
        {
            List<PeliculaGraphic> listado = peliculaGraphicRepo.peliculasDatos().ToList();
            return listado;
        }

        #endregion

    }
}
