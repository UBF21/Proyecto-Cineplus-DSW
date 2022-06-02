namespace Cineplus_DSW_Proyecto.Models
{
    public class TipoPelicula
    {

        public int codTipo { get; set; }
        public string descrip { get; set; }


        public TipoPelicula()
        {
        }

        public TipoPelicula(int codTipo, string descrip)
        {
            this.codTipo = codTipo;
            this.descrip = descrip;
        }
    }
}
