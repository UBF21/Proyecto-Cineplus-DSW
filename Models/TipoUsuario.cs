namespace Cineplus_DSW_Proyecto.Models
{
    public class TipoUsuario
    {
        #region Atributos
        public int codTipoUser { get; set; }
        public string descripcion { get; set; }


        #endregion

        #region Constructor
        public TipoUsuario()
        {
        }

        public TipoUsuario(int codTipoUser, string descripcion)
        {
            this.codTipoUser = codTipoUser;
            this.descripcion = descripcion;
        }

        #endregion

    }
}
