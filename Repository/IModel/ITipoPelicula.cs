using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface ITipoPelicula
    {
        public IEnumerable<TipoPelicula> listar();
    }
}
