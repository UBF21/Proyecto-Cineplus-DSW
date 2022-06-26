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
    public class UsuarioGraphicController : Controller
    {
        #region Acceso a datos

        private IUsuarioGraphic usuarioGraphicRepo;
        private IUsuario usuarioRepo;
        private ITipoUsuario tipoUsuarioRepo;

        public UsuarioGraphicController() 
        {
            usuarioGraphicRepo = new UsuarioGraphicRepository();
            usuarioRepo = new UsuarioRepository();
            tipoUsuarioRepo = new TipoUsuarioRepository();
        }
        #endregion

        #region Acceso
        public IActionResult datos(int tipo = 0)
        {
            if (tipo != 0)
            {
                ViewBag.tipos = new SelectList(tipoUsuarioRepo.listar().ToList(), "codTipoUser", "descripcion",tipo);
                List<Usuario> listadoFiltrado = usuarioRepo.usuariosFiltrado(tipo).ToList();
                return View(listadoFiltrado);
            }
            ViewBag.tipos = new SelectList(tipoUsuarioRepo.listar().ToList(), "codTipoUser", "descripcion");
            List<Usuario> listado = usuarioRepo.listar().ToList();
            return View(listado);
        }
        public List<UsuarioGraphic> usuarioDatos()
        {
            List<UsuarioGraphic> listado = usuarioGraphicRepo.usuariosDatos().ToList();
            return listado;
        }
        #endregion

    }
}
