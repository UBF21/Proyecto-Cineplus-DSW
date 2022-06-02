namespace Cineplus_DSW_Proyecto.Models
{
    public class TipoUsuario
    {

        public int codTipoUser { get; set; }
        public string descripcion { get; set; }

        public TipoUsuario()
        {
        }

        public TipoUsuario(int codTipoUser, string descripcion)
        {
            this.codTipoUser = codTipoUser;
            this.descripcion = descripcion;
        }

    }
}
