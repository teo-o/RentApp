using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rentapp.Shared.Entities
{
    public class Car
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;

        [DataType(DataType.MultilineText)]
        [Display(Name = "Descripción")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Description { get; set; } = null!;

        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal PriceHour { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Display(Name = "Inventario")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public float Stock { get; set; }

        [Display(Name = "Modelo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int Model { get; set; }

        [Display(Name = "Placa")]
        [MaxLength(6, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string LicensePlate { get; set; } = null!;

        [Display(Name = "Marca")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int BrandId { get; set; }

        public Brand? Brand { get; set; }


        [Display(Name = "Categoría")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int CarCategoryId { get; set; }

        public CarCategory? Category { get; set; }

        public ICollection<Rent>? Rents { get; set; }

        [Display(Name = "Rentas")]
        public int RentsNumber => Rents == null ? 0 : Rents.Count;

        public ICollection<CarImage>? CarImages { get; set; }

        [Display(Name = "Imágenes")]
        public int CarImagesNumber => CarImages == null ? 0 : CarImages.Count;

        [Display(Name = "Imagén")]
        public string MainImage => CarImages == null ? string.Empty : CarImages.FirstOrDefault()!.Image;

    }
}
