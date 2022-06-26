using Cineplus_DSW_Proyecto.Models;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface ILogin
    {
        #region Metodos para Implentar
        public bool existeUsuarioBool(string email, string password);
        public Usuario existeUsuariObject(string email, string password);
        
        #endregion
    }
}
