namespace Cineplus_DSW_Proyecto.Models
{
    public class TipoPelicula
    {
        #region Atributos
        public int codTipo { get; set; }
        public string descrip { get; set; }
        #endregion

        #region Constructor
        public TipoPelicula()
        {
        }

        public TipoPelicula(int codTipo, string descrip)
        {
            this.codTipo = codTipo;
            this.descrip = descrip;
        }
        #endregion




    }
}
