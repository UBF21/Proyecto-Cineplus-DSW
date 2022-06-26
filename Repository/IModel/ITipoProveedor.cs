using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface ITipoProveedor
    {
        #region Metodos para Implentar
        public IEnumerable<TipoProveedor> listar();
        #endregion
    }
}
