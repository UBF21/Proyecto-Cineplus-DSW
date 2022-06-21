using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface IComestible
    {
        IEnumerable<Comestible> listar();

        public Comestible obtener(string id);

        public int agregar(Comestible obj);

        public int actualizar(Comestible obj);

        public bool existeComestible(string id);

        public IEnumerable<Comestible> comestibleFiltro(int tipo);
    }
}
