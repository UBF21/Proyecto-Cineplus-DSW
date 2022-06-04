using Cineplus_DSW_Proyecto.DataAccess;
using Cineplus_DSW_Proyecto.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus_DSW_Proyecto.Controllers
{
    public class LoginController : Controller
    {
        LoginAccess loginAccess = new LoginAccess();

        [HttpGet]
        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(Usuario obj)
        {

            if (obj == null)
            {
                return RedirectToAction("login");
            }

            bool resultado = loginAccess.existeUsuarioBool(obj.email, obj.password);
       
            
            if (resultado)
            {
               return  RedirectToAction("presentacion", "Presentacion");
            }
            else
            {
                ViewBag.mensaje = "El Usuario no existe.";
                 return View();

            }

          
        }
    }
}
