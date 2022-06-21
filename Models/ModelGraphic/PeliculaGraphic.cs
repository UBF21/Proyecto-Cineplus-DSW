namespace Cineplus_DSW_Proyecto.Models.ModelGraphic
{
    public class PeliculaGraphic
    {
     
        public int cantidad { get; set; }
        public string tipo { get; set; }

        public PeliculaGraphic()
        {
        }

        public PeliculaGraphic(int cantidad, string tipo)
        {
            this.cantidad = cantidad;
            this.tipo = tipo;
        }

    }
}
