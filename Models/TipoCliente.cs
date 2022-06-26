namespace Cineplus_DSW_Proyecto.Models
{
    public class TipoCliente
    {
        #region Atributos
        public int idCliente { get; set; }
        public string nombre { get; set; }

        #endregion

        #region Constructor
        public TipoCliente()
        {
        }

        public TipoCliente(int idCliente, string nombre)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
        }

        #endregion
    }
}
