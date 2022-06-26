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
    public class ComestibleGraphicController : Controller
    {
        #region Acceso a datos

        private IComestibleGraphic comestibleGraphicRepo;
        private IComestible comestibleRepo;
        private ITipoComestible tipoComestibleRepo;

        public ComestibleGraphicController() 
        {
            comestibleGraphicRepo = new ComestibleGraphicRepository();
            comestibleRepo = new ComestibleRepository();
            tipoComestibleRepo = new TipoComestibleRepository();
        }
        #endregion

        #region Acciones
        public IActionResult datos(int tipo = 0)
        {
            if (tipo != 0)
            {
                ViewBag.comestibles = new SelectList(tipoComestibleRepo.listar().ToList(), "id", "descripcion",tipo);
                List<Comestible> comestibleFiltro = comestibleRepo.comestibleFiltro(tipo).ToList();
                return View(comestibleFiltro);
            }
            ViewBag.comestibles = new SelectList(tipoComestibleRepo.listar().ToList(), "id", "descripcion");
            List<Comestible> comestibles = comestibleRepo.listar().ToList();
            return View(comestibles);
        }

        public List<ComestibleGraphic> comestiblesDatos()
        {
            List<ComestibleGraphic> listado = new List<ComestibleGraphic>();
            listado = comestibleGraphicRepo.comestiblesDatos().ToList();
            return listado;
        }   
        #endregion
    }
}
