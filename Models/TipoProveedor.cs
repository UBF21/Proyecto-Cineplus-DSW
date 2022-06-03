namespace Cineplus_DSW_Proyecto.Models
{
    public class TipoProveedor
    {

        public int id { get; set; }
        public string nombre { get; set; }

        public TipoProveedor()
        {
        }

        public TipoProveedor(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
