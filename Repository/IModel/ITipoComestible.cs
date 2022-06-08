using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface ITipoComestible
    {
        public IEnumerable<TipoComestible> listar();
    }
}
