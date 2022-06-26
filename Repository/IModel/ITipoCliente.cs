using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface ITipoCliente
    {
        #region Metodos para Implentar
        public IEnumerable<TipoCliente> listar();
        #endregion

    }
}
