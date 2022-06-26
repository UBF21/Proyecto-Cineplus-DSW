using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface ITipoUsuario
    {
        #region Metodos para Implentar
        public IEnumerable<TipoUsuario> listar();
        #endregion
    }
}
