using System.ComponentModel.DataAnnotations;

namespace Cineplus_DSW_Proyecto.Models
{
    public class Usuario
    {
        #region Atributos

        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "ID",Order = 0)]
        [DataType(DataType.Text)]
        [RegularExpression("^[A]+[0-9]{5}$", ErrorMessage = "El Formato de ID es A00000")]
        public string idUsuario { get; set; }

        
        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Nombre", Order = 1),MaxLength(40,ErrorMessage = "Solo admite máximo 40 caracteres.")]

        public string nombre { get; set; }

        
        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Teléfono", Order = 2),MinLength(9,ErrorMessage = "Solo admite 9 dígitos.")]
        public string telefono { get; set; }


        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Dirección", Order = 3), MaxLength(100, ErrorMessage = "Solo admite máximo 100 caracteres.")]
        public string direccion { get; set; }

        
        [Display(Name = "Tipo", Order = 4)]
        public int tipoUsuario { get; set; }

        
        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Email", Order = 5),MaxLength(50,ErrorMessage = "Solo admite máximo 50 caracteres.")]
        [EmailAddress(ErrorMessage = "El Formato de email es incorrecto.")]
        public string email { get; set; }


        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Contraseña", Order = 6), MaxLength(50, ErrorMessage = "Solo admite máximo 50 caracteres.")]
        
        public string password { get; set; }

        
        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Estado", Order = 7)]
        public string estado { get; set; }

        [Display(Name = "Tipo Usuario", Order = 8)]
        public string descrip_tipo { get; set; }

        #endregion

        #region Constructor
        public Usuario()
        {
        }

        public Usuario(string idUsuario, string nombre, string telefono,string direccion, int tipoUsuario, string email, string password, string estado, string descrip_tipo)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.tipoUsuario = tipoUsuario;
            this.email = email;
            this.password = password;
            this.estado = estado;
            this.descrip_tipo = descrip_tipo;
        }

        #endregion

    }
}
