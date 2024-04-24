using Rentapp.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Rentapp.Shared.Entities
{
    public class Rent
    {
        public int Id { get; set; }

        public User User { get; set; } = null!;

        public int UserId { get; set; }

        public Car? Car { get; set; }

        public int CarId { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        [Display(Name = "Fecha/Hora Inicio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        [Display(Name = "Fecha/Hora Fin")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateTime EndDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        [Display(Name = "Fecha/Hora Entregado")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateTime RealEndDate { get; set; }

        //Precio es un campo calculado en base a la cantidad de horas de alquiler
        public decimal Price { get; set; }

        public RentStatus RentStatus { get; set; }

        public string? Remarks { get; set; }    
    }
}
