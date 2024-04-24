using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentapp.Shared.Entities
{
    public class CarCategory
    {
        public int Id { get; set; }

        [Display(Name = "Categoría")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;
        public ICollection<Car>? Cars { get; set; }

        [Display(Name = "Vehiculos")]
        public int CarNumber => Cars == null ? 0 : Cars.Count;
    }
}
