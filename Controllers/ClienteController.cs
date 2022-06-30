using Microsoft.AspNetCore.Mvc;

using Cineplus_DSW_Proyecto.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Cineplus_DSW_Proyecto.Repository.Implents;

namespace Cineplus_DSW_Proyecto.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class ClienteController : Controller
    {
        #region Acceso a Datos

        private ICliente clienterepo;

        public ClienteController()
        {
            clienterepo = new ClienteRepository();
        }

        #endregion

        #region Acciones

        [HttpGet]
        public IActionResult crear()
        {
            ViewBag.clientes = clienterepo.listar();
            ViewBag.cantidadClientes = clienterepo.listar().Count();
            return View();
        }

        [HttpPost]
        public IActionResult crear(Cliente cliente)
        {
            if (ModelState.IsValid)
            {

                if (clienterepo.existeEmail(cliente.email))
                {
                    ViewBag.clientes = clienterepo.listar();
                    ViewBag.cantidadClientes = clienterepo.listar().Count();
                    ViewBag.duplicado = "El Email ya existe en la BD.";
                    return View(cliente);
                }
                else if (cliente.estado.Equals("B"))
                {
                    ViewBag.clientes = clienterepo.listar();
                    ViewBag.cantidadClientes = clienterepo.listar().Count();
                    ViewBag.validacion = "Seleccione un estado.";
                    return View(cliente);
                }
                else
                {
                    ViewBag.clientes = clienterepo.listar();
                    clienterepo.agregar(cliente);
                    ViewBag.cantidadClientes = clienterepo.listar().Count();
                    return RedirectToAction("crear");

                }
            }
            ViewBag.clientes = clienterepo.listar();
            ViewBag.cantidadClientes = clienterepo.listar().Count();
            return View(cliente);
        }

        [HttpGet]
        public IActionResult editar(int id)
        {

            Cliente cliente = clienterepo.obtener(id);

            if (cliente == null)
            {
                ViewBag.clientes = clienterepo.listar();
                ViewBag.cantidadClientes = clienterepo.listar().Count();
                RedirectToAction("crear");
            }
            ViewBag.clientes = clienterepo.listar();
            ViewBag.cantidadClientes = clienterepo.listar().Count();
            return View(cliente);
        }

        [HttpPost]
        public IActionResult editar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                if (cliente.estado.Equals("B"))
                {
                    ViewBag.clientes = clienterepo.listar();
                    ViewBag.cantidadClientes = clienterepo.listar().Count();
                    ViewBag.validacion = "Seleccione un estado.";
                    return View(cliente);
                }
                ViewBag.clientes = clienterepo.listar();
                ViewBag.cantidadClientes = clienterepo.listar().Count();
                clienterepo.editar(cliente);
                return RedirectToAction("crear");
            }

            return View(cliente);
        }


        #endregion
    }
}
