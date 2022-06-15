﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Cineplus_DSW_Proyecto.Models
{
    public class Pelicula
    {

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name ="Código",Order = 0), MaxLength(5, ErrorMessage = "Solo se admite máximo 4 caracteres.")]
        public string codPelicula { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name ="Nombre", Order = 1),MaxLength(100,ErrorMessage = "Solo se admite máximo 100 caracteres.")]
        public string nombre { get; set; }


        [Display(Name = "Tipo Película", Order = 2)]
        public int tipoPelicula { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Fecha Estreno", Order = 3)]
        public DateTime fechaEstreno { get; set; }
        
        
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Fecha Final", Order = 4)]
        public DateTime fechaFinal { get; set; }
       
        
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Estado", Order = 5)]
        public string estado { get; set; }

        public Pelicula()
        {
        }

        public Pelicula(string codPelicula, string nombre, int tipoPelicula, DateTime fechaEstreno, DateTime fechaFinal, string estado)
        {
            this.codPelicula = codPelicula;
            this.nombre = nombre;
            this.tipoPelicula = tipoPelicula;
            this.fechaEstreno = fechaEstreno;
            this.fechaFinal = fechaFinal;
            this.estado = estado;
        }


    }
}
