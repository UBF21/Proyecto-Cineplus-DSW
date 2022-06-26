using System.ComponentModel.DataAnnotations;

namespace Cineplus_DSW_Proyecto.Models
{
    public class Proveedor
    {
      
        #region Atributos

        [Display(Name = "ID",Order = 0)]
        public int idProveedor { get; set; }

        [Required(ErrorMessage = "Campo Requerido."),MaxLength(50,ErrorMessage = "Solo admite máximo 50 caracteres.")]
        [Display(Name = "Nombre", Order = 1)]
        public string nombre { get; set; }


        [Required(ErrorMessage = "Campo Requerido."),MinLength(9,ErrorMessage = "Requiere 9 dígitos.")]
        [Display(Name = "Teléfono", Order = 2)]
        public string telefono { get; set; }

        [Required(ErrorMessage = "Campo Requerido."),MaxLength(50,ErrorMessage = "Solo admite máximo 50 caracteres.")]
        [Display(Name = "Dirección", Order = 3)]
        public string direccion { get; set; }
        #endregion

        #region Constructor
        public Proveedor()
        {
        }

        public Proveedor(int idProveedor, string nombre, string telefono, string direccion)
        {
            this.idProveedor = idProveedor;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
        }
        #endregion
    }
}
