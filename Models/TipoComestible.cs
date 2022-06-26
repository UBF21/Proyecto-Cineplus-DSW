namespace Cineplus_DSW_Proyecto.Models
{
    public class TipoComestible
    {
        #region Atributos
        public int id { get; set; }
        public string descripcion { get; set; }

        #endregion

        #region Constructor
        public TipoComestible()
        {
        }

        public TipoComestible(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        #endregion
    }
}
