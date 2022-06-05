using Cineplus_DSW_Proyecto.DataAccess;
using Cineplus_DSW_Proyecto.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    public class LoginController : Controller
    {
        LoginAccess loginAccess = new LoginAccess();
        UsuarioAccess usuarioAccess = new UsuarioAccess();

        [HttpGet]
        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> login(Usuario obj)
        {

            if (obj == null)
            {
                return RedirectToAction("login");
            }

            bool resultado = loginAccess.existeUsuarioBool(obj.email, obj.password);


            if (resultado)
            {
                Usuario usuario = loginAccess.existeUsuariObject(obj.email,obj.password);
                
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier,usuario.email));
                identity.AddClaim(new Claim(ClaimTypes.Name, usuario.nombre));
                identity.AddClaim(new Claim(ClaimTypes.MobilePhone, usuario.telefono));
                identity.AddClaim(new Claim(ClaimTypes.StreetAddress, usuario.direccion));
                identity.AddClaim(new Claim(ClaimTypes.Role, usuario.tipoUsuario.ToString()));
                
                
                var principal = new ClaimsPrincipal(identity);
               
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal); 

                return  RedirectToAction("presentacion", "Presentacion");
            }
            else
            {
                ViewBag.mensaje = "El Usuario no existe.";
                return View();

            }


        }

        public async Task<IActionResult> logout()
        { 
            await HttpContext.SignOutAsync();
            return RedirectToAction("login");
        }
    }
}
