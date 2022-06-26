using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface IPelicula
    {
        #region Metodos para Implentar
        public IEnumerable<Pelicula> listar();

        public int crear(Pelicula obj);

        public int actualizar(Pelicula obj);

        public Pelicula obtener(string id);

        public bool existePelicula(string id);
        
        #endregion
    }
}
