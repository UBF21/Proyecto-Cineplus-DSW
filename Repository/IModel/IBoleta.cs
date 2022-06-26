using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface IBoleta
    {
        #region Metodos para Implentar
        public IEnumerable<Boleta> filtrarIDCliente(int id);
        public IEnumerable<Boleta> listar();
        public IEnumerable<Boleta> filtrarPorFecha(int year);
       
        #endregion
    }
}
