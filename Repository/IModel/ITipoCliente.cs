using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface ITipoCliente
    {
        public IEnumerable<TipoCliente> listar();

    }
}
