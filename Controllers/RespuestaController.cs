using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus_DSW_Proyecto.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class RespuestaController : Controller
    {
        #region Acciones
        public IActionResult respuestaExitosa()
        {
            return View();
        }
        #endregion
    }
}
