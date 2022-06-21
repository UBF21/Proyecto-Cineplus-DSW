namespace Cineplus_DSW_Proyecto.Models.ModelGraphic
{
    public class ClienteGraphic
    {
       
        public int cantidad { get; set; }
        public string estado { get; set; }

        public ClienteGraphic()
        {
        }

        public ClienteGraphic(int cantidad, string estado)
        {
            this.cantidad = cantidad;
            this.estado = estado;
        }

    }
}
