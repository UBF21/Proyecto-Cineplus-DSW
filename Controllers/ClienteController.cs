using Microsoft.AspNetCore.Mvc;
using Cineplus_DSW_Proyecto.DataAccess;
using Cineplus_DSW_Proyecto.Models;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Controllers
{
    public class ClienteController : Controller
    {
        #region Acceso a Datos

        ClienteAccess clienteAccess = new ClienteAccess();
        #endregion

        #region Acciones

        [HttpGet]
        public IActionResult crear()
        {
            ViewBag.clientes = clienteAccess.listar();
            ViewBag.cantidadClientes = clienteAccess.listar().Count();
            return View();
        }

        [HttpPost]
        public IActionResult crear(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                ViewBag.clientes = clienteAccess.listar();
                clienteAccess.agregar(cliente);
                ViewBag.cantidadClientes = clienteAccess.listar().Count();
                return RedirectToAction("crear");
            }
            ViewBag.clientes = clienteAccess.listar();
            ViewBag.cantidadClientes = clienteAccess.listar().Count();
            return View(cliente);
        }

        [HttpGet]
        public IActionResult editar(int id)
        {

            Cliente cliente = clienteAccess.obtener(id);

            if (cliente == null)
            {
                ViewBag.clientes = clienteAccess.listar();
                ViewBag.cantidadClientes = clienteAccess.listar().Count();
                RedirectToAction("crear");
            }
            ViewBag.clientes = clienteAccess.listar();
            ViewBag.cantidadClientes = clienteAccess.listar().Count();
            return View(cliente);
        }

        [HttpPost]
        public IActionResult editar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                ViewBag.clientes = clienteAccess.listar();
                ViewBag.cantidadClientes = clienteAccess.listar().Count();
                clienteAccess.editar(cliente);
                return RedirectToAction("crear");
            }

            return View(cliente);
        }
        #endregion
    }
}
