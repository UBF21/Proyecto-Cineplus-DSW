using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface ITipoPelicula
    {
        #region Metodos para Implentar
        public IEnumerable<TipoPelicula> listar();
        #endregion
    }
}
