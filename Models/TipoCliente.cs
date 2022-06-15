namespace Cineplus_DSW_Proyecto.Models
{
    public class TipoCliente
    { 

        public int idCliente { get; set; }
        public string nombre { get; set; }


        public TipoCliente()
        {
        }

        public TipoCliente(int idCliente, string nombre)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
        }
    }
}
