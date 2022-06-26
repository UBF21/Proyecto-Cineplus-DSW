using Cineplus_DSW_Proyecto.Models;
using Cineplus_DSW_Proyecto.Repository.IModel;
using System.Collections.Generic;
using System.Linq;

namespace Cineplus_DSW_Proyecto.Repository.Implents
{
    public class LoginRepository : ILogin
    {
        #region Acceso a datos

        private IUsuario repoUsuario;

        public LoginRepository()
        {
            repoUsuario = new UsuarioRepository();
        }
        #endregion


        public Usuario existeUsuariObject(string email, string password)
        {
            Usuario obj;

            if ((string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) || ((string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))))
            {
                return obj = new Usuario();
            }

            obj = repoUsuario.listar().Where((item) => item.email.Equals(email) && item.password.Equals(password)).First();

            if (obj == null)
            {
                return obj = new Usuario();
            }

            return obj;
        }

        public bool existeUsuarioBool(string email, string password)
        {
            bool existe = false;
            if ((string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) || ((string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))))
            {
                existe = false;
            }

            List<Usuario> usuarios = repoUsuario.listar().ToList();
            foreach (var item in usuarios)
            {
                if (item.email.Equals(email) && item.password.Equals(password))
                {
                    existe = true;
                    break;
                }
                else
                {
                    existe = false;
                }
            }


            return existe;
        }
    }
}
