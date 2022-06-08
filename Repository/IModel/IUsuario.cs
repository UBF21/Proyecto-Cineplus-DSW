using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface IUsuario
    {
        public IEnumerable<Usuario> listar();
        public Usuario obtener(string id);
        public int agregar(Usuario obj);
        public int actualizar(Usuario obj);
    }
}
