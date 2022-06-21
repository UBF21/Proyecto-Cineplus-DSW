namespace Cineplus_DSW_Proyecto.Models.ModelGraphic
{
    public class ComestibleGraphic
    {
       
        public int cantidad { get; set; }
        public string tipo { get; set; }

        public ComestibleGraphic()
        {
        }

        public ComestibleGraphic(int cantidad, string tipo)
        {
            this.cantidad = cantidad;
            this.tipo = tipo;
        }

    }
}
