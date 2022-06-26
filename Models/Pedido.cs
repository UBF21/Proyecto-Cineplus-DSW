using System;

namespace Cineplus_DSW_Proyecto.Models
{
    public class Pedido
    {
        #region Atributos
        public string codPedido { get; set; }
        public string cod_Comestible { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int id_tipo { get; set; }
        public int id_proveedor { get; set; }
        public int cantidad { get; set; }
        public DateTime fechaPepdido { get; set; }
        #endregion

        #region Constructor
        public Pedido()
        {
        }

        public Pedido(string codPedido, string cod_Comestible, string descripcion, double precio, int id_tipo, int id_proveedor, int cantidad, DateTime fechaPepdido)
        {
            this.codPedido = codPedido;
            this.cod_Comestible = cod_Comestible;
            this.descripcion = descripcion;
            this.precio = precio;
            this.id_tipo = id_tipo;
            this.id_proveedor = id_proveedor;
            this.cantidad = cantidad;
            this.fechaPepdido = fechaPepdido;
        }
        #endregion
    }
}
