using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface ICliente
    {
        #region Metodos para Implentar
        public IEnumerable<Cliente> listar();
        public int agregar(Cliente cliente);
        public int editar(Cliente cliente);
        public Cliente obtener(int id);
        public IEnumerable<Cliente> filtrarPorEstado(string estado);
        public bool existeEmail(string email);

        public bool existeCliente(int id);
        
        #endregion
    }
}
