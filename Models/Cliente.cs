using System.ComponentModel.DataAnnotations;

namespace Cineplus_DSW_Proyecto.Models
{
    public class Cliente
    {

        #region Atributos
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Nombre", Order = 1), MaxLength(40, ErrorMessage = "Solo se admite máximo 40 caracteres.")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Teléfono", Order = 2), StringLength(9, ErrorMessage = "Solo se admite 9 dígitos.")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Dirección", Order = 3), MaxLength(100, ErrorMessage = "Solo se admite máximo 100 caracteres.")]
        public string direccion { get; set; }

        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Email", Order = 4)]
        [EmailAddress(ErrorMessage = "El Formato de email es incorrecto.")]
        public string email { get; set; }

        [Display(Name = "Estado", Order = 5)]
        public string estado { get; set; }
        #endregion


        #region Constructor,metodos
        
        public Cliente() { }

        public Cliente(int id, string nombre, string telefono, string direccion, string email, string estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.estado = estado;
        }

        public override string ToString()
        {
            return "[" + "ID: " + this.id + ",Nombre: " + this.nombre + ",Telefono : " + this.telefono + ",Direccion :" + this.direccion + ", Email: " + this.email + ", Estado: " + this.estado + "]";
        }
        #endregion
    }
}
