using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Models.ModelGraphic;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Cineplus_DSW_Proyecto.Repository.Implents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        public PeliculaGraphicController()
        {
            peliculaGraphicRepo = new PeliculaGraphicRepository();
            peliculaRepo = new PeliculaRepository();
        }

        #endregion

        #region Acciones
        public IActionResult datos()
        {
            List<Pelicula> listado = peliculaRepo.listar().ToList();
            return View(listado);
        }

        public List<PeliculaGraphic> peliculaDatos()
        {
            List<PeliculaGraphic> listado = peliculaGraphicRepo.peliculasDatos().ToList();
            return listado;
        }

        #endregion

    }
}
