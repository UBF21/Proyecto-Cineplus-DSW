using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface ITipoProveedor
    {
        public IEnumerable<TipoProveedor> listar();
    }
}
