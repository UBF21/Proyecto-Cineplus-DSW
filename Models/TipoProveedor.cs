namespace Cineplus_DSW_Proyecto.Models
{
    public class TipoProveedor
    {
        #region Atributos
        public int id { get; set; }
        public string nombre { get; set; }

        #endregion

        #region Constructor
        public TipoProveedor()
        {
        }

        public TipoProveedor(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        #endregion
    }
}
