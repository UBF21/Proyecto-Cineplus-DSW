using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using Cineplus_DSW_Proyecto.Models.ModelGraphic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface IClienteGraphic
    {
        #region Metodos para Implentar
        public IEnumerable<ClienteGraphic> clientesDatos();
        
        #endregion
    }
}
