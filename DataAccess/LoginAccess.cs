using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Cineplus_DSW_Proyecto.Models;

namespace Cineplus_DSW_Proyecto.DataAccess
{
    public class LoginAccess
    {
        private UsuarioAccess usuarioAccess = new UsuarioAccess();
        public bool existeUsuarioBool(string email, string password)
        {
            bool existe = false;
            if ((string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) || ((string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))))
            {
                existe = false;
            }

            List<Usuario> usuarios = usuarioAccess.listar().ToList();
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

        public Usuario existeUsuariObject(string email, string password)
        {
            Usuario obj;

            if ((string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) || ((string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))))
            {
                return obj = new Usuario();
            }

             obj = usuarioAccess.listar().Where((item) => item.email.Equals(email) && item.password.Equals(password)).First();

            if (obj == null)
            {
                return obj = new Usuario();
            }

            return obj;
        }
    }
}
