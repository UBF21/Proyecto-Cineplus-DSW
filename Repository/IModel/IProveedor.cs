using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface IProveedor
    {
        #region Metodos para Implentar
        public IEnumerable<Proveedor> listar();

        public Proveedor obtener(int id);

        public int agregar(Proveedor obj);

        public int actualizar(Proveedor obj);

        public int eliminar(int id);
        #endregion
    }
}
