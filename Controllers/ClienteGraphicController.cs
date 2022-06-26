using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Models.ModelGraphic;
using Cineplus_DSW_Proyecto.Repository.IModel;
using Cineplus_DSW_Proyecto.Repository.Implents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cineplus_DSW_Proyecto.Controllers
{

    [Authorize(Roles = "Supervisor")]
    public class ClienteGraphicController : Controller
    {
        #region Acceso a datos

        private ICliente clienteRepo;
        private IClienteGraphic clienteGraphicrepo;
        public ClienteGraphicController()
        {
            clienteRepo = new ClienteRepository();
            clienteGraphicrepo = new ClienteGraphicRepository();
        }
        #endregion

        #region Acciones
        public IActionResult datos(string estado)
        {
            if (string.IsNullOrEmpty(estado))
            {
                estado = string.Empty;
                List<Cliente> clientes = clienteRepo.listar().ToList();
                return View(clientes);

            }
            else if (estado.Equals("B"))
            {
                List<Cliente> clientes = clienteRepo.listar().ToList();
                ViewBag.validacion = "Seleccione un estado.";
                return View(clientes);
            }
            else
            {
                List<Cliente> clientesFiltrado = clienteRepo.filtrarPorEstado(estado).ToList();
                return View(clientesFiltrado);
            }


        }

        public List<ClienteGraphic> ClienteDatos()
        {
            List<ClienteGraphic> listado = new List<ClienteGraphic>();

            listado = clienteGraphicrepo.clientesDatos().ToList();

            return listado;
        }
        #endregion

    }
}
