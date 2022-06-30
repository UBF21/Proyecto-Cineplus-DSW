using Cineplus_DSW_Proyecto.Models;
using System.Collections.Generic;

namespace Cineplus_DSW_Proyecto.Repository.IModel
{
    public interface IComestible
    {
        #region Metodos para Implentar
        IEnumerable<Comestible> listar();

        public Comestible obtener(string id);

        public int agregar(Comestible obj);

        public int actualizar(Comestible obj);

        public bool existeComestible(string id);

        public int buscarTipoComestible(string comestible);
        public int buscarTipoProveedor(string proveedor);
        public IEnumerable<Comestible> comestibleFiltro(int tipo);

        public bool transaccionPedido(Comestible obj, int cantidad);
        #endregion
    }
}
