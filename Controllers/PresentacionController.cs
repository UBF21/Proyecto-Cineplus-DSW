using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Cineplus_DSW_Proyecto.Repository.Implents;

namespace Cineplus_DSW_Proyecto.Controllers
{


    [Authorize(Roles = "Administrador,Supervisor")]
    public class PresentacionController : Controller
    {
        #region Acceso a datos
        
        private ICliente repoCliente;
        private IUsuario repoUsuario;
        private IComestible repoComestible;
        private IPelicula repoPelicula;
        private IProveedor repoProveedor;
        public PresentacionController()
        {
            repoCliente = new ClienteRepository();
            repoUsuario = new UsuarioRepository();
            repoComestible = new ComestibleRepository();
            repoProveedor = new ProveedorRepository();
            repoPelicula = new PeliculaRepository();
        }
        #endregion

        #region Acciones
        public IActionResult presentacion()
        {
            ViewBag.usuario = User.Identity.Name;
            ViewBag.cantidadClientes = repoCliente.listar().Count();
            ViewBag.cantidadUsuarios = repoUsuario.listar().Count();
            ViewBag.cantidadComestibles = repoComestible.listar().Count();
            ViewBag.cantidadPeliculas = repoPelicula.listar().Count();
            ViewBag.cantidadProveedores = repoProveedor.listar().Count();
            return View();
        }
        #endregion
    }
}
