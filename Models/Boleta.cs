using System;
using System.ComponentModel.DataAnnotations;

namespace Cineplus_DSW_Proyecto.Models
{
    public class Boleta
    {
        #region Atributos

        [Display(Name = "Código Boleta")]
        public string codBoleta { get; set; }


        [Display(Name = "ID Cliente")]
        public int idCliente { get; set; }


        [Display(Name = "Nombre")]
        public string nombre { get; set; }


        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }


        [Display(Name = "Fecha Boleta")]
        [DataType(DataType.Date)]
        public DateTime fechaBoleta { get; set; }

        
        [Display(Name = "Total")]
        public double precioTotal { get; set; }
        #endregion


        #region Constructor
        public Boleta()
        {
        }

        public Boleta(string codBoleta,int idCliente, string nombre, string email, DateTime fechaBoleta, double precioTotal)
        {
            this.codBoleta = codBoleta;
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.email = email;
            this.fechaBoleta = fechaBoleta;
            this.precioTotal = precioTotal;
        }
        #endregion
    }
}
