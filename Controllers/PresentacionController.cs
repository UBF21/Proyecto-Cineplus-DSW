using Microsoft.AspNetCore.Mvc;

namespace Cineplus_DSW_Proyecto.Controllers
{
    public class PresentacionController : Controller
    {
        public IActionResult presentacion()
        {
            return View();
        }
    }
}
