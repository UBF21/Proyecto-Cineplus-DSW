using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus_DSW_Proyecto.Controllers
{

    [Authorize]
    public class PresentacionController : Controller
    {
        public IActionResult presentacion()
        {
            ViewBag.usuario = User.Identity.Name;
            return View();
        }
    }
}
