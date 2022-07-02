using System;
using System.ComponentModel.DataAnnotations;

namespace Cineplus_DSW_Proyecto.Models
{
    public class Pelicula
    {
        #region Atributos

        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name ="Código",Order = 0)]
        [DataType(DataType.Text)]
        [RegularExpression("^[P]+[0-9]{4}$", ErrorMessage = "El Formato de ID es P0000.")]
        public string codPelicula { get; set; }


        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name ="Nombre", Order = 1),MaxLength(100,ErrorMessage = "Solo se admite máximo 100 caracteres.")]
        public string nombre { get; set; }


        [Display(Name = "Tipo", Order = 2)]
        public int tipoPelicula { get; set; }


        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Fecha Estreno", Order = 3)]
        public DateTime fechaEstreno { get; set; }
        
        
        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Fecha Final", Order = 4)]
        public DateTime fechaFinal { get; set; }
       
        
        [Required(ErrorMessage = "Campo Requerido.")]
        [Display(Name = "Estado", Order = 5)]
        public string estado { get; set; }

        [Display(Name = "Tipo Película", Order = 6)]
        public string descripcionTipo { get; set; }
        #endregion

        #region Constructor
        public Pelicula()
        {
        }

        public Pelicula(string codPelicula, string nombre, int tipoPelicula, DateTime fechaEstreno, DateTime fechaFinal, string estado,string descripcionTipo)
        {
            this.codPelicula = codPelicula;
            this.nombre = nombre;
            this.tipoPelicula = tipoPelicula;
            this.fechaEstreno = fechaEstreno;
            this.fechaFinal = fechaFinal;
            this.estado = estado;
            this.descripcionTipo = descripcionTipo;
        }

        #endregion


    }
}
