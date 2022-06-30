using System.ComponentModel.DataAnnotations;

namespace Cineplus_DSW_Proyecto.Models
{
    public class Comestible
    {
        #region Atributos

        [Required(ErrorMessage ="Campo Requerido.")]
        [Display(Name = "Código",Order = 0)]
        [DataType(DataType.Text)]
        [RegularExpression("^[C]+[0-9]{4}$", ErrorMessage = "El Formato de ID es C0000")]
        public string idComestible { get; set; }

        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Descripción", Order = 1),MaxLength(50,ErrorMessage = "Solo admite máximo 40 caracteres.")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Precio", Order = 2)]
        public double precio { get; set; }

        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Stock", Order = 3)]
        public int stock { get; set; }

        [Display(Name = "Tipo Comestible", Order = 4)]
        public int idTipo { get; set; }

        [Display(Name = "Tipo Proveedor", Order = 5)]
        public int idProveedor { get; set; }
    
        [Display(Name = "Estado", Order = 6)]
        public string estado { get; set; }

        [Display(Name = "Comestible", Order = 7)]
        public string descripcionComestible { get; set; }

        [Display(Name = "Proveedor", Order = 8)]
        public string descripcionProveedor { get; set; }
        #endregion

        #region Constructor

        public Comestible()
        {
        }

        public Comestible(string idComestible, string descripcion, double precio, int stock, int idTipo, int idProveedor, string estado)
        {
            this.idComestible = idComestible;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
            this.idTipo = idTipo;
            this.idProveedor = idProveedor;
            this.estado = estado;
        }
        #endregion
    }
}
