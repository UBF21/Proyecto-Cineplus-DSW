namespace Cineplus_DSW_Proyecto.Models.ModelGraphic
{
    public class UsuarioGraphic
    {
   
        public int cantidad { get; set; }
        public string rol { get; set; }

        public UsuarioGraphic()
        {
        }

        public UsuarioGraphic(int cantidad, string rol)
        {
            this.cantidad = cantidad;
            this.rol = rol;
        }
    }
}
