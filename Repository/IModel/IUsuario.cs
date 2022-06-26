using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface IUsuario
    {
        #region Metodos para Implentar
        public IEnumerable<Usuario> listar();
        public Usuario obtener(string id);
        public int agregar(Usuario obj);
        public int actualizar(Usuario obj);
        public string obtenerRol(int rol);
        public bool existeUsuario(string id);
        public bool existeEmail(string email);
        public IEnumerable<Usuario> usuariosFiltrado(int tipo);
        #endregion
    }
}
