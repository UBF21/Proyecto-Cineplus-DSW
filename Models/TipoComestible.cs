namespace Cineplus_DSW_Proyecto.Models
{
    public class TipoComestible
    { 

        public int id { get; set; }
        public string descripcion { get; set; }

        public TipoComestible()
        {
        }

        public TipoComestible(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }
    }
}
